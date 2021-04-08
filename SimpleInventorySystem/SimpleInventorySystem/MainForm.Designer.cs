
namespace SimpleInventorySystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openProblemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lbItemCost = new System.Windows.Forms.Label();
            this.lbShortageCost = new System.Windows.Forms.Label();
            this.lbHoldingCost = new System.Windows.Forms.Label();
            this.lbSetupCost = new System.Windows.Forms.Label();
            this.lbProblemName = new System.Windows.Forms.Label();
            this.tbInventoryInfo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbDemandVariance = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nudMinimumInventory = new System.Windows.Forms.NumericUpDown();
            this.nudMaximumInventoryLevel = new System.Windows.Forms.NumericUpDown();
            this.nudNumberOfIntervals = new System.Windows.Forms.NumericUpDown();
            this.tbShortageCost = new System.Windows.Forms.TextBox();
            this.tbHoldingCost = new System.Windows.Forms.TextBox();
            this.tbOrderSetupCost = new System.Windows.Forms.TextBox();
            this.tbItemCost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateData = new System.Windows.Forms.Button();
            this.nudAverageDemand = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.lbAverageOrder2 = new System.Windows.Forms.Label();
            this.lbTimeAveragedShortageLevel = new System.Windows.Forms.Label();
            this.lbTimeAveragedHoldingLevel = new System.Windows.Forms.Label();
            this.lbAverOrder = new System.Windows.Forms.Label();
            this.lbAverDemand = new System.Windows.Forms.Label();
            this.btnSimulateTheInventory = new System.Windows.Forms.Button();
            this.inventoryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.lbMinumumCostSpent = new System.Windows.Forms.Label();
            this.lbBestMinumLevel = new System.Windows.Forms.Label();
            this.btnFidnOptimum = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.OptimizationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbMessage = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimumInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumInventoryLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfIntervals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAverageDemand)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryChart)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OptimizationChart)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1207, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openProblemToolStripMenuItem
            // 
            this.openProblemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openProblemToolStripMenuItem.Image")));
            this.openProblemToolStripMenuItem.Name = "openProblemToolStripMenuItem";
            this.openProblemToolStripMenuItem.Size = new System.Drawing.Size(132, 34);
            this.openProblemToolStripMenuItem.Text = "Open Problem";
            this.openProblemToolStripMenuItem.Click += new System.EventHandler(this.openProblemToolStripMenuItem_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveFile.Image")));
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(127, 34);
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
            this.splitContainer1.Size = new System.Drawing.Size(1207, 604);
            this.splitContainer1.SplitterDistance = 359;
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
            this.tabControl1.Size = new System.Drawing.Size(359, 604);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(351, 572);
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
            this.splitContainer2.Panel1.Controls.Add(this.lbItemCost);
            this.splitContainer2.Panel1.Controls.Add(this.lbShortageCost);
            this.splitContainer2.Panel1.Controls.Add(this.lbHoldingCost);
            this.splitContainer2.Panel1.Controls.Add(this.lbSetupCost);
            this.splitContainer2.Panel1.Controls.Add(this.lbProblemName);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tbInventoryInfo);
            this.splitContainer2.Size = new System.Drawing.Size(343, 562);
            this.splitContainer2.SplitterDistance = 167;
            this.splitContainer2.TabIndex = 3;
            // 
            // lbItemCost
            // 
            this.lbItemCost.AutoSize = true;
            this.lbItemCost.Location = new System.Drawing.Point(3, 48);
            this.lbItemCost.Name = "lbItemCost";
            this.lbItemCost.Size = new System.Drawing.Size(108, 19);
            this.lbItemCost.TabIndex = 7;
            this.lbItemCost.Text = "Item Cost：";
            // 
            // lbShortageCost
            // 
            this.lbShortageCost.AutoSize = true;
            this.lbShortageCost.Location = new System.Drawing.Point(4, 136);
            this.lbShortageCost.Name = "lbShortageCost";
            this.lbShortageCost.Size = new System.Drawing.Size(144, 19);
            this.lbShortageCost.TabIndex = 6;
            this.lbShortageCost.Text = "Shortage Cost：";
            // 
            // lbHoldingCost
            // 
            this.lbHoldingCost.AutoSize = true;
            this.lbHoldingCost.Location = new System.Drawing.Point(4, 104);
            this.lbHoldingCost.Name = "lbHoldingCost";
            this.lbHoldingCost.Size = new System.Drawing.Size(135, 19);
            this.lbHoldingCost.TabIndex = 5;
            this.lbHoldingCost.Text = "Holding Cost：";
            // 
            // lbSetupCost
            // 
            this.lbSetupCost.AutoSize = true;
            this.lbSetupCost.Location = new System.Drawing.Point(4, 75);
            this.lbSetupCost.Name = "lbSetupCost";
            this.lbSetupCost.Size = new System.Drawing.Size(117, 19);
            this.lbSetupCost.TabIndex = 4;
            this.lbSetupCost.Text = "Setup Cost：";
            // 
            // lbProblemName
            // 
            this.lbProblemName.AutoSize = true;
            this.lbProblemName.Location = new System.Drawing.Point(4, 17);
            this.lbProblemName.Name = "lbProblemName";
            this.lbProblemName.Size = new System.Drawing.Size(108, 19);
            this.lbProblemName.TabIndex = 3;
            this.lbProblemName.Text = "File Name：";
            // 
            // tbInventoryInfo
            // 
            this.tbInventoryInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbInventoryInfo.Location = new System.Drawing.Point(0, 0);
            this.tbInventoryInfo.Multiline = true;
            this.tbInventoryInfo.Name = "tbInventoryInfo";
            this.tbInventoryInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbInventoryInfo.Size = new System.Drawing.Size(343, 391);
            this.tbInventoryInfo.TabIndex = 0;
            this.tbInventoryInfo.WordWrap = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbDemandVariance);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.nudMinimumInventory);
            this.tabPage2.Controls.Add(this.nudMaximumInventoryLevel);
            this.tabPage2.Controls.Add(this.nudNumberOfIntervals);
            this.tabPage2.Controls.Add(this.tbShortageCost);
            this.tabPage2.Controls.Add(this.tbHoldingCost);
            this.tabPage2.Controls.Add(this.tbOrderSetupCost);
            this.tabPage2.Controls.Add(this.tbItemCost);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnCreateData);
            this.tabPage2.Controls.Add(this.nudAverageDemand);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(351, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create New Problem";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbDemandVariance
            // 
            this.tbDemandVariance.Location = new System.Drawing.Point(243, 186);
            this.tbDemandVariance.Name = "tbDemandVariance";
            this.tbDemandVariance.Size = new System.Drawing.Size(65, 26);
            this.tbDemandVariance.TabIndex = 23;
            this.tbDemandVariance.Text = "12";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "Demand Variance";
            // 
            // nudMinimumInventory
            // 
            this.nudMinimumInventory.Location = new System.Drawing.Point(243, 30);
            this.nudMinimumInventory.Name = "nudMinimumInventory";
            this.nudMinimumInventory.Size = new System.Drawing.Size(65, 26);
            this.nudMinimumInventory.TabIndex = 21;
            this.nudMinimumInventory.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nudMaximumInventoryLevel
            // 
            this.nudMaximumInventoryLevel.Location = new System.Drawing.Point(243, 72);
            this.nudMaximumInventoryLevel.Name = "nudMaximumInventoryLevel";
            this.nudMaximumInventoryLevel.Size = new System.Drawing.Size(65, 26);
            this.nudMaximumInventoryLevel.TabIndex = 20;
            this.nudMaximumInventoryLevel.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // nudNumberOfIntervals
            // 
            this.nudNumberOfIntervals.Location = new System.Drawing.Point(243, 113);
            this.nudNumberOfIntervals.Name = "nudNumberOfIntervals";
            this.nudNumberOfIntervals.Size = new System.Drawing.Size(65, 26);
            this.nudNumberOfIntervals.TabIndex = 19;
            this.nudNumberOfIntervals.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // tbShortageCost
            // 
            this.tbShortageCost.Location = new System.Drawing.Point(243, 362);
            this.tbShortageCost.Name = "tbShortageCost";
            this.tbShortageCost.Size = new System.Drawing.Size(65, 26);
            this.tbShortageCost.TabIndex = 18;
            this.tbShortageCost.Text = "700";
            // 
            // tbHoldingCost
            // 
            this.tbHoldingCost.Location = new System.Drawing.Point(243, 324);
            this.tbHoldingCost.Name = "tbHoldingCost";
            this.tbHoldingCost.Size = new System.Drawing.Size(65, 26);
            this.tbHoldingCost.TabIndex = 17;
            this.tbHoldingCost.Text = "25";
            // 
            // tbOrderSetupCost
            // 
            this.tbOrderSetupCost.Location = new System.Drawing.Point(243, 285);
            this.tbOrderSetupCost.Name = "tbOrderSetupCost";
            this.tbOrderSetupCost.Size = new System.Drawing.Size(65, 26);
            this.tbOrderSetupCost.TabIndex = 16;
            this.tbOrderSetupCost.Text = "1000";
            // 
            // tbItemCost
            // 
            this.tbItemCost.Location = new System.Drawing.Point(243, 249);
            this.tbItemCost.Name = "tbItemCost";
            this.tbItemCost.Size = new System.Drawing.Size(65, 26);
            this.tbItemCost.TabIndex = 15;
            this.tbItemCost.Text = "8000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Shortage Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Holding Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Order Setup Cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Item Cost";
            // 
            // btnCreateData
            // 
            this.btnCreateData.Location = new System.Drawing.Point(14, 406);
            this.btnCreateData.Name = "btnCreateData";
            this.btnCreateData.Size = new System.Drawing.Size(300, 40);
            this.btnCreateData.TabIndex = 10;
            this.btnCreateData.Text = "Create Data";
            this.btnCreateData.UseVisualStyleBackColor = true;
            this.btnCreateData.Click += new System.EventHandler(this.btnCreateData_Click);
            // 
            // nudAverageDemand
            // 
            this.nudAverageDemand.Location = new System.Drawing.Point(243, 152);
            this.nudAverageDemand.Name = "nudAverageDemand";
            this.nudAverageDemand.Size = new System.Drawing.Size(65, 26);
            this.nudAverageDemand.TabIndex = 9;
            this.nudAverageDemand.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Average Demand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Number of Intervals";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Maximum Inventory Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Minimum Inventory Level";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(842, 604);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer4);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(834, 572);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Inventory Levels";
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
            this.splitContainer4.Panel1.Controls.Add(this.lbAverageOrder2);
            this.splitContainer4.Panel1.Controls.Add(this.lbTimeAveragedShortageLevel);
            this.splitContainer4.Panel1.Controls.Add(this.lbTimeAveragedHoldingLevel);
            this.splitContainer4.Panel1.Controls.Add(this.lbAverOrder);
            this.splitContainer4.Panel1.Controls.Add(this.lbAverDemand);
            this.splitContainer4.Panel1.Controls.Add(this.btnSimulateTheInventory);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.inventoryChart);
            this.splitContainer4.Size = new System.Drawing.Size(828, 566);
            this.splitContainer4.SplitterDistance = 117;
            this.splitContainer4.TabIndex = 13;
            // 
            // lbAverageOrder2
            // 
            this.lbAverageOrder2.Location = new System.Drawing.Point(458, 86);
            this.lbAverageOrder2.Name = "lbAverageOrder2";
            this.lbAverageOrder2.Size = new System.Drawing.Size(324, 22);
            this.lbAverageOrder2.TabIndex = 22;
            this.lbAverageOrder2.Text = "Average Order：";
            // 
            // lbTimeAveragedShortageLevel
            // 
            this.lbTimeAveragedShortageLevel.AutoSize = true;
            this.lbTimeAveragedShortageLevel.Location = new System.Drawing.Point(458, 54);
            this.lbTimeAveragedShortageLevel.Name = "lbTimeAveragedShortageLevel";
            this.lbTimeAveragedShortageLevel.Size = new System.Drawing.Size(279, 19);
            this.lbTimeAveragedShortageLevel.TabIndex = 21;
            this.lbTimeAveragedShortageLevel.Text = "Time-averaged Shortage Level：";
            // 
            // lbTimeAveragedHoldingLevel
            // 
            this.lbTimeAveragedHoldingLevel.AutoSize = true;
            this.lbTimeAveragedHoldingLevel.Location = new System.Drawing.Point(458, 23);
            this.lbTimeAveragedHoldingLevel.Name = "lbTimeAveragedHoldingLevel";
            this.lbTimeAveragedHoldingLevel.Size = new System.Drawing.Size(270, 19);
            this.lbTimeAveragedHoldingLevel.TabIndex = 20;
            this.lbTimeAveragedHoldingLevel.Text = "Time-averaged Holding Level：";
            // 
            // lbAverOrder
            // 
            this.lbAverOrder.AutoSize = true;
            this.lbAverOrder.Location = new System.Drawing.Point(248, 54);
            this.lbAverOrder.Name = "lbAverOrder";
            this.lbAverOrder.Size = new System.Drawing.Size(144, 19);
            this.lbAverOrder.TabIndex = 17;
            this.lbAverOrder.Text = "Average Order：";
            // 
            // lbAverDemand
            // 
            this.lbAverDemand.AutoSize = true;
            this.lbAverDemand.Location = new System.Drawing.Point(248, 24);
            this.lbAverDemand.Name = "lbAverDemand";
            this.lbAverDemand.Size = new System.Drawing.Size(153, 19);
            this.lbAverDemand.TabIndex = 16;
            this.lbAverDemand.Text = "Average Demand：";
            // 
            // btnSimulateTheInventory
            // 
            this.btnSimulateTheInventory.Enabled = false;
            this.btnSimulateTheInventory.Location = new System.Drawing.Point(15, 19);
            this.btnSimulateTheInventory.Name = "btnSimulateTheInventory";
            this.btnSimulateTheInventory.Size = new System.Drawing.Size(211, 35);
            this.btnSimulateTheInventory.TabIndex = 13;
            this.btnSimulateTheInventory.Text = "Simulate Inventory Changes";
            this.btnSimulateTheInventory.UseVisualStyleBackColor = true;
            this.btnSimulateTheInventory.Click += new System.EventHandler(this.btnSimulateTheProcess_Click);
            // 
            // inventoryChart
            // 
            chartArea1.AxisX.Title = "Period";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Title = "Inventory Level";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.inventoryChart.ChartAreas.Add(chartArea1);
            this.inventoryChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.inventoryChart.Legends.Add(legend1);
            this.inventoryChart.Location = new System.Drawing.Point(0, 0);
            this.inventoryChart.Name = "inventoryChart";
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Minimum Level";
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Maximun Level";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.MarkerSize = 20;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series3.Name = "Inventory Level";
            this.inventoryChart.Series.Add(series1);
            this.inventoryChart.Series.Add(series2);
            this.inventoryChart.Series.Add(series3);
            this.inventoryChart.Size = new System.Drawing.Size(828, 445);
            this.inventoryChart.TabIndex = 3;
            this.inventoryChart.Text = "chart1";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(834, 578);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Optimization Application";
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
            this.splitContainer3.Panel1.Controls.Add(this.lbMinumumCostSpent);
            this.splitContainer3.Panel1.Controls.Add(this.lbBestMinumLevel);
            this.splitContainer3.Panel1.Controls.Add(this.btnFidnOptimum);
            this.splitContainer3.Panel1.Controls.Add(this.label18);
            this.splitContainer3.Panel1.Controls.Add(this.label16);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.OptimizationChart);
            this.splitContainer3.Size = new System.Drawing.Size(828, 572);
            this.splitContainer3.SplitterDistance = 98;
            this.splitContainer3.TabIndex = 1;
            // 
            // lbMinumumCostSpent
            // 
            this.lbMinumumCostSpent.AutoSize = true;
            this.lbMinumumCostSpent.Location = new System.Drawing.Point(412, 67);
            this.lbMinumumCostSpent.Name = "lbMinumumCostSpent";
            this.lbMinumumCostSpent.Size = new System.Drawing.Size(189, 19);
            this.lbMinumumCostSpent.TabIndex = 5;
            this.lbMinumumCostSpent.Text = "Minimum Cost Spent：";
            // 
            // lbBestMinumLevel
            // 
            this.lbBestMinumLevel.AutoSize = true;
            this.lbBestMinumLevel.Location = new System.Drawing.Point(411, 43);
            this.lbBestMinumLevel.Name = "lbBestMinumLevel";
            this.lbBestMinumLevel.Size = new System.Drawing.Size(144, 19);
            this.lbBestMinumLevel.TabIndex = 4;
            this.lbBestMinumLevel.Text = "Minimum Level：";
            // 
            // btnFidnOptimum
            // 
            this.btnFidnOptimum.Enabled = false;
            this.btnFidnOptimum.Location = new System.Drawing.Point(24, 13);
            this.btnFidnOptimum.Name = "btnFidnOptimum";
            this.btnFidnOptimum.Size = new System.Drawing.Size(147, 49);
            this.btnFidnOptimum.TabIndex = 3;
            this.btnFidnOptimum.Text = "Find Optimum";
            this.btnFidnOptimum.UseVisualStyleBackColor = true;
            this.btnFidnOptimum.Click += new System.EventHandler(this.btnFindOptimum_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(202, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(189, 19);
            this.label18.TabIndex = 2;
            this.label18.Text = "Optimization Results";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(202, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(576, 19);
            this.label16.TabIndex = 0;
            this.label16.Text = "Optimization Simulation for Minimal Level 0 to Maximal level -1";
            // 
            // OptimizationChart
            // 
            chartArea2.AxisX.Title = "Minimum Level(s)";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.Title = "Cost";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.Name = "ChartArea1";
            this.OptimizationChart.ChartAreas.Add(chartArea2);
            this.OptimizationChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.OptimizationChart.Legends.Add(legend2);
            this.OptimizationChart.Location = new System.Drawing.Point(0, 0);
            this.OptimizationChart.Name = "OptimizationChart";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.MarkerSize = 1;
            series4.Name = "Shortage Spent";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series5.Legend = "Legend1";
            series5.Name = "Holding Spent";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series6.Legend = "Legend1";
            series6.Name = "Setup Spent";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.OptimizationChart.Series.Add(series4);
            this.OptimizationChart.Series.Add(series5);
            this.OptimizationChart.Series.Add(series6);
            this.OptimizationChart.Size = new System.Drawing.Size(828, 470);
            this.OptimizationChart.TabIndex = 1;
            this.OptimizationChart.Text = "chart2";
            title1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Dependent Cost";
            this.OptimizationChart.Titles.Add(title1);
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
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 622);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1207, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbMessage
            // 
            this.lbMessage.ForeColor = System.Drawing.Color.Maroon;
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(1192, 17);
            this.lbMessage.Spring = true;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 644);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MyForm";
            this.Text = "Simple Inventory System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimumInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumInventoryLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfIntervals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAverageDemand)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryChart)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OptimizationChart)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nudAverageDemand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label lbProblemName;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataVisualization.Charting.Chart OptimizationChart;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnFidnOptimum;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label lbAverageOrder2;
        private System.Windows.Forms.Label lbTimeAveragedShortageLevel;
        private System.Windows.Forms.Label lbTimeAveragedHoldingLevel;
        private System.Windows.Forms.Label lbAverOrder;
        private System.Windows.Forms.Label lbAverDemand;
        private System.Windows.Forms.Button btnSimulateTheInventory;
        private System.Windows.Forms.DataVisualization.Charting.Chart inventoryChart;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbMessage;
        private System.Windows.Forms.TextBox tbInventoryInfo;
        private System.Windows.Forms.TextBox tbShortageCost;
        private System.Windows.Forms.TextBox tbHoldingCost;
        private System.Windows.Forms.TextBox tbOrderSetupCost;
        private System.Windows.Forms.TextBox tbItemCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMinimumInventory;
        private System.Windows.Forms.NumericUpDown nudMaximumInventoryLevel;
        private System.Windows.Forms.NumericUpDown nudNumberOfIntervals;
        private System.Windows.Forms.TextBox tbDemandVariance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbMinumumCostSpent;
        private System.Windows.Forms.Label lbBestMinumLevel;
        private System.Windows.Forms.Label lbShortageCost;
        private System.Windows.Forms.Label lbHoldingCost;
        private System.Windows.Forms.Label lbSetupCost;
        private System.Windows.Forms.Label lbItemCost;
        private System.Windows.Forms.ToolStripMenuItem btnSaveFile;
    }
}

