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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.toolStripStatusicon = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusDMM = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusPort1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusMMC1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusPort2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusMMC2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusPort3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LBExportFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.LBStatusLoading = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.LBdatetime = new System.Windows.Forms.Label();
            this.LBunitmeasurement = new System.Windows.Forms.Label();
            this.LBtimer = new System.Windows.Forms.Label();
            this.LBvaluemeasurement = new System.Windows.Forms.Label();
            this.flowLayoutBar = new System.Windows.Forms.FlowLayoutPanel();
            this.barMenu1 = new CodingLabpro.Models.barMenu();
            this.FormChildpanel = new System.Windows.Forms.Panel();
            this.Datetimenow = new System.Windows.Forms.Timer(this.components);
            this.Stoptimer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.TabToolbar = new System.Windows.Forms.TabControl();
            this.TabPage_Tools = new System.Windows.Forms.TabPage();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.ToolBtnExport = new System.Windows.Forms.ToolStripButton();
            this.ToolBtnExport_csv = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolBtnError = new System.Windows.Forms.ToolStripButton();
            this.ToolBtnClear = new System.Windows.Forms.ToolStripButton();
            this.TabPage_ConnectPort = new System.Windows.Forms.TabPage();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.BindingSource_DataMeasure = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.GBdata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMeasurement)).BeginInit();
            this.GBconnect.SuspendLayout();
            this.buttonLayoutPanel2.SuspendLayout();
            this.MainStatus.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.flowLayoutBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TabToolbar.SuspendLayout();
            this.TabPage_Tools.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.TabPage_ConnectPort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_DataMeasure)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.GBdata, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 259);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 472);
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
            this.GBdata.Size = new System.Drawing.Size(484, 452);
            this.GBdata.TabIndex = 1;
            this.GBdata.TabStop = false;
            this.GBdata.Text = "Measurement";
            // 
            // DgvMeasurement
            // 
            this.DgvMeasurement.AllowUserToAddRows = false;
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
            this.DgvMeasurement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMeasurement.Location = new System.Drawing.Point(7, 26);
            this.DgvMeasurement.Margin = new System.Windows.Forms.Padding(0);
            this.DgvMeasurement.Name = "DgvMeasurement";
            this.DgvMeasurement.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMeasurement.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvMeasurement.Size = new System.Drawing.Size(470, 419);
            this.DgvMeasurement.TabIndex = 0;
            this.DgvMeasurement.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvMeasurement_RowPostPaint);
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
            this.GBconnect.Size = new System.Drawing.Size(1220, 99);
            this.GBconnect.TabIndex = 2;
            this.GBconnect.TabStop = false;
            this.GBconnect.Text = "Connection";
            // 
            // Cblistaddress3
            // 
            this.Cblistaddress3.FormattingEnabled = true;
            this.Cblistaddress3.Location = new System.Drawing.Point(631, 45);
            this.Cblistaddress3.Name = "Cblistaddress3";
            this.Cblistaddress3.Size = new System.Drawing.Size(263, 29);
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
            this.buttonLayoutPanel2.Location = new System.Drawing.Point(907, 22);
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
            this.labelTop.Location = new System.Drawing.Point(2, 1);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(228, 43);
            this.labelTop.TabIndex = 2;
            this.labelTop.Text = "MainControl";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(9, 44);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(247, 15);
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
            this.StatusPort3,
            this.LBExportFile,
            this.LBStatusLoading});
            this.MainStatus.Location = new System.Drawing.Point(0, 731);
            this.MainStatus.Name = "MainStatus";
            this.MainStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainStatus.Size = new System.Drawing.Size(1234, 30);
            this.MainStatus.SizingGrip = false;
            this.MainStatus.TabIndex = 4;
            this.MainStatus.Text = "statusStrip1";
            // 
            // toolStripStatusicon
            // 
            this.toolStripStatusicon.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusicon.Image")));
            this.toolStripStatusicon.Name = "toolStripStatusicon";
            this.toolStripStatusicon.Size = new System.Drawing.Size(20, 25);
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
            // LBExportFile
            // 
            this.LBExportFile.AutoSize = false;
            this.LBExportFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBExportFile.ForeColor = System.Drawing.SystemColors.Control;
            this.LBExportFile.Image = global::CodingLabpro.Properties.Resources.file_export_33dp_8C1AF6_FILL0_wght400_GRAD0_opsz40;
            this.LBExportFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LBExportFile.Name = "LBExportFile";
            this.LBExportFile.Size = new System.Drawing.Size(724, 25);
            this.LBExportFile.Spring = true;
            this.LBExportFile.Text = "FilePath:";
            this.LBExportFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBStatusLoading
            // 
            this.LBStatusLoading.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBStatusLoading.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LBStatusLoading.Name = "LBStatusLoading";
            this.LBStatusLoading.Size = new System.Drawing.Size(29, 25);
            this.LBStatusLoading.Text = "0%";
            this.LBStatusLoading.Visible = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.LBdatetime);
            this.panelTop.Controls.Add(this.LBunitmeasurement);
            this.panelTop.Controls.Add(this.labelTop);
            this.panelTop.Controls.Add(this.labelName);
            this.panelTop.Controls.Add(this.LBtimer);
            this.panelTop.Controls.Add(this.LBvaluemeasurement);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 144);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(504, 115);
            this.panelTop.TabIndex = 6;
            // 
            // LBdatetime
            // 
            this.LBdatetime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBdatetime.AutoSize = true;
            this.LBdatetime.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBdatetime.Location = new System.Drawing.Point(261, 75);
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
            this.LBunitmeasurement.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBunitmeasurement.Location = new System.Drawing.Point(429, 11);
            this.LBunitmeasurement.Name = "LBunitmeasurement";
            this.LBunitmeasurement.Size = new System.Drawing.Size(79, 35);
            this.LBunitmeasurement.TabIndex = 6;
            this.LBunitmeasurement.Text = "Mode";
            this.LBunitmeasurement.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LBtimer
            // 
            this.LBtimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBtimer.AutoSize = true;
            this.LBtimer.BackColor = System.Drawing.Color.Transparent;
            this.LBtimer.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBtimer.Location = new System.Drawing.Point(276, 46);
            this.LBtimer.Name = "LBtimer";
            this.LBtimer.Size = new System.Drawing.Size(217, 29);
            this.LBtimer.TabIndex = 7;
            this.LBtimer.Text = "00:00:00.000";
            this.LBtimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBvaluemeasurement
            // 
            this.LBvaluemeasurement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBvaluemeasurement.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBvaluemeasurement.Location = new System.Drawing.Point(152, 9);
            this.LBvaluemeasurement.Margin = new System.Windows.Forms.Padding(0);
            this.LBvaluemeasurement.Name = "LBvaluemeasurement";
            this.LBvaluemeasurement.Size = new System.Drawing.Size(280, 35);
            this.LBvaluemeasurement.TabIndex = 5;
            this.LBvaluemeasurement.Text = "-00.0000";
            this.LBvaluemeasurement.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // flowLayoutBar
            // 
            this.flowLayoutBar.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutBar.Controls.Add(this.barMenu1);
            this.flowLayoutBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutBar.Location = new System.Drawing.Point(1184, 144);
            this.flowLayoutBar.Name = "flowLayoutBar";
            this.flowLayoutBar.Size = new System.Drawing.Size(50, 587);
            this.flowLayoutBar.TabIndex = 0;
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
            // FormChildpanel
            // 
            this.FormChildpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.FormChildpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.FormChildpanel.Location = new System.Drawing.Point(504, 144);
            this.FormChildpanel.Name = "FormChildpanel";
            this.FormChildpanel.Size = new System.Drawing.Size(680, 587);
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel1.Size = new System.Drawing.Size(1234, 144);
            this.panel1.TabIndex = 13;
            // 
            // TabToolbar
            // 
            this.TabToolbar.Controls.Add(this.TabPage_Tools);
            this.TabToolbar.Controls.Add(this.TabPage_ConnectPort);
            this.TabToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabToolbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabToolbar.ItemSize = new System.Drawing.Size(96, 21);
            this.TabToolbar.Location = new System.Drawing.Point(0, 10);
            this.TabToolbar.Multiline = true;
            this.TabToolbar.Name = "TabToolbar";
            this.TabToolbar.SelectedIndex = 0;
            this.TabToolbar.Size = new System.Drawing.Size(1234, 134);
            this.TabToolbar.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabToolbar.TabIndex = 0;
            // 
            // TabPage_Tools
            // 
            this.TabPage_Tools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.TabPage_Tools.Controls.Add(this.toolStripMenu);
            this.TabPage_Tools.ForeColor = System.Drawing.Color.Black;
            this.TabPage_Tools.Location = new System.Drawing.Point(4, 25);
            this.TabPage_Tools.Name = "TabPage_Tools";
            this.TabPage_Tools.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Tools.Size = new System.Drawing.Size(1226, 105);
            this.TabPage_Tools.TabIndex = 2;
            this.TabPage_Tools.Text = "Tools";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBtnExport,
            this.ToolBtnExport_csv,
            this.toolStripSeparator1,
            this.ToolBtnError,
            this.ToolBtnClear});
            this.toolStripMenu.Location = new System.Drawing.Point(3, 3);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1220, 99);
            this.toolStripMenu.TabIndex = 0;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // ToolBtnExport
            // 
            this.ToolBtnExport.AutoSize = false;
            this.ToolBtnExport.Image = global::CodingLabpro.Properties.Resources.File_excel_xlsx_icon;
            this.ToolBtnExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolBtnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBtnExport.Name = "ToolBtnExport";
            this.ToolBtnExport.Size = new System.Drawing.Size(100, 96);
            this.ToolBtnExport.Text = "Export to .xlsx";
            this.ToolBtnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolBtnExport.Click += new System.EventHandler(this.ToolBtnExport_Click);
            // 
            // ToolBtnExport_csv
            // 
            this.ToolBtnExport_csv.AutoSize = false;
            this.ToolBtnExport_csv.Image = global::CodingLabpro.Properties.Resources.File_csv_icon;
            this.ToolBtnExport_csv.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolBtnExport_csv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBtnExport_csv.Name = "ToolBtnExport_csv";
            this.ToolBtnExport_csv.Size = new System.Drawing.Size(100, 96);
            this.ToolBtnExport_csv.Text = "Export to .csv";
            this.ToolBtnExport_csv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolBtnExport_csv.Click += new System.EventHandler(this.ToolBtnExport_csv_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 99);
            // 
            // ToolBtnError
            // 
            this.ToolBtnError.Image = global::CodingLabpro.Properties.Resources.troubleshoot_64dp_8C1AF6_FILL0_wght400_GRAD0_opsz48;
            this.ToolBtnError.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolBtnError.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBtnError.Name = "ToolBtnError";
            this.ToolBtnError.Size = new System.Drawing.Size(75, 96);
            this.ToolBtnError.Text = "Check Error ";
            this.ToolBtnError.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ToolBtnError.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolBtnError.Click += new System.EventHandler(this.ToolBtnError_Click);
            // 
            // ToolBtnClear
            // 
            this.ToolBtnClear.Image = global::CodingLabpro.Properties.Resources.clean_code;
            this.ToolBtnClear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolBtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBtnClear.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.ToolBtnClear.Name = "ToolBtnClear";
            this.ToolBtnClear.Size = new System.Drawing.Size(71, 96);
            this.ToolBtnClear.Text = "Clear Errors";
            this.ToolBtnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolBtnClear.Click += new System.EventHandler(this.ToolBtnClear_Click);
            // 
            // TabPage_ConnectPort
            // 
            this.TabPage_ConnectPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.TabPage_ConnectPort.Controls.Add(this.GBconnect);
            this.TabPage_ConnectPort.Location = new System.Drawing.Point(4, 25);
            this.TabPage_ConnectPort.Name = "TabPage_ConnectPort";
            this.TabPage_ConnectPort.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_ConnectPort.Size = new System.Drawing.Size(1226, 105);
            this.TabPage_ConnectPort.TabIndex = 1;
            this.TabPage_ConnectPort.Text = "Connect";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // FrmMain01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1234, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.FormChildpanel);
            this.Controls.Add(this.flowLayoutBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainStatus);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.flowLayoutBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.TabToolbar.ResumeLayout(false);
            this.TabPage_Tools.ResumeLayout(false);
            this.TabPage_Tools.PerformLayout();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.TabPage_ConnectPort.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_DataMeasure)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutBar;
        private System.Windows.Forms.Panel FormChildpanel;
        private Models.barMenu barMenu1;
        private System.Windows.Forms.DataGridView DgvMeasurement;
        private System.Windows.Forms.Label LBdatetime;
        private System.Windows.Forms.Label LBvaluemeasurement;
        private System.Windows.Forms.Timer Datetimenow;
        private System.Windows.Forms.Timer Stoptimer1;
        public System.Windows.Forms.Label LBtimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl TabToolbar;
        private System.Windows.Forms.TabPage TabPage_ConnectPort;
        private System.Windows.Forms.TabPage TabPage_Tools;
        private System.Windows.Forms.Label LBunitmeasurement;
        private System.Windows.Forms.ToolStripStatusLabel StatusPort3;
        private System.Windows.Forms.BindingSource BindingSource_DataMeasure;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton ToolBtnExport;
        private System.Windows.Forms.ToolStripStatusLabel LBExportFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ToolBtnError;
        private System.Windows.Forms.ToolStripButton ToolBtnClear;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ToolStripStatusLabel LBStatusLoading;
        private System.Windows.Forms.ToolStripButton ToolBtnExport_csv;
    }
}