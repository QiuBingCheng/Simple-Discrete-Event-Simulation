
namespace SingleServerQueueMonitoring
{
    partial class MyForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openProblemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.lbProblemName = new System.Windows.Forms.Label();
            this.dgvJobInfo = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbArrivalDeviation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCreateData = new System.Windows.Forms.Button();
            this.nudNumberofJobs = new System.Windows.Forms.NumericUpDown();
            this.tbServiceDeviation = new System.Windows.Forms.TextBox();
            this.tbAverageServiceTime = new System.Windows.Forms.TextBox();
            this.tbAverageInterarrivalTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.lbServiceRate = new System.Windows.Forms.Label();
            this.lbArrivalRate = new System.Windows.Forms.Label();
            this.lbTimeAveragedJobsInServer = new System.Windows.Forms.Label();
            this.lbTimeAveragedJobsInQueue = new System.Windows.Forms.Label();
            this.lbTimeAveragedJobsInNode = new System.Windows.Forms.Label();
            this.lbAverWaitTime = new System.Windows.Forms.Label();
            this.lbAverDelayTime = new System.Windows.Forms.Label();
            this.lbAverServiceTime = new System.Windows.Forms.Label();
            this.lbAverInterarrivalTime = new System.Windows.Forms.Label();
            this.tbServiceTimeFactor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSimulateTheProcess = new System.Windows.Forms.Button();
            this.cbJobsInService = new System.Windows.Forms.CheckBox();
            this.cbJobsInQueue = new System.Windows.Forms.CheckBox();
            this.cbJobsInNode = new System.Windows.Forms.CheckBox();
            this.jobCountChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.nudNumberOfTest = new System.Windows.Forms.NumericUpDown();
            this.tbFactorTo = new System.Windows.Forms.TextBox();
            this.tbFactorFrom = new System.Windows.Forms.TextBox();
            this.btnSimulateVariousServiceTime = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.utilizationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobInfo)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberofJobs)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobCountChart)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizationChart)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openProblemToolStripMenuItem,
            this.btnSaveFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1382, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openProblemToolStripMenuItem
            // 
            this.openProblemToolStripMenuItem.Image = global::SingleServerQueueMonitoring.Properties.Resources.open_folder;
            this.openProblemToolStripMenuItem.Name = "openProblemToolStripMenuItem";
            this.openProblemToolStripMenuItem.Size = new System.Drawing.Size(154, 34);
            this.openProblemToolStripMenuItem.Text = "Open Problem";
            this.openProblemToolStripMenuItem.Click += new System.EventHandler(this.openProblemToolStripMenuItem_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Image = global::SingleServerQueueMonitoring.Properties.Resources.data_storage;
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(149, 34);
            this.btnSaveFile.Text = "Save Problem";
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Size = new System.Drawing.Size(1382, 653);
            this.splitContainer1.SplitterDistance = 517;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(517, 653);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(509, 617);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Current Problem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(4, 5);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.lbProblemName);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvJobInfo);
            this.splitContainer2.Size = new System.Drawing.Size(501, 607);
            this.splitContainer2.SplitterDistance = 76;
            this.splitContainer2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(501, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Arrival、Service、Delay、Completion Time";
            // 
            // lbProblemName
            // 
            this.lbProblemName.Location = new System.Drawing.Point(4, 17);
            this.lbProblemName.Name = "lbProblemName";
            this.lbProblemName.Size = new System.Drawing.Size(378, 23);
            this.lbProblemName.TabIndex = 3;
            this.lbProblemName.Text = "File Name：";
            // 
            // dgvJobInfo
            // 
            this.dgvJobInfo.AllowUserToAddRows = false;
            this.dgvJobInfo.AllowUserToDeleteRows = false;
            this.dgvJobInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvJobInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJobInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvJobInfo.Name = "dgvJobInfo";
            this.dgvJobInfo.ReadOnly = true;
            this.dgvJobInfo.RowHeadersWidth = 51;
            this.dgvJobInfo.RowTemplate.Height = 24;
            this.dgvJobInfo.Size = new System.Drawing.Size(501, 527);
            this.dgvJobInfo.TabIndex = 0;
            this.dgvJobInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJobInfo_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbArrivalDeviation);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnCreateData);
            this.tabPage2.Controls.Add(this.nudNumberofJobs);
            this.tabPage2.Controls.Add(this.tbServiceDeviation);
            this.tabPage2.Controls.Add(this.tbAverageServiceTime);
            this.tabPage2.Controls.Add(this.tbAverageInterarrivalTime);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(509, 624);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create New Problem";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbArrivalDeviation
            // 
            this.tbArrivalDeviation.Location = new System.Drawing.Point(322, 81);
            this.tbArrivalDeviation.Name = "tbArrivalDeviation";
            this.tbArrivalDeviation.Size = new System.Drawing.Size(65, 31);
            this.tbArrivalDeviation.TabIndex = 12;
            this.tbArrivalDeviation.Text = "4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Deviation";
            // 
            // btnCreateData
            // 
            this.btnCreateData.Location = new System.Drawing.Point(67, 251);
            this.btnCreateData.Name = "btnCreateData";
            this.btnCreateData.Size = new System.Drawing.Size(321, 45);
            this.btnCreateData.TabIndex = 10;
            this.btnCreateData.Text = "Create The Problem";
            this.btnCreateData.UseVisualStyleBackColor = true;
            this.btnCreateData.Click += new System.EventHandler(this.btnCreateData_Click);
            // 
            // nudNumberofJobs
            // 
            this.nudNumberofJobs.Location = new System.Drawing.Point(323, 205);
            this.nudNumberofJobs.Name = "nudNumberofJobs";
            this.nudNumberofJobs.Size = new System.Drawing.Size(65, 31);
            this.nudNumberofJobs.TabIndex = 9;
            this.nudNumberofJobs.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // tbServiceDeviation
            // 
            this.tbServiceDeviation.Location = new System.Drawing.Point(323, 164);
            this.tbServiceDeviation.Name = "tbServiceDeviation";
            this.tbServiceDeviation.Size = new System.Drawing.Size(65, 31);
            this.tbServiceDeviation.TabIndex = 8;
            this.tbServiceDeviation.Text = "2";
            // 
            // tbAverageServiceTime
            // 
            this.tbAverageServiceTime.Location = new System.Drawing.Point(323, 126);
            this.tbAverageServiceTime.Name = "tbAverageServiceTime";
            this.tbAverageServiceTime.Size = new System.Drawing.Size(65, 31);
            this.tbAverageServiceTime.TabIndex = 7;
            this.tbAverageServiceTime.Text = "6.2";
            // 
            // tbAverageInterarrivalTime
            // 
            this.tbAverageInterarrivalTime.Location = new System.Drawing.Point(323, 43);
            this.tbAverageInterarrivalTime.Name = "tbAverageInterarrivalTime";
            this.tbAverageInterarrivalTime.Size = new System.Drawing.Size(65, 31);
            this.tbAverageInterarrivalTime.TabIndex = 5;
            this.tbAverageInterarrivalTime.Text = "4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Number of Jobs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Deviation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Average Service Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 23);
            this.label4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Average Interarrival Time";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(859, 653);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer4);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(851, 617);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Simulate Job Processing";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.lbServiceRate);
            this.splitContainer4.Panel1.Controls.Add(this.lbArrivalRate);
            this.splitContainer4.Panel1.Controls.Add(this.lbTimeAveragedJobsInServer);
            this.splitContainer4.Panel1.Controls.Add(this.lbTimeAveragedJobsInQueue);
            this.splitContainer4.Panel1.Controls.Add(this.lbTimeAveragedJobsInNode);
            this.splitContainer4.Panel1.Controls.Add(this.lbAverWaitTime);
            this.splitContainer4.Panel1.Controls.Add(this.lbAverDelayTime);
            this.splitContainer4.Panel1.Controls.Add(this.lbAverServiceTime);
            this.splitContainer4.Panel1.Controls.Add(this.lbAverInterarrivalTime);
            this.splitContainer4.Panel1.Controls.Add(this.tbServiceTimeFactor);
            this.splitContainer4.Panel1.Controls.Add(this.label1);
            this.splitContainer4.Panel1.Controls.Add(this.btnSimulateTheProcess);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.cbJobsInService);
            this.splitContainer4.Panel2.Controls.Add(this.cbJobsInQueue);
            this.splitContainer4.Panel2.Controls.Add(this.cbJobsInNode);
            this.splitContainer4.Panel2.Controls.Add(this.jobCountChart);
            this.splitContainer4.Panel2.Controls.Add(this.splitter1);
            this.splitContainer4.Size = new System.Drawing.Size(845, 611);
            this.splitContainer4.SplitterDistance = 192;
            this.splitContainer4.TabIndex = 13;
            // 
            // lbServiceRate
            // 
            this.lbServiceRate.AutoSize = true;
            this.lbServiceRate.Location = new System.Drawing.Point(316, 97);
            this.lbServiceRate.Name = "lbServiceRate";
            this.lbServiceRate.Size = new System.Drawing.Size(122, 23);
            this.lbServiceRate.TabIndex = 26;
            this.lbServiceRate.Text = "Service Rate：";
            // 
            // lbArrivalRate
            // 
            this.lbArrivalRate.AutoSize = true;
            this.lbArrivalRate.Location = new System.Drawing.Point(315, 68);
            this.lbArrivalRate.Name = "lbArrivalRate";
            this.lbArrivalRate.Size = new System.Drawing.Size(151, 23);
            this.lbArrivalRate.TabIndex = 25;
            this.lbArrivalRate.Text = "Arrival Rate：";
            // 
            // lbTimeAveragedJobsInServer
            // 
            this.lbTimeAveragedJobsInServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimeAveragedJobsInServer.Location = new System.Drawing.Point(505, 127);
            this.lbTimeAveragedJobsInServer.Name = "lbTimeAveragedJobsInServer";
            this.lbTimeAveragedJobsInServer.Size = new System.Drawing.Size(324, 28);
            this.lbTimeAveragedJobsInServer.TabIndex = 22;
            this.lbTimeAveragedJobsInServer.Text = "Time-averaged Jobs in Service：";
            // 
            // lbTimeAveragedJobsInQueue
            // 
            this.lbTimeAveragedJobsInQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimeAveragedJobsInQueue.AutoSize = true;
            this.lbTimeAveragedJobsInQueue.Location = new System.Drawing.Point(505, 95);
            this.lbTimeAveragedJobsInQueue.Name = "lbTimeAveragedJobsInQueue";
            this.lbTimeAveragedJobsInQueue.Size = new System.Drawing.Size(316, 23);
            this.lbTimeAveragedJobsInQueue.TabIndex = 21;
            this.lbTimeAveragedJobsInQueue.Text = "Time-averaged Jobs in Queue：";
            // 
            // lbTimeAveragedJobsInNode
            // 
            this.lbTimeAveragedJobsInNode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimeAveragedJobsInNode.AutoSize = true;
            this.lbTimeAveragedJobsInNode.Location = new System.Drawing.Point(505, 64);
            this.lbTimeAveragedJobsInNode.Name = "lbTimeAveragedJobsInNode";
            this.lbTimeAveragedJobsInNode.Size = new System.Drawing.Size(305, 23);
            this.lbTimeAveragedJobsInNode.TabIndex = 20;
            this.lbTimeAveragedJobsInNode.Text = "Time-averaged Jobs in Node：";
            // 
            // lbAverWaitTime
            // 
            this.lbAverWaitTime.AutoSize = true;
            this.lbAverWaitTime.Location = new System.Drawing.Point(20, 155);
            this.lbAverWaitTime.Name = "lbAverWaitTime";
            this.lbAverWaitTime.Size = new System.Drawing.Size(206, 23);
            this.lbAverWaitTime.TabIndex = 19;
            this.lbAverWaitTime.Text = "Average Wait Time：";
            // 
            // lbAverDelayTime
            // 
            this.lbAverDelayTime.AutoSize = true;
            this.lbAverDelayTime.Location = new System.Drawing.Point(20, 127);
            this.lbAverDelayTime.Name = "lbAverDelayTime";
            this.lbAverDelayTime.Size = new System.Drawing.Size(217, 23);
            this.lbAverDelayTime.TabIndex = 18;
            this.lbAverDelayTime.Text = "Average Delay Time：";
            // 
            // lbAverServiceTime
            // 
            this.lbAverServiceTime.AutoSize = true;
            this.lbAverServiceTime.Location = new System.Drawing.Point(20, 98);
            this.lbAverServiceTime.Name = "lbAverServiceTime";
            this.lbAverServiceTime.Size = new System.Drawing.Size(239, 23);
            this.lbAverServiceTime.TabIndex = 17;
            this.lbAverServiceTime.Text = "Average Service Time：";
            // 
            // lbAverInterarrivalTime
            // 
            this.lbAverInterarrivalTime.AutoSize = true;
            this.lbAverInterarrivalTime.Location = new System.Drawing.Point(20, 68);
            this.lbAverInterarrivalTime.Name = "lbAverInterarrivalTime";
            this.lbAverInterarrivalTime.Size = new System.Drawing.Size(294, 23);
            this.lbAverInterarrivalTime.TabIndex = 16;
            this.lbAverInterarrivalTime.Text = "Average Interarrival Time：";
            // 
            // tbServiceTimeFactor
            // 
            this.tbServiceTimeFactor.Location = new System.Drawing.Point(472, 19);
            this.tbServiceTimeFactor.Name = "tbServiceTimeFactor";
            this.tbServiceTimeFactor.Size = new System.Drawing.Size(42, 31);
            this.tbServiceTimeFactor.TabIndex = 15;
            this.tbServiceTimeFactor.Text = "1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Service Time Factor";
            // 
            // btnSimulateTheProcess
            // 
            this.btnSimulateTheProcess.Enabled = false;
            this.btnSimulateTheProcess.Location = new System.Drawing.Point(20, 19);
            this.btnSimulateTheProcess.Name = "btnSimulateTheProcess";
            this.btnSimulateTheProcess.Size = new System.Drawing.Size(211, 35);
            this.btnSimulateTheProcess.TabIndex = 13;
            this.btnSimulateTheProcess.Text = "Simulate the Process";
            this.btnSimulateTheProcess.UseVisualStyleBackColor = true;
            this.btnSimulateTheProcess.Click += new System.EventHandler(this.btnSimulateTheProcess_Click);
            // 
            // cbJobsInService
            // 
            this.cbJobsInService.AutoSize = true;
            this.cbJobsInService.Checked = true;
            this.cbJobsInService.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbJobsInService.Location = new System.Drawing.Point(367, 4);
            this.cbJobsInService.Name = "cbJobsInService";
            this.cbJobsInService.Size = new System.Drawing.Size(197, 27);
            this.cbJobsInService.TabIndex = 6;
            this.cbJobsInService.Text = "Jobs in Service";
            this.cbJobsInService.UseVisualStyleBackColor = true;
            this.cbJobsInService.CheckedChanged += new System.EventHandler(this.cbJobsInService_CheckedChanged);
            // 
            // cbJobsInQueue
            // 
            this.cbJobsInQueue.AutoSize = true;
            this.cbJobsInQueue.Checked = true;
            this.cbJobsInQueue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbJobsInQueue.Location = new System.Drawing.Point(214, 4);
            this.cbJobsInQueue.Name = "cbJobsInQueue";
            this.cbJobsInQueue.Size = new System.Drawing.Size(175, 27);
            this.cbJobsInQueue.TabIndex = 5;
            this.cbJobsInQueue.Text = "Jobs in Queue";
            this.cbJobsInQueue.UseVisualStyleBackColor = true;
            this.cbJobsInQueue.CheckedChanged += new System.EventHandler(this.cbJobsInQueue_CheckedChanged);
            // 
            // cbJobsInNode
            // 
            this.cbJobsInNode.AutoSize = true;
            this.cbJobsInNode.Checked = true;
            this.cbJobsInNode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbJobsInNode.Location = new System.Drawing.Point(72, 4);
            this.cbJobsInNode.Name = "cbJobsInNode";
            this.cbJobsInNode.Size = new System.Drawing.Size(164, 27);
            this.cbJobsInNode.TabIndex = 4;
            this.cbJobsInNode.Text = "Jobs in Node";
            this.cbJobsInNode.UseVisualStyleBackColor = true;
            this.cbJobsInNode.CheckedChanged += new System.EventHandler(this.cbJobsInNode_CheckedChanged);
            // 
            // jobCountChart
            // 
            chartArea5.AxisX.Title = "Time";
            chartArea5.AxisX.TitleFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.AxisY.Title = "Count";
            chartArea5.AxisY.TitleFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.CursorX.IsUserEnabled = true;
            chartArea5.CursorX.IsUserSelectionEnabled = true;
            chartArea5.CursorY.IsUserEnabled = true;
            chartArea5.CursorY.IsUserSelectionEnabled = true;
            chartArea5.Name = "ChartArea1";
            this.jobCountChart.ChartAreas.Add(chartArea5);
            this.jobCountChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Alignment = System.Drawing.StringAlignment.Center;
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend5.Name = "Legend1";
            this.jobCountChart.Legends.Add(legend5);
            this.jobCountChart.Location = new System.Drawing.Point(0, 36);
            this.jobCountChart.Name = "jobCountChart";
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series9.Color = System.Drawing.Color.Red;
            series9.Legend = "Legend1";
            series9.Name = "Jobs in Nodes l(t)";
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series10.Legend = "Legend1";
            series10.Name = "Jobs in Queue q(t)";
            series11.BorderWidth = 3;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series11.Color = System.Drawing.Color.Blue;
            series11.Legend = "Legend1";
            series11.Name = "Jobs In Service x(t)";
            this.jobCountChart.Series.Add(series9);
            this.jobCountChart.Series.Add(series10);
            this.jobCountChart.Series.Add(series11);
            this.jobCountChart.Size = new System.Drawing.Size(845, 379);
            this.jobCountChart.TabIndex = 3;
            this.jobCountChart.Text = "chart1";
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(845, 36);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer3);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(851, 624);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Service Rate Simulation";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.nudNumberOfTest);
            this.splitContainer3.Panel1.Controls.Add(this.tbFactorTo);
            this.splitContainer3.Panel1.Controls.Add(this.tbFactorFrom);
            this.splitContainer3.Panel1.Controls.Add(this.btnSimulateVariousServiceTime);
            this.splitContainer3.Panel1.Controls.Add(this.label18);
            this.splitContainer3.Panel1.Controls.Add(this.label17);
            this.splitContainer3.Panel1.Controls.Add(this.label16);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.utilizationChart);
            this.splitContainer3.Size = new System.Drawing.Size(845, 618);
            this.splitContainer3.SplitterDistance = 107;
            this.splitContainer3.TabIndex = 1;
            // 
            // nudNumberOfTest
            // 
            this.nudNumberOfTest.Location = new System.Drawing.Point(389, 64);
            this.nudNumberOfTest.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudNumberOfTest.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudNumberOfTest.Name = "nudNumberOfTest";
            this.nudNumberOfTest.Size = new System.Drawing.Size(67, 31);
            this.nudNumberOfTest.TabIndex = 6;
            this.nudNumberOfTest.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tbFactorTo
            // 
            this.tbFactorTo.Location = new System.Drawing.Point(568, 19);
            this.tbFactorTo.Name = "tbFactorTo";
            this.tbFactorTo.Size = new System.Drawing.Size(58, 31);
            this.tbFactorTo.TabIndex = 5;
            this.tbFactorTo.Text = "2";
            // 
            // tbFactorFrom
            // 
            this.tbFactorFrom.Location = new System.Drawing.Point(451, 19);
            this.tbFactorFrom.Name = "tbFactorFrom";
            this.tbFactorFrom.Size = new System.Drawing.Size(58, 31);
            this.tbFactorFrom.TabIndex = 4;
            this.tbFactorFrom.Text = "0.5";
            // 
            // btnSimulateVariousServiceTime
            // 
            this.btnSimulateVariousServiceTime.Enabled = false;
            this.btnSimulateVariousServiceTime.Location = new System.Drawing.Point(35, 25);
            this.btnSimulateVariousServiceTime.Name = "btnSimulateVariousServiceTime";
            this.btnSimulateVariousServiceTime.Size = new System.Drawing.Size(147, 42);
            this.btnSimulateVariousServiceTime.TabIndex = 3;
            this.btnSimulateVariousServiceTime.Text = "Simulate";
            this.btnSimulateVariousServiceTime.UseVisualStyleBackColor = true;
            this.btnSimulateVariousServiceTime.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(208, 68);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(175, 23);
            this.label18.TabIndex = 2;
            this.label18.Text = "Number of Tests";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(526, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 23);
            this.label17.TabIndex = 1;
            this.label17.Text = "To";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(205, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(274, 23);
            this.label16.TabIndex = 0;
            this.label16.Text = "Service Time Factor From";
            // 
            // utilizationChart
            // 
            chartArea6.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea6.AxisX.Title = "Time-averaged jobs in Service (Utilization, x-bar)";
            chartArea6.AxisX.TitleFont = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisY.Title = "Time-averaged Queue Length (q-bar)";
            chartArea6.AxisY.TitleFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.Name = "ChartArea1";
            this.utilizationChart.ChartAreas.Add(chartArea6);
            this.utilizationChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.utilizationChart.Legends.Add(legend6);
            this.utilizationChart.Location = new System.Drawing.Point(0, 0);
            this.utilizationChart.Name = "utilizationChart";
            series12.BorderWidth = 3;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Color = System.Drawing.Color.Red;
            series12.EmptyPointStyle.IsValueShownAsLabel = true;
            series12.Legend = "Legend1";
            series12.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star4;
            series12.Name = "queueLength";
            this.utilizationChart.Series.Add(series12);
            this.utilizationChart.Size = new System.Drawing.Size(845, 507);
            this.utilizationChart.TabIndex = 1;
            this.utilizationChart.Text = "chart2";
            title3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Queue-Utilization of Different Service Rates";
            this.utilizationChart.Titles.Add(title3);
            // 
            // dlgOpen
            // 
            this.dlgOpen.DefaultExt = "dat";
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // dlgSave
            // 
            this.dlgSave.DefaultExt = "dat";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 671);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1382, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbMessage
            // 
            this.lbMessage.ForeColor = System.Drawing.Color.Maroon;
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(1367, 16);
            this.lbMessage.Spring = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Jobs";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Arrival";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 95;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Service";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 95;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Delay";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Completion";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 693);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1400, 740);
            this.MinimumSize = new System.Drawing.Size(1400, 740);
            this.Name = "MyForm";
            this.Text = "Single Server Queue Monitoring";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobInfo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberofJobs)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jobCountChart)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizationChart)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openProblemToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCreateData;
        private System.Windows.Forms.NumericUpDown nudNumberofJobs;
        private System.Windows.Forms.TextBox tbServiceDeviation;
        private System.Windows.Forms.TextBox tbAverageServiceTime;
        private System.Windows.Forms.TextBox tbAverageInterarrivalTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbProblemName;
        private System.Windows.Forms.DataGridView dgvJobInfo;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataVisualization.Charting.Chart utilizationChart;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSimulateVariousServiceTime;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label lbTimeAveragedJobsInServer;
        private System.Windows.Forms.Label lbTimeAveragedJobsInQueue;
        private System.Windows.Forms.Label lbTimeAveragedJobsInNode;
        private System.Windows.Forms.Label lbAverWaitTime;
        private System.Windows.Forms.Label lbAverDelayTime;
        private System.Windows.Forms.Label lbAverServiceTime;
        private System.Windows.Forms.Label lbAverInterarrivalTime;
        private System.Windows.Forms.TextBox tbServiceTimeFactor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSimulateTheProcess;
        private System.Windows.Forms.TextBox tbFactorTo;
        private System.Windows.Forms.TextBox tbFactorFrom;
        private System.Windows.Forms.CheckBox cbJobsInService;
        private System.Windows.Forms.CheckBox cbJobsInQueue;
        private System.Windows.Forms.CheckBox cbJobsInNode;
        private System.Windows.Forms.DataVisualization.Charting.Chart jobCountChart;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbMessage;
        private System.Windows.Forms.Label lbServiceRate;
        private System.Windows.Forms.Label lbArrivalRate;
        private System.Windows.Forms.TextBox tbArrivalDeviation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem btnSaveFile;
        private System.Windows.Forms.NumericUpDown nudNumberOfTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

