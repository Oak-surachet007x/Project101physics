namespace CodingLabpro
{
    partial class FrmMain01
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain01));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.GBdata = new System.Windows.Forms.GroupBox();
            this.DgvMeasurement = new System.Windows.Forms.DataGridView();
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
            this.flowLayoutBar = new System.Windows.Forms.FlowLayoutPanel();
            this.barMenu1 = new CodingLabpro.Models.barMenu();
            this.barMenu2 = new CodingLabpro.Models.barMenu();
            this.FormChildpanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.GBconnect.SuspendLayout();
            this.buttonLayoutPanel2.SuspendLayout();
            this.GBdata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMeasurement)).BeginInit();
            this.MainStatus.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.GBchart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.CPchart.SuspendLayout();
            this.Menupanel.SuspendLayout();
            this.flowLayoutBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.12811F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.87189F));
            this.tableLayoutPanel1.Controls.Add(this.GBconnect, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.GBdata, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(85, 536);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1124, 295);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.GBconnect.Location = new System.Drawing.Point(787, 10);
            this.GBconnect.Margin = new System.Windows.Forms.Padding(10);
            this.GBconnect.Name = "GBconnect";
            this.GBconnect.Size = new System.Drawing.Size(327, 275);
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
            this.buttonLayoutPanel2.Location = new System.Drawing.Point(3, 236);
            this.buttonLayoutPanel2.Name = "buttonLayoutPanel2";
            this.buttonLayoutPanel2.RowCount = 1;
            this.buttonLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonLayoutPanel2.Size = new System.Drawing.Size(321, 36);
            this.buttonLayoutPanel2.TabIndex = 6;
            // 
            // BtnDiconnect
            // 
            this.BtnDiconnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDiconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDiconnect.ForeColor = System.Drawing.Color.Red;
            this.BtnDiconnect.Location = new System.Drawing.Point(3, 3);
            this.BtnDiconnect.Name = "BtnDiconnect";
            this.BtnDiconnect.Size = new System.Drawing.Size(154, 30);
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
            this.BtnConnect.Location = new System.Drawing.Point(163, 3);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(155, 30);
            this.BtnConnect.TabIndex = 6;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // Cblistaddress3
            // 
            this.Cblistaddress3.FormattingEnabled = true;
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
            // GBdata
            // 
            this.GBdata.Controls.Add(this.DgvMeasurement);
            this.GBdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBdata.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBdata.ForeColor = System.Drawing.Color.White;
            this.GBdata.Location = new System.Drawing.Point(10, 10);
            this.GBdata.Margin = new System.Windows.Forms.Padding(10);
            this.GBdata.Name = "GBdata";
            this.GBdata.Padding = new System.Windows.Forms.Padding(7);
            this.GBdata.Size = new System.Drawing.Size(757, 275);
            this.GBdata.TabIndex = 1;
            this.GBdata.TabStop = false;
            this.GBdata.Text = "Measurement";
            // 
            // DgvMeasurement
            // 
            this.DgvMeasurement.BackgroundColor = System.Drawing.Color.White;
            this.DgvMeasurement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMeasurement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvMeasurement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMeasurement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMeasurement.Location = new System.Drawing.Point(7, 26);
            this.DgvMeasurement.Margin = new System.Windows.Forms.Padding(0);
            this.DgvMeasurement.Name = "DgvMeasurement";
            this.DgvMeasurement.Size = new System.Drawing.Size(743, 242);
            this.DgvMeasurement.TabIndex = 0;
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
            this.MainStatus.Location = new System.Drawing.Point(85, 831);
            this.MainStatus.Name = "MainStatus";
            this.MainStatus.Size = new System.Drawing.Size(1499, 30);
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
            this.panelTop.Location = new System.Drawing.Point(85, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1124, 88);
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
            this.GBchart.Location = new System.Drawing.Point(85, 88);
            this.GBchart.Name = "GBchart";
            this.GBchart.Padding = new System.Windows.Forms.Padding(0);
            this.GBchart.Size = new System.Drawing.Size(1124, 403);
            this.GBchart.TabIndex = 8;
            this.GBchart.TabStop = false;
            this.GBchart.Text = "Data Measurement";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.Size = 2F;
            chartArea1.AxisX.Title = "NameX";
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            chartArea1.AxisY.Title = "NameY";
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 84.33334F;
            chartArea1.Position.Width = 94F;
            chartArea1.Position.X = 1F;
            chartArea1.Position.Y = 12.66667F;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 22);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Orange;
            series1.MarkerSize = 7;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1124, 381);
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
            this.CPchart.Location = new System.Drawing.Point(85, 491);
            this.CPchart.Margin = new System.Windows.Forms.Padding(10);
            this.CPchart.Name = "CPchart";
            this.CPchart.Size = new System.Drawing.Size(1124, 45);
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
            // Menupanel
            // 
            this.Menupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.Menupanel.Controls.Add(this.ucMenu2);
            this.Menupanel.Controls.Add(this.ucMenu1);
            this.Menupanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menupanel.Location = new System.Drawing.Point(0, 0);
            this.Menupanel.Name = "Menupanel";
            this.Menupanel.Size = new System.Drawing.Size(85, 861);
            this.Menupanel.TabIndex = 0;
            // 
            // ucMenu2
            // 
            this.ucMenu2.BackColor = System.Drawing.Color.Transparent;
            this.ucMenu2.BorderColor = System.Drawing.Color.Transparent;
            this.ucMenu2.Icon = global::CodingLabpro.Properties.Resources.dynamic_form_16dp_E8EAED;
            this.ucMenu2.Location = new System.Drawing.Point(-8, 272);
            this.ucMenu2.Name = "ucMenu2";
            this.ucMenu2.Size = new System.Drawing.Size(90, 52);
            this.ucMenu2.TabIndex = 1;
            this.ucMenu2.textlabel = "Old_Form";
            // 
            // ucMenu1
            // 
            this.ucMenu1.BackColor = System.Drawing.Color.Transparent;
            this.ucMenu1.BorderColor = System.Drawing.Color.Transparent;
            this.ucMenu1.Icon = global::CodingLabpro.Properties.Resources.help_center_16dp_E8EAED;
            this.ucMenu1.Location = new System.Drawing.Point(-8, 202);
            this.ucMenu1.Name = "ucMenu1";
            this.ucMenu1.Size = new System.Drawing.Size(90, 52);
            this.ucMenu1.TabIndex = 0;
            this.ucMenu1.textlabel = "Help";
            // 
            // flowLayoutBar
            // 
            this.flowLayoutBar.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutBar.Controls.Add(this.barMenu1);
            this.flowLayoutBar.Controls.Add(this.barMenu2);
            this.flowLayoutBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutBar.Location = new System.Drawing.Point(1534, 0);
            this.flowLayoutBar.Name = "flowLayoutBar";
            this.flowLayoutBar.Size = new System.Drawing.Size(50, 831);
            this.flowLayoutBar.TabIndex = 10;
            // 
            // barMenu1
            // 
            this.barMenu1.BackColor = System.Drawing.Color.Transparent;
            this.barMenu1.BarColor = System.Drawing.Color.White;
            this.barMenu1.Location = new System.Drawing.Point(6, 12);
            this.barMenu1.Margin = new System.Windows.Forms.Padding(6, 12, 0, 6);
            this.barMenu1.Name = "barMenu1";
            this.barMenu1.Size = new System.Drawing.Size(50, 132);
            this.barMenu1.TabIndex = 11;
            this.barMenu1.textbar = "Axis Control";
            // 
            // barMenu2
            // 
            this.barMenu2.BackColor = System.Drawing.Color.Transparent;
            this.barMenu2.BarColor = System.Drawing.Color.White;
            this.barMenu2.Location = new System.Drawing.Point(6, 156);
            this.barMenu2.Margin = new System.Windows.Forms.Padding(6);
            this.barMenu2.Name = "barMenu2";
            this.barMenu2.Size = new System.Drawing.Size(50, 125);
            this.barMenu2.TabIndex = 12;
            this.barMenu2.textbar = "Measurement";
            // 
            // FormChildpanel
            // 
            this.FormChildpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.FormChildpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.FormChildpanel.Location = new System.Drawing.Point(1209, 0);
            this.FormChildpanel.Name = "FormChildpanel";
            this.FormChildpanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.FormChildpanel.Size = new System.Drawing.Size(325, 831);
            this.FormChildpanel.TabIndex = 11;
            // 
            // FrmMain01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.GBchart);
            this.Controls.Add(this.CPchart);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.FormChildpanel);
            this.Controls.Add(this.flowLayoutBar);
            this.Controls.Add(this.MainStatus);
            this.Controls.Add(this.Menupanel);
            this.ForeColor = System.Drawing.Color.White;
            this.IsMdiContainer = true;
            this.Name = "FrmMain01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain01";
            this.Load += new System.EventHandler(this.FrmMain01_Load);
            this.Shown += new System.EventHandler(this.FrmMain01_Shown);
            this.SizeChanged += new System.EventHandler(this.FrmMain01_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GBconnect.ResumeLayout(false);
            this.GBconnect.PerformLayout();
            this.buttonLayoutPanel2.ResumeLayout(false);
            this.GBdata.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMeasurement)).EndInit();
            this.MainStatus.ResumeLayout(false);
            this.MainStatus.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.GBchart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.CPchart.ResumeLayout(false);
            this.Menupanel.ResumeLayout(false);
            this.flowLayoutBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

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
        private Models.ucMenu ucMenu2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutBar;
        private System.Windows.Forms.Panel FormChildpanel;
        private Models.barMenu barMenu1;
        private Models.barMenu barMenu2;
        private Models.ucMenu ucMenu1;
        private System.Windows.Forms.DataGridView DgvMeasurement;
    }
}