
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openProblemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbDemandVariance = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nudMinimumInventory = new System.Windows.Forms.NumericUpDown();
            this.nudMaximumInventory = new System.Windows.Forms.NumericUpDown();
            this.nudNumberOfIntervals = new System.Windows.Forms.NumericUpDown();
            this.tbShortageCost = new System.Windows.Forms.TextBox();
            this.tbHoldingCost = new System.Windows.Forms.TextBox();
            this.tbOrderSetupCost = new System.Windows.Forms.TextBox();
            this.tbItemCost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudAverageDemand = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbDemandVariance2 = new System.Windows.Forms.TextBox();
            this.nudAverageDemand2 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGenerateDemand = new System.Windows.Forms.Button();
            this.tbDemandData = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
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
            this.lbSettingsName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nudNumberOfIntervals2 = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimumInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfIntervals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAverageDemand)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAverageDemand2)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfIntervals2)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1182, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openProblemToolStripMenuItem
            // 
            this.openProblemToolStripMenuItem.Image = global::SimpleInventorySystem.Properties.Resources.open_folder;
            this.openProblemToolStripMenuItem.Name = "openProblemToolStripMenuItem";
            this.openProblemToolStripMenuItem.Size = new System.Drawing.Size(152, 34);
            this.openProblemToolStripMenuItem.Text = "Open Settings";
            this.openProblemToolStripMenuItem.Click += new System.EventHandler(this.openProblemToolStripMenuItem_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Image = global::SimpleInventorySystem.Properties.Resources.data_storage;
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(147, 34);
            this.btnSaveFile.Text = "Save Settings";
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
            this.splitContainer1.Size = new System.Drawing.Size(1182, 613);
            this.splitContainer1.SplitterDistance = 346;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(346, 613);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbSettingsName);
            this.tabPage2.Controls.Add(this.tbDemandVariance);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.nudMinimumInventory);
            this.tabPage2.Controls.Add(this.nudMaximumInventory);
            this.tabPage2.Controls.Add(this.nudNumberOfIntervals);
            this.tabPage2.Controls.Add(this.tbShortageCost);
            this.tabPage2.Controls.Add(this.tbHoldingCost);
            this.tabPage2.Controls.Add(this.tbOrderSetupCost);
            this.tabPage2.Controls.Add(this.tbItemCost);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.nudAverageDemand);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(338, 577);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Problem Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbDemandVariance
            // 
            this.tbDemandVariance.Location = new System.Drawing.Point(243, 219);
            this.tbDemandVariance.Name = "tbDemandVariance";
            this.tbDemandVariance.Size = new System.Drawing.Size(65, 31);
            this.tbDemandVariance.TabIndex = 23;
            this.tbDemandVariance.Text = "0";
            this.tbDemandVariance.TextChanged += new System.EventHandler(this.tbDemandVariance_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = "Demand Variance";
            // 
            // nudMinimumInventory
            // 
            this.nudMinimumInventory.Location = new System.Drawing.Point(243, 63);
            this.nudMinimumInventory.Name = "nudMinimumInventory";
            this.nudMinimumInventory.Size = new System.Drawing.Size(65, 31);
            this.nudMinimumInventory.TabIndex = 21;
            // 
            // nudMaximumInventory
            // 
            this.nudMaximumInventory.Location = new System.Drawing.Point(243, 105);
            this.nudMaximumInventory.Name = "nudMaximumInventory";
            this.nudMaximumInventory.Size = new System.Drawing.Size(65, 31);
            this.nudMaximumInventory.TabIndex = 20;
            // 
            // nudNumberOfIntervals
            // 
            this.nudNumberOfIntervals.Location = new System.Drawing.Point(243, 146);
            this.nudNumberOfIntervals.Name = "nudNumberOfIntervals";
            this.nudNumberOfIntervals.Size = new System.Drawing.Size(65, 31);
            this.nudNumberOfIntervals.TabIndex = 19;
            this.nudNumberOfIntervals.ValueChanged += new System.EventHandler(this.nudNumberOfIntervals_ValueChanged);
            // 
            // tbShortageCost
            // 
            this.tbShortageCost.Location = new System.Drawing.Point(243, 395);
            this.tbShortageCost.Name = "tbShortageCost";
            this.tbShortageCost.Size = new System.Drawing.Size(65, 31);
            this.tbShortageCost.TabIndex = 18;
            this.tbShortageCost.Text = "0";
            // 
            // tbHoldingCost
            // 
            this.tbHoldingCost.Location = new System.Drawing.Point(243, 357);
            this.tbHoldingCost.Name = "tbHoldingCost";
            this.tbHoldingCost.Size = new System.Drawing.Size(65, 31);
            this.tbHoldingCost.TabIndex = 17;
            this.tbHoldingCost.Text = "0";
            // 
            // tbOrderSetupCost
            // 
            this.tbOrderSetupCost.Location = new System.Drawing.Point(243, 318);
            this.tbOrderSetupCost.Name = "tbOrderSetupCost";
            this.tbOrderSetupCost.Size = new System.Drawing.Size(65, 31);
            this.tbOrderSetupCost.TabIndex = 16;
            this.tbOrderSetupCost.Text = "0";
            // 
            // tbItemCost
            // 
            this.tbItemCost.Location = new System.Drawing.Point(243, 282);
            this.tbItemCost.Name = "tbItemCost";
            this.tbItemCost.Size = new System.Drawing.Size(65, 31);
            this.tbItemCost.TabIndex = 15;
            this.tbItemCost.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "Shortage Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "Holding Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Order Setup Cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Item Cost";
            // 
            // nudAverageDemand
            // 
            this.nudAverageDemand.Location = new System.Drawing.Point(243, 185);
            this.nudAverageDemand.Name = "nudAverageDemand";
            this.nudAverageDemand.Size = new System.Drawing.Size(65, 31);
            this.nudAverageDemand.TabIndex = 9;
            this.nudAverageDemand.ValueChanged += new System.EventHandler(this.nudAverageDemand_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Average Demand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Number of Intervals";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Maximum Inventory Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 23);
            this.label4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Minimum Inventory Level";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(351, 568);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Current Demand";
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
            this.splitContainer2.Panel1.Controls.Add(this.nudNumberOfIntervals2);
            this.splitContainer2.Panel1.Controls.Add(this.label13);
            this.splitContainer2.Panel1.Controls.Add(this.tbDemandVariance2);
            this.splitContainer2.Panel1.Controls.Add(this.nudAverageDemand2);
            this.splitContainer2.Panel1.Controls.Add(this.label12);
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnGenerateDemand);
            this.splitContainer2.Panel2.Controls.Add(this.tbDemandData);
            this.splitContainer2.Size = new System.Drawing.Size(343, 558);
            this.splitContainer2.SplitterDistance = 117;
            this.splitContainer2.TabIndex = 3;
            // 
            // tbDemandVariance2
            // 
            this.tbDemandVariance2.Enabled = false;
            this.tbDemandVariance2.Location = new System.Drawing.Point(244, 82);
            this.tbDemandVariance2.Name = "tbDemandVariance2";
            this.tbDemandVariance2.Size = new System.Drawing.Size(65, 31);
            this.tbDemandVariance2.TabIndex = 25;
            this.tbDemandVariance2.Text = "0";
            // 
            // nudAverageDemand2
            // 
            this.nudAverageDemand2.Enabled = false;
            this.nudAverageDemand2.Location = new System.Drawing.Point(244, 47);
            this.nudAverageDemand2.Name = "nudAverageDemand2";
            this.nudAverageDemand2.Size = new System.Drawing.Size(65, 31);
            this.nudAverageDemand2.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 23);
            this.label12.TabIndex = 23;
            this.label12.Text = "Demand Variance";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 23);
            this.label11.TabIndex = 5;
            this.label11.Text = "Average Demand";
            // 
            // btnGenerateDemand
            // 
            this.btnGenerateDemand.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerateDemand.Location = new System.Drawing.Point(0, 342);
            this.btnGenerateDemand.Name = "btnGenerateDemand";
            this.btnGenerateDemand.Size = new System.Drawing.Size(343, 40);
            this.btnGenerateDemand.TabIndex = 11;
            this.btnGenerateDemand.Text = "Regenerate Demands";
            this.btnGenerateDemand.UseVisualStyleBackColor = true;
            this.btnGenerateDemand.Click += new System.EventHandler(this.btnGenerateDemand_Click);
            // 
            // tbDemandData
            // 
            this.tbDemandData.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbDemandData.Location = new System.Drawing.Point(0, 0);
            this.tbDemandData.Multiline = true;
            this.tbDemandData.Name = "tbDemandData";
            this.tbDemandData.ReadOnly = true;
            this.tbDemandData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDemandData.Size = new System.Drawing.Size(343, 342);
            this.tbDemandData.TabIndex = 0;
            this.tbDemandData.WordWrap = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(830, 613);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer4);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(822, 577);
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
            this.splitContainer4.Panel1.Controls.Add(this.lbTimeAveragedShortageLevel);
            this.splitContainer4.Panel1.Controls.Add(this.lbTimeAveragedHoldingLevel);
            this.splitContainer4.Panel1.Controls.Add(this.lbAverOrder);
            this.splitContainer4.Panel1.Controls.Add(this.lbAverDemand);
            this.splitContainer4.Panel1.Controls.Add(this.btnSimulateTheInventory);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.inventoryChart);
            this.splitContainer4.Size = new System.Drawing.Size(816, 571);
            this.splitContainer4.SplitterDistance = 117;
            this.splitContainer4.TabIndex = 13;
            // 
            // lbTimeAveragedShortageLevel
            // 
            this.lbTimeAveragedShortageLevel.AutoSize = true;
            this.lbTimeAveragedShortageLevel.Location = new System.Drawing.Point(458, 54);
            this.lbTimeAveragedShortageLevel.Name = "lbTimeAveragedShortageLevel";
            this.lbTimeAveragedShortageLevel.Size = new System.Drawing.Size(327, 23);
            this.lbTimeAveragedShortageLevel.TabIndex = 21;
            this.lbTimeAveragedShortageLevel.Text = "Time-averaged Shortage Level：";
            // 
            // lbTimeAveragedHoldingLevel
            // 
            this.lbTimeAveragedHoldingLevel.AutoSize = true;
            this.lbTimeAveragedHoldingLevel.Location = new System.Drawing.Point(458, 23);
            this.lbTimeAveragedHoldingLevel.Name = "lbTimeAveragedHoldingLevel";
            this.lbTimeAveragedHoldingLevel.Size = new System.Drawing.Size(316, 23);
            this.lbTimeAveragedHoldingLevel.TabIndex = 20;
            this.lbTimeAveragedHoldingLevel.Text = "Time-averaged Holding Level：";
            // 
            // lbAverOrder
            // 
            this.lbAverOrder.AutoSize = true;
            this.lbAverOrder.Location = new System.Drawing.Point(248, 54);
            this.lbAverOrder.Name = "lbAverOrder";
            this.lbAverOrder.Size = new System.Drawing.Size(162, 23);
            this.lbAverOrder.TabIndex = 17;
            this.lbAverOrder.Text = "Average Order：";
            // 
            // lbAverDemand
            // 
            this.lbAverDemand.AutoSize = true;
            this.lbAverDemand.Location = new System.Drawing.Point(248, 24);
            this.lbAverDemand.Name = "lbAverDemand";
            this.lbAverDemand.Size = new System.Drawing.Size(173, 23);
            this.lbAverDemand.TabIndex = 16;
            this.lbAverDemand.Text = "Average Demand：";
            // 
            // btnSimulateTheInventory
            // 
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
            this.inventoryChart.Size = new System.Drawing.Size(816, 450);
            this.inventoryChart.TabIndex = 3;
            this.inventoryChart.Text = "chart1";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer3);
            this.tabPage4.Location = new System.Drawing.Point(4, 32);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(834, 568);
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
            this.splitContainer3.Size = new System.Drawing.Size(828, 562);
            this.splitContainer3.SplitterDistance = 95;
            this.splitContainer3.TabIndex = 1;
            // 
            // lbMinumumCostSpent
            // 
            this.lbMinumumCostSpent.AutoSize = true;
            this.lbMinumumCostSpent.ForeColor = System.Drawing.Color.Brown;
            this.lbMinumumCostSpent.Location = new System.Drawing.Point(412, 67);
            this.lbMinumumCostSpent.Name = "lbMinumumCostSpent";
            this.lbMinumumCostSpent.Size = new System.Drawing.Size(217, 23);
            this.lbMinumumCostSpent.TabIndex = 5;
            this.lbMinumumCostSpent.Text = "Minimum Cost Spent：";
            // 
            // lbBestMinumLevel
            // 
            this.lbBestMinumLevel.AutoSize = true;
            this.lbBestMinumLevel.ForeColor = System.Drawing.Color.Brown;
            this.lbBestMinumLevel.Location = new System.Drawing.Point(411, 43);
            this.lbBestMinumLevel.Name = "lbBestMinumLevel";
            this.lbBestMinumLevel.Size = new System.Drawing.Size(162, 23);
            this.lbBestMinumLevel.TabIndex = 4;
            this.lbBestMinumLevel.Text = "Minimum Level：";
            // 
            // btnFidnOptimum
            // 
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
            this.label18.Size = new System.Drawing.Size(230, 23);
            this.label18.TabIndex = 2;
            this.label18.Text = "Optimization Results";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(202, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(725, 23);
            this.label16.TabIndex = 0;
            this.label16.Text = "Optimization Simulation for Minimal Level (0 to Maximal level -1)";
            // 
            // OptimizationChart
            // 
            chartArea2.AxisX.Interval = 5D;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
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
            this.OptimizationChart.Size = new System.Drawing.Size(828, 463);
            this.OptimizationChart.TabIndex = 1;
            this.OptimizationChart.Text = "chart2";
            title1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Dependent Cost";
            this.OptimizationChart.Titles.Add(title1);
            this.OptimizationChart.Click += new System.EventHandler(this.OptimizationChart_Click);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 631);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1182, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbMessage
            // 
            this.lbMessage.ForeColor = System.Drawing.Color.Maroon;
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(1167, 16);
            this.lbMessage.Spring = true;
            // 
            // lbSettingsName
            // 
            this.lbSettingsName.AutoSize = true;
            this.lbSettingsName.ForeColor = System.Drawing.Color.Brown;
            this.lbSettingsName.Location = new System.Drawing.Point(15, 27);
            this.lbSettingsName.Name = "lbSettingsName";
            this.lbSettingsName.Size = new System.Drawing.Size(186, 23);
            this.lbSettingsName.TabIndex = 24;
            this.lbSettingsName.Text = "Default Settings";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(219, 23);
            this.label13.TabIndex = 26;
            this.label13.Text = "Number of Intervals";
            // 
            // nudNumberOfIntervals2
            // 
            this.nudNumberOfIntervals2.Enabled = false;
            this.nudNumberOfIntervals2.Location = new System.Drawing.Point(244, 10);
            this.nudNumberOfIntervals2.Name = "nudNumberOfIntervals2";
            this.nudNumberOfIntervals2.Size = new System.Drawing.Size(65, 31);
            this.nudNumberOfIntervals2.TabIndex = 27;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "MyForm";
            this.Text = "Simple Inventory System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimumInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfIntervals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAverageDemand)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAverageDemand2)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfIntervals2)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nudAverageDemand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataVisualization.Charting.Chart OptimizationChart;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnFidnOptimum;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label lbTimeAveragedShortageLevel;
        private System.Windows.Forms.Label lbTimeAveragedHoldingLevel;
        private System.Windows.Forms.Label lbAverOrder;
        private System.Windows.Forms.Label lbAverDemand;
        private System.Windows.Forms.Button btnSimulateTheInventory;
        private System.Windows.Forms.DataVisualization.Charting.Chart inventoryChart;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbMessage;
        private System.Windows.Forms.TextBox tbDemandData;
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
        private System.Windows.Forms.NumericUpDown nudMaximumInventory;
        private System.Windows.Forms.NumericUpDown nudNumberOfIntervals;
        private System.Windows.Forms.TextBox tbDemandVariance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbMinumumCostSpent;
        private System.Windows.Forms.Label lbBestMinumLevel;
        private System.Windows.Forms.ToolStripMenuItem btnSaveFile;
        private System.Windows.Forms.TextBox tbDemandVariance2;
        private System.Windows.Forms.NumericUpDown nudAverageDemand2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGenerateDemand;
        private System.Windows.Forms.Label lbSettingsName;
        private System.Windows.Forms.NumericUpDown nudNumberOfIntervals2;
        private System.Windows.Forms.Label label13;
    }
}

