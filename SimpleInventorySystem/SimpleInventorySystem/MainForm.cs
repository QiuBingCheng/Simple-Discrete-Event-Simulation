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
        int minimumLevel;
        int maximumLevel;
        int numberOfPeriods;
        double ItemCost;
        double SetupCost;
        double HoldingCost;
        double ShortageCost;

        //new data 
        int mu;
        double std;

        public MyForm()
        {
            InitializeComponent();
            btnSaveFile.Enabled = false;
        }

        private void openProblemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() != DialogResult.OK) return;

            Name = Path.GetFileName(dlgOpen.FileName);
            StringBuilder sb = new StringBuilder();
            StreamReader sr = new StreamReader((dlgOpen.FileName));
            char[] seps = { ' ', ',' };
            string[] items = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
            minimumLevel = Convert.ToInt32(items[0]);
            maximumLevel = Convert.ToInt32(items[1]);
            numberOfPeriods = Convert.ToInt32(items[2]);
            demandQuantity = new int[numberOfPeriods];
            sb.Append($"{minimumLevel} {maximumLevel} {numberOfPeriods}\r\n");

            for (int i = 0; i < numberOfPeriods; i++)
            {
                demandQuantity[i] = Convert.ToInt32(sr.ReadLine().Trim());
                sb.Append($"{demandQuantity[i]}\r\n");
            }

            items = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
            ItemCost = Convert.ToInt32(items[0]);
            SetupCost = Convert.ToInt32(items[1]);
            HoldingCost = Convert.ToInt32(items[2]);
            ShortageCost = Convert.ToInt32(items[3]);
            sb.Append($"{ItemCost} {SetupCost} {HoldingCost} {ShortageCost}");
            sr.Close();

            lbItemCost.Text = lbItemCost.Text.Split('：')[0] + '：' + ItemCost;
            lbHoldingCost.Text = lbHoldingCost.Text.Split('：')[0] + '：' + HoldingCost;
            lbSetupCost.Text = lbSetupCost.Text.Split('：')[0] + '：' + SetupCost;
            lbShortageCost.Text = lbShortageCost.Text.Split('：')[0] + '：' + ShortageCost;

            tbInventoryInfo.Text = sb.ToString();
            lbProblemName.Text = lbProblemName.Text.Split('：')[0] + '：' + Name;
            btnSimulateTheInventory.Enabled = true;
            btnFidnOptimum.Enabled = true;

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
        private void btnCreateData_Click(object sender, EventArgs e)
        {
           
            minimumLevel = Convert.ToInt32(nudMinimumInventory.Value);
            maximumLevel = Convert.ToInt32(nudMaximumInventoryLevel.Value);
            numberOfPeriods = Convert.ToInt32(nudNumberOfIntervals.Value);
            mu = Convert.ToInt32(nudAverageDemand.Value);
            std = Math.Sqrt(Convert.ToDouble(tbDemandVariance.Text));
            ItemCost = Convert.ToInt32(tbItemCost.Text);
            SetupCost = Convert.ToInt32(tbOrderSetupCost.Text);
            HoldingCost = Convert.ToInt32(tbHoldingCost.Text);
            ShortageCost = Convert.ToInt32(tbShortageCost.Text);
            demandQuantity = new int[numberOfPeriods];

            StringBuilder sb = new StringBuilder();
            sb.Append($"{minimumLevel} {maximumLevel} {numberOfPeriods}\r\n");

            for (int i = 0; i < numberOfPeriods; i++)
            {
                demandQuantity[i] = Convert.ToInt32(GaussianRandomGenerator(mu, std));
                sb.Append($"{demandQuantity[i]}\r\n");
            }

            sb.Append($"{ItemCost} {SetupCost} {HoldingCost} {ShortageCost}");
            lbItemCost.Text = lbItemCost.Text.Split('：')[0]+"："+ItemCost.ToString();
            lbSetupCost.Text = lbSetupCost.Text.Split('：')[0] + "：" + SetupCost.ToString();
            lbShortageCost.Text = lbShortageCost.Text.Split('：')[0] + "：" + ShortageCost.ToString();
            lbHoldingCost.Text = lbHoldingCost.Text.Split('：')[0] + "：" + HoldingCost.ToString();
            lbProblemName.Text = lbProblemName.Text.Split('：')[0] + "：" + "New Problem";
            tbInventoryInfo.Text = sb.ToString();
            btnSaveFile.Enabled = true;
            btnSimulateTheInventory.Enabled = true;

            MessageBox.Show("Create data sucessfully! You can simulate new data or save it!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        void AddPoint(int x,int y)
        {
            inventoryChart.Series["Inventory Level"].Points.AddXY(x, y);
        }

        private void btnSimulateTheProcess_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();

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
            lbAverDemand.Text = lbAverDemand.Text.Split('：')[0] + "：" + (quantity/(float)numberOfPeriods).ToString("00.000");
            lbAverOrder.Text = lbAverOrder.Text.Split('：')[0] + "：" + (totalOrder / (float)numberOfPeriods).ToString("00.000");
            lbAverageOrder2.Text = lbAverageOrder2.Text.Split('：')[0]+ "：" + ((orderCount/(float)numberOfPeriods)).ToString("00.000");
            
            lbTimeAveragedHoldingLevel.Text = lbTimeAveragedHoldingLevel.Text.Split('：')[0] + "：" + (holdingArea / numberOfPeriods).ToString("00.000");
            lbTimeAveragedShortageLevel.Text = lbTimeAveragedShortageLevel.Text.Split('：')[0] + "：" + (shortageArea / numberOfPeriods).ToString("00.000");
            sw.Stop();
            lbMessage.Text = sw.Elapsed.TotalSeconds + " Sec    / " +((float)sw.Elapsed.TotalSeconds / 60.0).ToString("N2") +" min";
        }

        private void btnFindOptimum_Click(object sender, EventArgs e)
        {
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
            lbBestMinumLevel.Text = lbBestMinumLevel.Text.Split('：')[0] + "：" + bestMinimumLevel;
            lbMinumumCostSpent.Text = lbMinumumCostSpent.Text.Split('：')[0] + "：" + miniumSpent;
            lbMessage.Text = sw.Elapsed.TotalSeconds + " Sec    / " + ((float)sw.Elapsed.TotalSeconds / 60.0).ToString("N2") + " min";
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() != DialogResult.OK)
                return;

            string path = dlgSave.FileName;

            using (StreamWriter outputFile = new StreamWriter(path))
            {
                outputFile.WriteLine($"{minimumLevel} {maximumLevel} {numberOfPeriods}");
                for (int i = 0; i < numberOfPeriods; i++)
                    outputFile.WriteLine($"{demandQuantity[i]}");

                outputFile.WriteLine($"{ItemCost} {SetupCost} {HoldingCost} {ShortageCost}");
                outputFile.Close();
                MessageBox.Show("save data sucessfully~", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
