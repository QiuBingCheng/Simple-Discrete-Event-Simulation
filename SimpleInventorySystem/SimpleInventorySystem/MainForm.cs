using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimpleInventorySystem
{
    public partial class MyForm : Form
    {
        Random random = new Random();
        int[] demandQuantity;
     
        public MyForm()
        {
            InitializeComponent();

            // default setting
            nudMinimumInventory.Value = 20;
            nudMaximumInventory.Value = 60;
            nudNumberOfIntervals.Value = nudNumberOfIntervals2.Value = 12;
            nudAverageDemand.Value = nudAverageDemand2.Value = 25;
            tbDemandVariance.Text = tbDemandVariance2.Text = "12";
            tbItemCost.Text = "8000";
            tbOrderSetupCost.Text = "1000";
            tbHoldingCost.Text = "25";
            tbShortageCost.Text = "700";

            // genereate demand
            generateDemandData();

        }
        private void generateDemandData()
        {
            int numberOfPeriods = (int)nudNumberOfIntervals.Value;
            demandQuantity = new int[numberOfPeriods];
            int mu = (int)nudAverageDemand.Value;
            double std = Math.Sqrt(Convert.ToDouble(tbDemandVariance.Text));

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < numberOfPeriods; i++)
            {
                demandQuantity[i] = Convert.ToInt32(GaussianRandomGenerator(mu, std));
                sb.Append($"d{i + 1} = {demandQuantity[i]}\r\n");
            }
            tbDemandData.Text = sb.ToString();
        }
        private void openProblemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() != DialogResult.OK) return;

            Name = Path.GetFileName(dlgOpen.FileName);
            StringBuilder sb = new StringBuilder();
            StreamReader sr = new StreamReader((dlgOpen.FileName));
            char[] seps = { ':'};
            string[] items;

            items = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
            nudMinimumInventory.Value = Convert.ToInt32(items[1].Trim());

            items = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
            nudMaximumInventory.Value = Convert.ToInt32(items[1].Trim());

            items = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
            nudNumberOfIntervals.Value = Convert.ToInt32(items[1].Trim());

            items = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
            nudAverageDemand.Value = Convert.ToInt32(items[1].Trim());

            items = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
            tbDemandVariance.Text = items[1].Trim();

            items = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
            tbItemCost.Text = items[1].Trim();

            items = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
            tbOrderSetupCost.Text = items[1].Trim();

            items = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
            tbHoldingCost.Text = items[1].Trim();

            items = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
            tbShortageCost.Text = items[1].Trim();

            sr.Close();
            lbSettingsName.Text = dlgOpen.FileName;
            generateDemandData();
            MessageBox.Show("Load settings sucessfully~", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private double GaussianRandomGenerator(double mu, double sigma)
        {
            ////uniform(0,1] random doubles
            double u1 = 1.0 - random.NextDouble();
            double u2 = 1.0 - random.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                         Math.Sin(2.0 * Math.PI * u2);
            return mu + sigma * randStdNormal;
        }
     
        void AddPoint(int x,int y)
        {
            inventoryChart.Series["Inventory Level"].Points.AddXY(x, y);
        }

        private void btnSimulateTheProcess_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();

            // read setting
            int minimumLevel = (int)nudMinimumInventory.Value;
            int maximumLevel = (int)nudMaximumInventory.Value;
            int numberOfPeriods = (int)nudNumberOfIntervals.Value;
            double ItemCost = Convert.ToDouble(tbItemCost.Text);
            double SetupCost = Convert.ToDouble(tbOrderSetupCost.Text);
            double HoldingCost = Convert.ToDouble(tbHoldingCost.Text);
            double ShortageCost = Convert.ToDouble(tbShortageCost.Text); 

            //clear chart
            for (int i = 0; i < 3; i++)
                inventoryChart.Series[i].Points.Clear();
            
            //horizonetal lien
            inventoryChart.Series["Minimum Level"].Points.AddXY(0, minimumLevel);
            inventoryChart.Series["Minimum Level"].Points.AddXY(numberOfPeriods, minimumLevel);

            inventoryChart.Series["Maximun Level"].Points.AddXY(0, maximumLevel);
            inventoryChart.Series["Maximun Level"].Points.AddXY(numberOfPeriods, maximumLevel);
            int totalOrder = 0;
            int orderCount = 0;
            int quantity = 0;
            double holdingArea = 0;
            double shortageArea = 0;
            double previousLevel;
            int inventory = maximumLevel;
           
            //initialization
            AddPoint(0, inventory);
            
            for (int i = 0; i < numberOfPeriods; i++)
            {
                quantity += demandQuantity[i];
                previousLevel = inventory;
                inventory -= demandQuantity[i];
                AddPoint(i+1, inventory);

                if (inventory < 0)
                {
                    double bottom = previousLevel / demandQuantity[i];
                    holdingArea += bottom * previousLevel / 2.0;
                    shortageArea += (1 - bottom) * (demandQuantity[i] - previousLevel) / 2;
                }
                else
                    holdingArea += (previousLevel - demandQuantity[i] / 2.0);

                if (inventory < minimumLevel)
                {
                    totalOrder += (maximumLevel - inventory);
                    inventory = maximumLevel;
                    AddPoint(i + 1, inventory);
                    orderCount++;
                }
            }

            if (maximumLevel - inventory > 0)
            {
                orderCount++;
                totalOrder += (maximumLevel - inventory);
            }

            AddPoint(numberOfPeriods, maximumLevel);
            lbAverDemand.Text = lbAverDemand.Text.Split('：')[0] + "： " + (quantity/(float)numberOfPeriods).ToString("00.00");
            lbAverOrder.Text = lbAverOrder.Text.Split('：')[0] + "： " + (totalOrder / (float)numberOfPeriods).ToString("00.00");
            
            lbTimeAveragedHoldingLevel.Text = lbTimeAveragedHoldingLevel.Text.Split('：')[0] + "： " + (holdingArea / numberOfPeriods).ToString("00.00");
            lbTimeAveragedShortageLevel.Text = lbTimeAveragedShortageLevel.Text.Split('：')[0] + "： " + (shortageArea / numberOfPeriods).ToString("00.00");
            sw.Stop();
            lbMessage.Text = sw.Elapsed.TotalSeconds + " Sec    / " +((float)sw.Elapsed.TotalSeconds / 60.0).ToString("N2") +" min";
        }

        private void btnFindOptimum_Click(object sender, EventArgs e)
        {
            // read setting
            int maximumLevel = (int)nudMaximumInventory.Value;
            int numberOfPeriods = (int)nudNumberOfIntervals.Value;
            double ItemCost = Convert.ToDouble(tbItemCost.Text);
            double SetupCost = Convert.ToDouble(tbOrderSetupCost.Text);
            double HoldingCost = Convert.ToDouble(tbHoldingCost.Text);
            double ShortageCost = Convert.ToDouble(tbShortageCost.Text);


            System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 3; i++)
                OptimizationChart.Series[i].Points.Clear();
            
            double miniumSpent = double.MaxValue;
            double bestMinimumLevel = 0;

            for (int minimumLevel = 0; minimumLevel < maximumLevel; minimumLevel++)
            {
                int totlaOrder = 0;
                int quantity = 0;
                int orderCount = 0;
                double holdingArea = 0;
                double shortageArea = 0;
                double previousLevel;
                int inventory = maximumLevel;

                //initialization
                for (int i = 0; i < numberOfPeriods; i++)
                {
                    quantity += demandQuantity[i];
                    previousLevel = inventory;
                    inventory -= demandQuantity[i];

                    //缺貨發生
                    if (inventory < 0)
                    {
                        double bottom = previousLevel / demandQuantity[i];
                        holdingArea += bottom * previousLevel / 2.0;
                        shortageArea += (1 - bottom) * (demandQuantity[i] - previousLevel) / 2;
                    }
                    else
                        holdingArea += (previousLevel - demandQuantity[i] / 2.0);

                    //補貨
                    if (inventory < minimumLevel)
                    {
                        totlaOrder += (maximumLevel - inventory);
                        inventory = maximumLevel;
                        orderCount++;
                    }
                }
                if(maximumLevel - inventory > 0)
                    orderCount++;
               
                double totalShortageCost = ShortageCost * (shortageArea/numberOfPeriods) ;
                double totalHoldingCost = HoldingCost * (holdingArea / numberOfPeriods);
                double totalSetUpCost = SetupCost * (orderCount/(float)numberOfPeriods);
                double totalCost = totalShortageCost + totalHoldingCost + totalSetUpCost;
                if (totalCost < miniumSpent)
                {
                    miniumSpent = totalCost;
                    bestMinimumLevel = minimumLevel;
                }
                OptimizationChart.Series["Shortage Spent"].Points.AddXY(minimumLevel, totalShortageCost);
                OptimizationChart.Series["Holding Spent"].Points.AddXY(minimumLevel, totalHoldingCost);
                OptimizationChart.Series["Setup Spent"].Points.AddXY(minimumLevel, totalSetUpCost);
            }

            sw.Stop();
            lbBestMinumLevel.Text = lbBestMinumLevel.Text.Split('：')[0] + "： " + bestMinimumLevel.ToString("00.00"); ;
            lbMinumumCostSpent.Text = lbMinumumCostSpent.Text.Split('：')[0] + "： " + miniumSpent.ToString("00.00");
            lbMessage.Text = sw.Elapsed.TotalSeconds + " Sec    / " + ((float)sw.Elapsed.TotalSeconds / 60.0).ToString("N2") + " min";
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() != DialogResult.OK)
                return;

            string path = dlgSave.FileName;

            // save file
            using (StreamWriter outputFile = new StreamWriter(path))
            {
                outputFile.WriteLine($"Minimum Inventory Level: {nudMinimumInventory.Value}");
                outputFile.WriteLine($"Maximum Inventory Level: {nudMaximumInventory.Value}");
                outputFile.WriteLine($"number Of Periods: {nudNumberOfIntervals.Value}");
                outputFile.WriteLine($"Average Demand: {nudAverageDemand.Value}");
                outputFile.WriteLine($"Demand Variance: {Convert.ToDouble(tbDemandVariance.Text)}");
                outputFile.WriteLine($"Item Cost: {Convert.ToDouble(tbItemCost.Text)}");
                outputFile.WriteLine($"Order Setup Cost: {Convert.ToDouble(tbOrderSetupCost.Text)}");
                outputFile.WriteLine($"Holding Cost: {Convert.ToDouble(tbHoldingCost.Text)}");
                outputFile.WriteLine($"Shortage Cost: {Convert.ToDouble(tbShortageCost.Text)}");
                outputFile.Close();
                MessageBox.Show("Save settings sucessfully~", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lbSettingsName.Text = dlgSave.FileName;
        }

        private void btnGenerateDemand_Click(object sender, EventArgs e)
        {
            generateDemandData();
        }

        private void OptimizationChart_Click(object sender, EventArgs e)
        {

        }

        private void nudNumberOfIntervals_ValueChanged(object sender, EventArgs e)
        {
            nudNumberOfIntervals2.Value = nudNumberOfIntervals.Value;
            generateDemandData();
        }

        private void nudAverageDemand_ValueChanged(object sender, EventArgs e)
        {
           
            nudAverageDemand2.Value = nudAverageDemand.Value;
            generateDemandData();
        }

        private void tbDemandVariance_TextChanged(object sender, EventArgs e)
        {

            tbDemandVariance2.Text = tbDemandVariance.Text;
            generateDemandData();
        }
    }
}
