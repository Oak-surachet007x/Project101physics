namespace CodingLabpro
{
    partial class frmMain01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain01));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GBoutput = new System.Windows.Forms.GroupBox();
            this.textread = new System.Windows.Forms.TextBox();
            this.GBdata = new System.Windows.Forms.GroupBox();
            this.GBconnect = new System.Windows.Forms.GroupBox();
            this.buttonLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnDiconnect = new System.Windows.Forms.Button();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.Cblistaddress3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cblistaddress2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cblistaddress = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTop = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.MainStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusicon = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusDMM = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusPort1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusMMC1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusPort2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusMMC2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusPort3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.GBchart = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CPchart = new System.Windows.Forms.Panel();
            this.BtnExport = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Menupanel = new System.Windows.Forms.Panel();
            this.ucMenu2 = new CodingLabpro.Models.ucMenu();
            this.ucMenu1 = new CodingLabpro.Models.ucMenu();
            this.Menu_panel = new System.Windows.Forms.Panel();
            this.tableLayoutMenu = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.GBoutput.SuspendLayout();
            this.GBconnect.SuspendLayout();
            this.buttonLayoutPanel2.SuspendLayout();
            this.MainStatus.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.GBchart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.CPchart.SuspendLayout();
            this.Menupanel.SuspendLayout();
            this.Menu_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.34653F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.34653F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.30693F));
            this.tableLayoutPanel1.Controls.Add(this.GBconnect, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.GBoutput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GBdata, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(80, 590);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1504, 241);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GBoutput
            // 
            this.GBoutput.Controls.Add(this.textread);
            this.GBoutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBoutput.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBoutput.ForeColor = System.Drawing.Color.White;
            this.GBoutput.Location = new System.Drawing.Point(10, 10);
            this.GBoutput.Margin = new System.Windows.Forms.Padding(10);
            this.GBoutput.Name = "GBoutput";
            this.GBoutput.Size = new System.Drawing.Size(556, 221);
            this.GBoutput.TabIndex = 0;
            this.GBoutput.TabStop = false;
            this.GBoutput.Text = "OUTPUT";
            // 
            // textread
            // 
            this.textread.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textread.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textread.ForeColor = System.Drawing.Color.White;
            this.textread.Location = new System.Drawing.Point(3, 22);
            this.textread.Multiline = true;
            this.textread.Name = "textread";
            this.textread.ReadOnly = true;
            this.textread.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textread.Size = new System.Drawing.Size(550, 196);
            this.textread.TabIndex = 0;
            // 
            // GBdata
            // 
            this.GBdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBdata.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBdata.ForeColor = System.Drawing.Color.White;
            this.GBdata.Location = new System.Drawing.Point(586, 10);
            this.GBdata.Margin = new System.Windows.Forms.Padding(10);
            this.GBdata.Name = "GBdata";
            this.GBdata.Size = new System.Drawing.Size(556, 221);
            this.GBdata.TabIndex = 1;
            this.GBdata.TabStop = false;
            this.GBdata.Text = "Measurement";
            // 
            // GBconnect
            // 
            this.GBconnect.Controls.Add(this.buttonLayoutPanel2);
            this.GBconnect.Controls.Add(this.Cblistaddress3);
            this.GBconnect.Controls.Add(this.label3);
            this.GBconnect.Controls.Add(this.Cblistaddress2);
            this.GBconnect.Controls.Add(this.label2);
            this.GBconnect.Controls.Add(this.Cblistaddress);
            this.GBconnect.Controls.Add(this.label1);
            this.GBconnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBconnect.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBconnect.ForeColor = System.Drawing.Color.White;
            this.GBconnect.Location = new System.Drawing.Point(1162, 10);
            this.GBconnect.Margin = new System.Windows.Forms.Padding(10);
            this.GBconnect.Name = "GBconnect";
            this.GBconnect.Size = new System.Drawing.Size(332, 221);
            this.GBconnect.TabIndex = 2;
            this.GBconnect.TabStop = false;
            this.GBconnect.Text = "Connection";
            // 
            // buttonLayoutPanel2
            // 
            this.buttonLayoutPanel2.ColumnCount = 2;
            this.buttonLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonLayoutPanel2.Controls.Add(this.BtnDiconnect, 0, 0);
            this.buttonLayoutPanel2.Controls.Add(this.BtnConnect, 1, 0);
            this.buttonLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLayoutPanel2.Location = new System.Drawing.Point(3, 182);
            this.buttonLayoutPanel2.Name = "buttonLayoutPanel2";
            this.buttonLayoutPanel2.RowCount = 1;
            this.buttonLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonLayoutPanel2.Size = new System.Drawing.Size(326, 36);
            this.buttonLayoutPanel2.TabIndex = 6;
            // 
            // BtnDiconnect
            // 
            this.BtnDiconnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDiconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDiconnect.ForeColor = System.Drawing.Color.Red;
            this.BtnDiconnect.Location = new System.Drawing.Point(3, 3);
            this.BtnDiconnect.Name = "BtnDiconnect";
            this.BtnDiconnect.Size = new System.Drawing.Size(157, 30);
            this.BtnDiconnect.TabIndex = 4;
            this.BtnDiconnect.Text = "Diconnect";
            this.BtnDiconnect.UseVisualStyleBackColor = true;
            this.BtnDiconnect.Click += new System.EventHandler(this.BtnDiconnect_Click);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnect.ForeColor = System.Drawing.Color.White;
            this.BtnConnect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnConnect.Location = new System.Drawing.Point(166, 3);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(157, 30);
            this.BtnConnect.TabIndex = 6;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // Cblistaddress3
            // 
            this.Cblistaddress3.FormattingEnabled = true;
            this.Cblistaddress3.Items.AddRange(new object[] {
            "COM7",
            "COM8"});
            this.Cblistaddress3.Location = new System.Drawing.Point(14, 147);
            this.Cblistaddress3.Name = "Cblistaddress3";
            this.Cblistaddress3.Size = new System.Drawing.Size(300, 29);
            this.Cblistaddress3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "RS-232 Port : Z-Axis Controller";
            // 
            // Cblistaddress2
            // 
            this.Cblistaddress2.FormattingEnabled = true;
            this.Cblistaddress2.Items.AddRange(new object[] {
            "Port1"});
            this.Cblistaddress2.Location = new System.Drawing.Point(15, 96);
            this.Cblistaddress2.Name = "Cblistaddress2";
            this.Cblistaddress2.Size = new System.Drawing.Size(300, 29);
            this.Cblistaddress2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "GP-IB Port : XY-Axis Controller";
            // 
            // Cblistaddress
            // 
            this.Cblistaddress.FormattingEnabled = true;
            this.Cblistaddress.Items.AddRange(new object[] {
            "Port 1"});
            this.Cblistaddress.Location = new System.Drawing.Point(14, 45);
            this.Cblistaddress.Name = "Cblistaddress";
            this.Cblistaddress.Size = new System.Drawing.Size(300, 29);
            this.Cblistaddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "GP-IB Port : Multimeter";
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.BackColor = System.Drawing.Color.Transparent;
            this.labelTop.Font = new System.Drawing.Font("Cascadia Mono", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.ForeColor = System.Drawing.Color.White;
            this.labelTop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTop.Location = new System.Drawing.Point(15, 0);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(264, 49);
            this.labelTop.TabIndex = 2;
            this.labelTop.Text = "MainControl";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(20, 49);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(370, 21);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Aglient 34401A And MMC-2 Axis Controller";
            // 
            // MainStatus
            // 
            this.MainStatus.AutoSize = false;
            this.MainStatus.BackColor = System.Drawing.Color.Transparent;
            this.MainStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusicon,
            this.StatusLabel,
            this.StatusDMM,
            this.StatusPort1,
            this.StatusMMC1,
            this.StatusPort2,
            this.StatusMMC2,
            this.StatusPort3});
            this.MainStatus.Location = new System.Drawing.Point(80, 831);
            this.MainStatus.Name = "MainStatus";
            this.MainStatus.Size = new System.Drawing.Size(1504, 30);
            this.MainStatus.TabIndex = 4;
            this.MainStatus.Text = "statusStrip1";
            // 
            // toolStripStatusicon
            // 
            this.toolStripStatusicon.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusicon.Image")));
            this.toolStripStatusicon.Name = "toolStripStatusicon";
            this.toolStripStatusicon.Size = new System.Drawing.Size(16, 25);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(49, 25);
            this.StatusLabel.Text = "Status";
            // 
            // StatusDMM
            // 
            this.StatusDMM.Font = new System.Drawing.Font("Cascadia Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusDMM.Name = "StatusDMM";
            this.StatusDMM.Size = new System.Drawing.Size(104, 25);
            this.StatusDMM.Text = "DMM-34401A :";
            // 
            // StatusPort1
            // 
            this.StatusPort1.BackColor = System.Drawing.Color.OrangeRed;
            this.StatusPort1.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusPort1.Name = "StatusPort1";
            this.StatusPort1.Size = new System.Drawing.Size(70, 25);
            this.StatusPort1.Text = "DICONNECT";
            // 
            // StatusMMC1
            // 
            this.StatusMMC1.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.StatusMMC1.Name = "StatusMMC1";
            this.StatusMMC1.Size = new System.Drawing.Size(56, 25);
            this.StatusMMC1.Text = "MMC1 :";
            // 
            // StatusPort2
            // 
            this.StatusPort2.BackColor = System.Drawing.Color.OrangeRed;
            this.StatusPort2.Font = new System.Drawing.Font("Cascadia Mono", 9F);
            this.StatusPort2.Name = "StatusPort2";
            this.StatusPort2.Size = new System.Drawing.Size(70, 25);
            this.StatusPort2.Text = "DICONNECT";
            // 
            // StatusMMC2
            // 
            this.StatusMMC2.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusMMC2.Name = "StatusMMC2";
            this.StatusMMC2.Size = new System.Drawing.Size(56, 25);
            this.StatusMMC2.Text = "MMC2 :";
            // 
            // StatusPort3
            // 
            this.StatusPort3.BackColor = System.Drawing.Color.OrangeRed;
            this.StatusPort3.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusPort3.Name = "StatusPort3";
            this.StatusPort3.Size = new System.Drawing.Size(70, 25);
            this.StatusPort3.Text = "DICONNECT";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.labelTop);
            this.panelTop.Controls.Add(this.labelName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(80, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1504, 88);
            this.panelTop.TabIndex = 6;
            // 
            // GBchart
            // 
            this.GBchart.BackColor = System.Drawing.Color.Transparent;
            this.GBchart.Controls.Add(this.chart1);
            this.GBchart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBchart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBchart.Font = new System.Drawing.Font("Cascadia Mono Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBchart.ForeColor = System.Drawing.Color.White;
            this.GBchart.Location = new System.Drawing.Point(80, 88);
            this.GBchart.Name = "GBchart";
            this.GBchart.Padding = new System.Windows.Forms.Padding(0);
            this.GBchart.Size = new System.Drawing.Size(1031, 457);
            this.GBchart.TabIndex = 8;
            this.GBchart.TabStop = false;
            this.GBchart.Text = "Data Measurement";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorTickMark.Size = 2F;
            chartArea2.AxisX.Title = "NameX";
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            chartArea2.AxisY.Title = "NameY";
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 84.33334F;
            chartArea2.Position.Width = 94F;
            chartArea2.Position.X = 1F;
            chartArea2.Position.Y = 12.66667F;
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Alignment = System.Drawing.StringAlignment.Far;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 22);
            this.chart1.Name = "chart1";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Orange;
            series2.MarkerSize = 7;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1031, 435);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // CPchart
            // 
            this.CPchart.BackColor = System.Drawing.Color.Transparent;
            this.CPchart.Controls.Add(this.BtnExport);
            this.CPchart.Controls.Add(this.BtnClear);
            this.CPchart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CPchart.ForeColor = System.Drawing.Color.White;
            this.CPchart.Location = new System.Drawing.Point(80, 545);
            this.CPchart.Margin = new System.Windows.Forms.Padding(10);
            this.CPchart.Name = "CPchart";
            this.CPchart.Size = new System.Drawing.Size(1031, 45);
            this.CPchart.TabIndex = 9;
            // 
            // BtnExport
            // 
            this.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExport.Location = new System.Drawing.Point(13, 9);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(120, 30);
            this.BtnExport.TabIndex = 1;
            this.BtnExport.Text = "Export .xlsx";
            this.BtnExport.UseVisualStyleBackColor = true;
            // 
            // BtnClear
            // 
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(139, 9);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(120, 30);
            this.BtnClear.TabIndex = 0;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Menupanel
            // 
            this.Menupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.Menupanel.Controls.Add(this.ucMenu2);
            this.Menupanel.Controls.Add(this.ucMenu1);
            this.Menupanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menupanel.Location = new System.Drawing.Point(0, 0);
            this.Menupanel.Name = "Menupanel";
            this.Menupanel.Size = new System.Drawing.Size(80, 861);
            this.Menupanel.TabIndex = 0;
            // 
            // ucMenu2
            // 
            this.ucMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.ucMenu2.BorderColor = System.Drawing.Color.Transparent;
            this.ucMenu2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucMenu2.Icon = global::CodingLabpro.Properties.Resources.dynamic_form_16dp_E8EAED;
            this.ucMenu2.Location = new System.Drawing.Point(0, 215);
            this.ucMenu2.Name = "ucMenu2";
            this.ucMenu2.Size = new System.Drawing.Size(80, 52);
            this.ucMenu2.TabIndex = 1;
            this.ucMenu2.textlabel = "Old_Form";
            // 
            // ucMenu1
            // 
            this.ucMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.ucMenu1.BorderColor = System.Drawing.Color.Transparent;
            this.ucMenu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucMenu1.Icon = global::CodingLabpro.Properties.Resources.photo_camera_16dp_FFFFFF_FILL1_wght100_GRAD0_opsz20;
            this.ucMenu1.Location = new System.Drawing.Point(0, 147);
            this.ucMenu1.Name = "ucMenu1";
            this.ucMenu1.Size = new System.Drawing.Size(80, 52);
            this.ucMenu1.TabIndex = 0;
            this.ucMenu1.textlabel = "ESP_CAM";
            // 
            // Menu_panel
            // 
            this.Menu_panel.BackColor = System.Drawing.Color.Transparent;
            this.Menu_panel.Controls.Add(this.tableLayoutMenu);
            this.Menu_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Menu_panel.Location = new System.Drawing.Point(1111, 88);
            this.Menu_panel.Name = "Menu_panel";
            this.Menu_panel.Size = new System.Drawing.Size(473, 502);
            this.Menu_panel.TabIndex = 4;
            // 
            // tableLayoutMenu
            // 
            this.tableLayoutMenu.ColumnCount = 1;
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMenu.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMenu.Name = "tableLayoutMenu";
            this.tableLayoutMenu.RowCount = 2;
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.43503F));
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.56497F));
            this.tableLayoutMenu.Size = new System.Drawing.Size(473, 502);
            this.tableLayoutMenu.TabIndex = 0;
            // 
            // frmMain01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.GBchart);
            this.Controls.Add(this.CPchart);
            this.Controls.Add(this.Menu_panel);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MainStatus);
            this.Controls.Add(this.Menupanel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmMain01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain01";
            this.Load += new System.EventHandler(this.frmMain01_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain01_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GBoutput.ResumeLayout(false);
            this.GBoutput.PerformLayout();
            this.GBconnect.ResumeLayout(false);
            this.GBconnect.PerformLayout();
            this.buttonLayoutPanel2.ResumeLayout(false);
            this.MainStatus.ResumeLayout(false);
            this.MainStatus.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.GBchart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.CPchart.ResumeLayout(false);
            this.Menupanel.ResumeLayout(false);
            this.Menu_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox GBoutput;

        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox GBdata;
        private System.Windows.Forms.GroupBox GBconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cblistaddress3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cblistaddress2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cblistaddress;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Button BtnDiconnect;
        private System.Windows.Forms.TableLayoutPanel buttonLayoutPanel2;
        private System.Windows.Forms.TextBox textread;
        private System.Windows.Forms.StatusStrip MainStatus;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ToolStripStatusLabel StatusDMM;
        private System.Windows.Forms.ToolStripStatusLabel StatusPort1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusicon;
        private System.Windows.Forms.ToolStripStatusLabel StatusMMC1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel StatusPort2;
        private System.Windows.Forms.ToolStripStatusLabel StatusMMC2;
        private System.Windows.Forms.ToolStripStatusLabel StatusPort3;
        private System.Windows.Forms.GroupBox GBchart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel CPchart;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel Menupanel;
        private Models.ucMenu ucMenu1;
        private Models.ucMenu ucMenu2;
        private System.Windows.Forms.Panel Menu_panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMenu;
    }
}