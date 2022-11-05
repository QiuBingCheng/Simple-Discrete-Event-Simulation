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

namespace SingleServerQueueMonitoring
{
    public partial class MyForm : Form
    {
        Random random = new Random();
        int numberOfJobs;
        double[] arrivalTimes;
        double[] serviceTimes;
        double[] delayTimes;
        double[] completionTimes;
        double[] startTimes;

        public MyForm()
        {
            InitializeComponent();
            utilizationChart.ChartAreas[0].AxisX.Maximum = 1;
            //utilizationChart.ChartAreas[0].AxisX.MajorTickMark = 
        }

        private void openProblemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() != DialogResult.OK) return;


            Name = Path.GetFileName(dlgOpen.FileName);
            StreamReader sr = new StreamReader((dlgOpen.FileName));
            string str = sr.ReadLine();

            int num = Convert.ToInt32(str);
            arrivalTimes = new double[num];
            serviceTimes = new double[num];
            delayTimes = new double[num];
            completionTimes = new double[num];
            startTimes = new double[num];

            char[] seps = { ' ', ',' };
            string[] items;
            for (int i = 0; i < num; i++)
            {
                items = sr.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries);
                arrivalTimes[i] = Convert.ToDouble(items[0]);
                serviceTimes[i] = Convert.ToDouble(items[1]);
                delayTimes[i] = (i == 0) ? 0 : Math.Max(completionTimes[i - 1] - arrivalTimes[i], 0);
                startTimes[i] = arrivalTimes[i] + delayTimes[i];
                completionTimes[i] = startTimes[i] + serviceTimes[i];
            }
            sr.Close();

            dgvJobInfo.Rows.Clear();
            for (int i = 0; i < arrivalTimes.Length; i++)
            {
                dgvJobInfo.Rows.Add(i, arrivalTimes[i], serviceTimes[i],
                                      delayTimes[i], completionTimes[i]);
            }
          
            lbProblemName.Text = lbProblemName.Text.Split('：')[0]+ "： " +Name;
            btnSimulateTheProcess.Enabled = true;
            btnSimulateVariousServiceTime.Enabled = true;
            cbJobsInService.Checked = true;
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
            double averageInterarrivalTime = Convert.ToDouble(tbAverageInterarrivalTime.Text);
            double arrivalDeviation = Convert.ToDouble(tbArrivalDeviation.Text);
            double averageServiceTime = Convert.ToDouble(tbAverageServiceTime.Text);
            double serviceDeviation = Convert.ToDouble(tbServiceDeviation.Text);

            numberOfJobs = Convert.ToInt32(nudNumberofJobs.Value);

            arrivalTimes = new double[numberOfJobs];
            serviceTimes = new double[numberOfJobs];
            delayTimes = new double[numberOfJobs];
            startTimes = new double[numberOfJobs];
            completionTimes = new double[numberOfJobs];

            double arrivalAccumulation = 0;
            double interarrival;
            for (int i = 0; i < numberOfJobs; i++)
            {
                //arrival,service time follow normal distribution
                interarrival = Math.Round(GaussianRandomGenerator(averageInterarrivalTime, arrivalDeviation));
                arrivalAccumulation = Math.Max(0,interarrival+ arrivalAccumulation);
                arrivalTimes[i] = arrivalAccumulation;
                serviceTimes[i] = Math.Max(0,Math.Round(GaussianRandomGenerator(averageServiceTime, serviceDeviation), 2));
            }
            Array.Sort(arrivalTimes);
            Array.Sort(serviceTimes);
            for (int i = 0; i < numberOfJobs; i++)
            {
                delayTimes[i] = (i == 0) ? 0 : Math.Max(completionTimes[i - 1] - arrivalTimes[i], 0);
                completionTimes[i] = arrivalTimes[i] + delayTimes[i] + serviceTimes[i];
            }
            
            dgvJobInfo.Rows.Clear();
            for (int i = 0; i<arrivalTimes.Length; i++)
            {
                dgvJobInfo.Rows.Add(i, arrivalTimes[i], serviceTimes[i],
                                      delayTimes[i], completionTimes[i]);
            }
            btnSimulateTheProcess.Enabled = true;
            btnSimulateVariousServiceTime.Enabled = true;
            lbProblemName.Text = lbProblemName.Text.Split('：')[0] + "： *Untitled";
            MessageBox.Show("Create data sucessfully！You can simulate the new data or save it if yout want.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
        
        }
        
        void AddPointToNode(double x,int y )
        {
            jobCountChart.Series["Jobs in Nodes l(t)"].Points.AddXY(x,y);
        }
        void AddPointToService(double x, int y)
        {
            jobCountChart.Series["Jobs In Service x(t)"].Points.AddXY(x,y);
        }
        void AddPointToQueue(double x, int y)
        {
            jobCountChart.Series["Jobs in Queue q(t)"].Points.AddXY(x,y);
        }

        private void btnSimulateTheProcess_Click(object sender, EventArgs e)
        {
            double serviceTimeFactor;
            try
            {
                serviceTimeFactor = Convert.ToDouble(tbServiceTimeFactor.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Service Time Factor should be number!", "Type error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();

            jobCountChart.Series["Jobs in Nodes l(t)"].Points.Clear();
            jobCountChart.Series["Jobs in Queue q(t)"].Points.Clear();
            jobCountChart.Series["Jobs In Service x(t)"].Points.Clear();
            
            int n = arrivalTimes.Length;
            //arrival、completion index
            int i = 0; 
            int j = 0;

            // count in node,queue,service
            int countInNode = 0;
            int countInQueue = 0; 
            int countInService = 0;

            //total area in node,queue,service
            double areaOfNode = 0;
            double areaOfQueue = 0;
            double areaOfService = 0;

            //last event time
            double t = 0;
            completionTimes[j] = double.MaxValue; 

            AddPointToNode(0, 0); AddPointToService(0, 0); AddPointToQueue(0, 0);
            while (j < n)
            {
                //arrival event
                if (i<n && arrivalTimes[i] < completionTimes[j])
                {
                    //calculate area 
                    areaOfNode += countInNode * (arrivalTimes[i] - t);
                    areaOfQueue += countInQueue * (arrivalTimes[i] - t);
                    areaOfService += countInService * (arrivalTimes[i] - t);

                    countInNode++;
                    AddPointToNode(arrivalTimes[i],countInNode);
                    //server is busy so going to queue 
                    if (countInService > 0)
                    {
                        countInQueue++;
                        AddPointToQueue(arrivalTimes[i], countInQueue);
                        delayTimes[i] = Math.Max(0, completionTimes[i - 1] - arrivalTimes[i]);
                        completionTimes[i] = arrivalTimes[i] + delayTimes[i] + serviceTimes[i] * serviceTimeFactor;
                    }
                    else
                    {
                        countInService++; AddPointToService(arrivalTimes[i], countInService);
                        delayTimes[i] = 0;
                        completionTimes[i] = arrivalTimes[i] + serviceTimes[i] * serviceTimeFactor;
                    }

                    t = arrivalTimes[i];
                    i++;
                }
                // completion event
                else
                {
                    areaOfNode += countInNode * (completionTimes[j] - t);
                    areaOfQueue += countInQueue * (completionTimes[j] - t);
                    areaOfService += countInService * (completionTimes[j] - t);

                    countInNode--;
                    AddPointToNode(completionTimes[j], countInNode);

                    if (countInQueue > 0)
                    {
                        countInQueue--;
                        AddPointToQueue(completionTimes[j], countInQueue);
                    }
                    else
                    {
                        countInService--;
                        AddPointToService(completionTimes[j], countInService);
                    }

                    t = completionTimes[j];
                    j++;
                }
            }
         
            //average 
            lbAverInterarrivalTime.Text = lbAverInterarrivalTime.Text.Split('：')[0] + "： " + (arrivalTimes[n - 1] / n).ToString("0.00");
            lbAverDelayTime.Text = lbAverDelayTime.Text.Split('：')[0] + "： " + (delayTimes.Sum() / n).ToString("0.00");
            lbAverServiceTime.Text = lbAverServiceTime.Text.Split('：')[0] + "： " + (serviceTimes.Sum() * serviceTimeFactor / n).ToString("0.00");
            lbAverWaitTime.Text = lbAverWaitTime.Text.Split('：')[0] + "： " + ((delayTimes.Sum() + serviceTimes.Sum()) / n).ToString("0.00");
            lbArrivalRate.Text = lbArrivalRate.Text.Split('：')[0] + "： " + (n / arrivalTimes[n - 1]).ToString("0.00");
            lbServiceRate.Text = lbServiceRate.Text.Split('：')[0] + "： " + (n / (serviceTimes.Sum() * serviceTimeFactor)).ToString("0.00");
            
            lbTimeAveragedJobsInNode.Text = lbTimeAveragedJobsInNode.Text.Split('：')[0] + "： " + (areaOfNode / t).ToString("0.00");
            lbTimeAveragedJobsInQueue.Text = lbTimeAveragedJobsInQueue.Text.Split('：')[0] + "： " + (areaOfQueue/ t).ToString("0.00");
            lbTimeAveragedJobsInServer.Text = lbTimeAveragedJobsInServer.Text.Split('：')[0] + "： " + (areaOfService / t).ToString("0.00");
            
            sw.Stop();
            lbMessage.Text = sw.Elapsed.TotalSeconds + " Sec    / " +((float)sw.Elapsed.TotalSeconds / 60.0).ToString("N2") +" min";
        }

        private void cbJobsInNode_CheckedChanged(object sender, EventArgs e)
        {
            if (cbJobsInNode.Checked)
                jobCountChart.Series["Jobs in Nodes l(t)"].Enabled = true;
            else
                jobCountChart.Series["Jobs in Nodes l(t)"].Enabled = false;
        }

        private void cbJobsInQueue_CheckedChanged(object sender, EventArgs e)
        {
            if (cbJobsInQueue.Checked)
                jobCountChart.Series["Jobs in Queue q(t)"].Enabled = true;
            else
                jobCountChart.Series["Jobs in Queue q(t)"].Enabled = false;
        }

        private void cbJobsInService_CheckedChanged(object sender, EventArgs e)
        {
            if (cbJobsInService.Checked)
                jobCountChart.Series["Jobs In Service x(t)"].Enabled = true;
            else
                jobCountChart.Series["Jobs In Service x(t)"].Enabled = false;
        }


        private void btnSimulate_Click(object sender, EventArgs e)
        {
            double lowerBound;
            double upperBound;
            int numberOfTest;

            try
            {
                lowerBound = Convert.ToDouble(tbFactorFrom.Text);
                upperBound = Convert.ToDouble(tbFactorTo.Text);
                numberOfTest = Convert.ToInt32(nudNumberOfTest.Value);
            }
            catch (Exception)
            {

                MessageBox.Show("lowerBound and upperBound should be number!", "Type error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            utilizationChart.Series["queueLength"].Points.Clear();

            int n = arrivalTimes.Length;
            double factor;
            for (int f = 0; f < numberOfTest; f++)
            {
                factor = lowerBound+((upperBound - lowerBound) / numberOfTest) * f;

                //arrival、completion index
                int i = 0;
                int j = 0;

                // count in node,queue,service
                int countInNode = 0;
                int countInQueue = 0;
                int countInService = 0;

                //total area in node,queue,service
                double areaOfNode = 0;
                double areaOfQueue = 0;
                double areaOfService = 0;

                //last event time
                double t = 0;
                completionTimes[j] = double.MaxValue;

                while (j < n)
                {
                    //arrival event
                    if (i < n && arrivalTimes[i] < completionTimes[j])
                    {
                        //calculate area 
                        areaOfNode += countInNode * (arrivalTimes[i] - t);
                        areaOfQueue += countInQueue * (arrivalTimes[i] - t);
                        areaOfService += countInService * (arrivalTimes[i] - t);

                        countInNode++;
                        //server is busy so going to queue 
                        if (countInService > 0)
                        {
                            countInQueue++;
                            delayTimes[i] = Math.Max(0, completionTimes[i - 1] - arrivalTimes[i]);
                            completionTimes[i] = arrivalTimes[i] + delayTimes[i] + serviceTimes[i] * factor;
                        }
                        else
                        {
                            countInService++; 
                            delayTimes[i] = 0;
                            completionTimes[i] = arrivalTimes[i] + serviceTimes[i] * factor;
                        }

                        t = arrivalTimes[i];
                        i++;
                    }
                    // completion event
                    else
                    {
                        areaOfNode += countInNode * (completionTimes[j] - t);
                        areaOfQueue += countInQueue * (completionTimes[j] - t);
                        areaOfService += countInService * (completionTimes[j] - t);

                        countInNode--;

                        if (countInQueue > 0)
                            countInQueue--;
                        else
                            countInService--;

                        t = completionTimes[j];
                        j++;
                    }
                }


                DataPoint point = new DataPoint(Math.Round(areaOfService / t,2), Math.Round(areaOfQueue / t,2));
                point.MarkerStyle = MarkerStyle.Star4;
                point.MarkerSize = 25;
                point.Label = factor.ToString("0.0");
                utilizationChart.Series["queueLength"].Points.Add(point);
                
            }
        }


        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (numberOfJobs == 0) return;
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                string path = dlgSave.FileName;
                using (StreamWriter outputFile = new StreamWriter(path))
                {
                    outputFile.WriteLine(Convert.ToString(numberOfJobs));
                    for (int i = 0; i < numberOfJobs; i++)
                    {
                        outputFile.WriteLine($"{arrivalTimes[i]} {serviceTimes[i]}");
                    }
                    outputFile.Close();
                    lbProblemName.Text = Path.GetFileName(dlgSave.FileName);
                    MessageBox.Show("save data sucessfully~", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvJobInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

   
}
