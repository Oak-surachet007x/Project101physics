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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain01));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GBdata = new System.Windows.Forms.GroupBox();
            this.DgvMeasurement = new System.Windows.Forms.DataGridView();
            this.GBconnect = new System.Windows.Forms.GroupBox();
            this.Cblistaddress3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cblistaddress2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cblistaddress = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnDiconnect = new System.Windows.Forms.Button();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.labelTop = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.MainStatus = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusDMM = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusPort1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusMMC1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusPort2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusMMC2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusPort3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.LBdatetime = new System.Windows.Forms.Label();
            this.LBunitmeasurement = new System.Windows.Forms.Label();
            this.LBvaluemeasurement = new System.Windows.Forms.Label();
            this.LBtimer = new System.Windows.Forms.Label();
            this.GBchart = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Menupanel = new System.Windows.Forms.Panel();
            this.flowLayoutBar = new System.Windows.Forms.FlowLayoutPanel();
            this.FormChildpanel = new System.Windows.Forms.Panel();
            this.Datetimenow = new System.Windows.Forms.Timer(this.components);
            this.Stoptimer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.TabToolbar = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TabPage_ConnectPort = new System.Windows.Forms.TabPage();
            this.toolStripStatusicon = new System.Windows.Forms.ToolStripStatusLabel();
            this.barMenu1 = new CodingLabpro.Models.barMenu();
            this.ucMenu3 = new CodingLabpro.Models.ucMenu();
            this.ucMenu2 = new CodingLabpro.Models.ucMenu();
            this.ucMenu1 = new CodingLabpro.Models.ucMenu();
            this.tableLayoutPanel1.SuspendLayout();
            this.GBdata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMeasurement)).BeginInit();
            this.GBconnect.SuspendLayout();
            this.buttonLayoutPanel2.SuspendLayout();
            this.MainStatus.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.GBchart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.Menupanel.SuspendLayout();
            this.flowLayoutBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TabToolbar.SuspendLayout();
            this.TabPage_ConnectPort.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.68965F));
            this.tableLayoutPanel1.Controls.Add(this.GBdata, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(85, 559);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(725, 256);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.GBdata.Size = new System.Drawing.Size(705, 236);
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
            this.DgvMeasurement.Size = new System.Drawing.Size(691, 203);
            this.DgvMeasurement.TabIndex = 0;
            // 
            // GBconnect
            // 
            this.GBconnect.BackColor = System.Drawing.Color.Transparent;
            this.GBconnect.Controls.Add(this.Cblistaddress3);
            this.GBconnect.Controls.Add(this.label3);
            this.GBconnect.Controls.Add(this.Cblistaddress2);
            this.GBconnect.Controls.Add(this.label2);
            this.GBconnect.Controls.Add(this.Cblistaddress);
            this.GBconnect.Controls.Add(this.label1);
            this.GBconnect.Controls.Add(this.buttonLayoutPanel2);
            this.GBconnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBconnect.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBconnect.ForeColor = System.Drawing.Color.Black;
            this.GBconnect.Location = new System.Drawing.Point(3, 3);
            this.GBconnect.Margin = new System.Windows.Forms.Padding(10);
            this.GBconnect.Name = "GBconnect";
            this.GBconnect.Size = new System.Drawing.Size(1441, 99);
            this.GBconnect.TabIndex = 2;
            this.GBconnect.TabStop = false;
            this.GBconnect.Text = "Connection";
            // 
            // Cblistaddress3
            // 
            this.Cblistaddress3.FormattingEnabled = true;
            this.Cblistaddress3.Location = new System.Drawing.Point(631, 45);
            this.Cblistaddress3.Name = "Cblistaddress3";
            this.Cblistaddress3.Size = new System.Drawing.Size(290, 29);
            this.Cblistaddress3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(629, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "RS-232 Port : Z-Axis Controller";
            // 
            // Cblistaddress2
            // 
            this.Cblistaddress2.FormattingEnabled = true;
            this.Cblistaddress2.Location = new System.Drawing.Point(321, 45);
            this.Cblistaddress2.Name = "Cblistaddress2";
            this.Cblistaddress2.Size = new System.Drawing.Size(290, 29);
            this.Cblistaddress2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 26);
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
            this.Cblistaddress.Size = new System.Drawing.Size(290, 29);
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
            // buttonLayoutPanel2
            // 
            this.buttonLayoutPanel2.ColumnCount = 2;
            this.buttonLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonLayoutPanel2.Controls.Add(this.BtnDiconnect, 0, 0);
            this.buttonLayoutPanel2.Controls.Add(this.BtnConnect, 1, 0);
            this.buttonLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonLayoutPanel2.Location = new System.Drawing.Point(1128, 22);
            this.buttonLayoutPanel2.Name = "buttonLayoutPanel2";
            this.buttonLayoutPanel2.RowCount = 1;
            this.buttonLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonLayoutPanel2.Size = new System.Drawing.Size(310, 74);
            this.buttonLayoutPanel2.TabIndex = 6;
            // 
            // BtnDiconnect
            // 
            this.BtnDiconnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDiconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDiconnect.ForeColor = System.Drawing.Color.Red;
            this.BtnDiconnect.Location = new System.Drawing.Point(3, 3);
            this.BtnDiconnect.Name = "BtnDiconnect";
            this.BtnDiconnect.Size = new System.Drawing.Size(149, 68);
            this.BtnDiconnect.TabIndex = 4;
            this.BtnDiconnect.Text = "Diconnect";
            this.BtnDiconnect.UseVisualStyleBackColor = true;
            this.BtnDiconnect.Click += new System.EventHandler(this.BtnDiconnect_Click);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnect.ForeColor = System.Drawing.Color.Black;
            this.BtnConnect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnConnect.Location = new System.Drawing.Point(158, 3);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(149, 68);
            this.BtnConnect.TabIndex = 6;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.BackColor = System.Drawing.Color.Transparent;
            this.labelTop.Font = new System.Drawing.Font("Cascadia Mono", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.ForeColor = System.Drawing.Color.White;
            this.labelTop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTop.Location = new System.Drawing.Point(4, 1);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(228, 43);
            this.labelTop.TabIndex = 2;
            this.labelTop.Text = "MainControl";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(10, 44);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(328, 17);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Aglient 34401A And MMC-2 Axis Controller";
            // 
            // MainStatus
            // 
            this.MainStatus.AutoSize = false;
            this.MainStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.MainStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.MainStatus.Location = new System.Drawing.Point(0, 815);
            this.MainStatus.Name = "MainStatus";
            this.MainStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainStatus.Size = new System.Drawing.Size(1540, 30);
            this.MainStatus.SizingGrip = false;
            this.MainStatus.TabIndex = 4;
            this.MainStatus.Text = "statusStrip1";
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
            this.panelTop.Controls.Add(this.LBdatetime);
            this.panelTop.Controls.Add(this.LBunitmeasurement);
            this.panelTop.Controls.Add(this.LBvaluemeasurement);
            this.panelTop.Controls.Add(this.labelTop);
            this.panelTop.Controls.Add(this.labelName);
            this.panelTop.Controls.Add(this.LBtimer);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(85, 144);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(725, 104);
            this.panelTop.TabIndex = 6;
            // 
            // LBdatetime
            // 
            this.LBdatetime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBdatetime.AutoSize = true;
            this.LBdatetime.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBdatetime.Location = new System.Drawing.Point(487, 84);
            this.LBdatetime.Name = "LBdatetime";
            this.LBdatetime.Size = new System.Drawing.Size(228, 17);
            this.LBdatetime.TabIndex = 4;
            this.LBdatetime.Text = "MM-dd-yyyy HH:mm:ss tt";
            this.LBdatetime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LBunitmeasurement
            // 
            this.LBunitmeasurement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBunitmeasurement.AutoSize = true;
            this.LBunitmeasurement.Font = new System.Drawing.Font("Cascadia Code SemiLight", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBunitmeasurement.Location = new System.Drawing.Point(615, 1);
            this.LBunitmeasurement.Name = "LBunitmeasurement";
            this.LBunitmeasurement.Size = new System.Drawing.Size(110, 49);
            this.LBunitmeasurement.TabIndex = 6;
            this.LBunitmeasurement.Text = "Mode";
            this.LBunitmeasurement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBvaluemeasurement
            // 
            this.LBvaluemeasurement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBvaluemeasurement.AutoSize = true;
            this.LBvaluemeasurement.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBvaluemeasurement.Location = new System.Drawing.Point(429, 9);
            this.LBvaluemeasurement.Name = "LBvaluemeasurement";
            this.LBvaluemeasurement.Size = new System.Drawing.Size(193, 39);
            this.LBvaluemeasurement.TabIndex = 5;
            this.LBvaluemeasurement.Text = "-00.0000";
            this.LBvaluemeasurement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBtimer
            // 
            this.LBtimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBtimer.AutoSize = true;
            this.LBtimer.BackColor = System.Drawing.Color.Transparent;
            this.LBtimer.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBtimer.Location = new System.Drawing.Point(498, 50);
            this.LBtimer.Name = "LBtimer";
            this.LBtimer.Size = new System.Drawing.Size(217, 29);
            this.LBtimer.TabIndex = 7;
            this.LBtimer.Text = "00:00:00.000";
            this.LBtimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GBchart
            // 
            this.GBchart.BackColor = System.Drawing.Color.Transparent;
            this.GBchart.Controls.Add(this.chart1);
            this.GBchart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBchart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBchart.Font = new System.Drawing.Font("Cascadia Mono Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBchart.ForeColor = System.Drawing.Color.White;
            this.GBchart.Location = new System.Drawing.Point(85, 248);
            this.GBchart.Name = "GBchart";
            this.GBchart.Padding = new System.Windows.Forms.Padding(0);
            this.GBchart.Size = new System.Drawing.Size(725, 311);
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
            this.chart1.Size = new System.Drawing.Size(725, 289);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Menupanel
            // 
            this.Menupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.Menupanel.Controls.Add(this.ucMenu3);
            this.Menupanel.Controls.Add(this.ucMenu2);
            this.Menupanel.Controls.Add(this.ucMenu1);
            this.Menupanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menupanel.Location = new System.Drawing.Point(0, 0);
            this.Menupanel.Name = "Menupanel";
            this.Menupanel.Size = new System.Drawing.Size(85, 815);
            this.Menupanel.TabIndex = 0;
            // 
            // flowLayoutBar
            // 
            this.flowLayoutBar.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutBar.Controls.Add(this.barMenu1);
            this.flowLayoutBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutBar.Location = new System.Drawing.Point(1490, 144);
            this.flowLayoutBar.Name = "flowLayoutBar";
            this.flowLayoutBar.Size = new System.Drawing.Size(50, 671);
            this.flowLayoutBar.TabIndex = 0;
            // 
            // FormChildpanel
            // 
            this.FormChildpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.FormChildpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.FormChildpanel.Location = new System.Drawing.Point(810, 144);
            this.FormChildpanel.Name = "FormChildpanel";
            this.FormChildpanel.Size = new System.Drawing.Size(680, 671);
            this.FormChildpanel.TabIndex = 0;
            // 
            // Datetimenow
            // 
            this.Datetimenow.Enabled = true;
            this.Datetimenow.Tick += new System.EventHandler(this.DataTimeNow_Tick);
            // 
            // Stoptimer1
            // 
            this.Stoptimer1.Tick += new System.EventHandler(this.Stoptimer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.TabToolbar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(85, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel1.Size = new System.Drawing.Size(1455, 144);
            this.panel1.TabIndex = 13;
            // 
            // TabToolbar
            // 
            this.TabToolbar.Controls.Add(this.tabPage1);
            this.TabToolbar.Controls.Add(this.TabPage_ConnectPort);
            this.TabToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabToolbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabToolbar.ItemSize = new System.Drawing.Size(96, 21);
            this.TabToolbar.Location = new System.Drawing.Point(0, 10);
            this.TabToolbar.Multiline = true;
            this.TabToolbar.Name = "TabToolbar";
            this.TabToolbar.SelectedIndex = 0;
            this.TabToolbar.Size = new System.Drawing.Size(1455, 134);
            this.TabToolbar.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabToolbar.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1447, 105);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "File";
            // 
            // TabPage_ConnectPort
            // 
            this.TabPage_ConnectPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.TabPage_ConnectPort.Controls.Add(this.GBconnect);
            this.TabPage_ConnectPort.Location = new System.Drawing.Point(4, 25);
            this.TabPage_ConnectPort.Name = "TabPage_ConnectPort";
            this.TabPage_ConnectPort.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_ConnectPort.Size = new System.Drawing.Size(1447, 105);
            this.TabPage_ConnectPort.TabIndex = 1;
            this.TabPage_ConnectPort.Text = "Connect";
            // 
            // toolStripStatusicon
            // 
            this.toolStripStatusicon.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusicon.Image")));
            this.toolStripStatusicon.Name = "toolStripStatusicon";
            this.toolStripStatusicon.Size = new System.Drawing.Size(20, 25);
            // 
            // barMenu1
            // 
            this.barMenu1.BackColor = System.Drawing.Color.Transparent;
            this.barMenu1.BarColor = System.Drawing.Color.White;
            this.barMenu1.Location = new System.Drawing.Point(6, 12);
            this.barMenu1.Margin = new System.Windows.Forms.Padding(6, 12, 0, 6);
            this.barMenu1.Name = "barMenu1";
            this.barMenu1.Size = new System.Drawing.Size(50, 222);
            this.barMenu1.TabIndex = 0;
            this.barMenu1.textbar = "Axis Control & Measument";
            // 
            // ucMenu3
            // 
            this.ucMenu3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ucMenu3.BackColor = System.Drawing.Color.Transparent;
            this.ucMenu3.BorderColor = System.Drawing.Color.Transparent;
            this.ucMenu3.ForeColor = System.Drawing.Color.White;
            this.ucMenu3.Icon = global::CodingLabpro.Properties.Resources.frame_bug_70dp_8C1AF6_FILL0_wght400_GRAD0_opsz48;
            this.ucMenu3.Location = new System.Drawing.Point(-8, 746);
            this.ucMenu3.Name = "ucMenu3";
            this.ucMenu3.Size = new System.Drawing.Size(90, 52);
            this.ucMenu3.TabIndex = 2;
            this.ucMenu3.textlabel = "Output_Log";
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
            // FrmMain01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.GBchart);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.FormChildpanel);
            this.Controls.Add(this.flowLayoutBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Menupanel);
            this.Controls.Add(this.MainStatus);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMain01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain01";
            this.Load += new System.EventHandler(this.FrmMain01_Load);
            this.SizeChanged += new System.EventHandler(this.FrmMain01_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GBdata.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMeasurement)).EndInit();
            this.GBconnect.ResumeLayout(false);
            this.GBconnect.PerformLayout();
            this.buttonLayoutPanel2.ResumeLayout(false);
            this.MainStatus.ResumeLayout(false);
            this.MainStatus.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.GBchart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.Menupanel.ResumeLayout(false);
            this.flowLayoutBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.TabToolbar.ResumeLayout(false);
            this.TabPage_ConnectPort.ResumeLayout(false);
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
        private System.Windows.Forms.Panel Menupanel;
        private Models.ucMenu ucMenu2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutBar;
        private System.Windows.Forms.Panel FormChildpanel;
        private Models.barMenu barMenu1;
        private Models.ucMenu ucMenu1;
        private System.Windows.Forms.DataGridView DgvMeasurement;
        private System.Windows.Forms.Label LBdatetime;
        private System.Windows.Forms.Label LBvaluemeasurement;
        private System.Windows.Forms.Label LBunitmeasurement;
        private System.Windows.Forms.Timer Datetimenow;
        private System.Windows.Forms.Timer Stoptimer1;
        public System.Windows.Forms.Label LBtimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl TabToolbar;
        private System.Windows.Forms.TabPage TabPage_ConnectPort;
        private System.Windows.Forms.TabPage tabPage1;
        private Models.ucMenu ucMenu3;
    }
}