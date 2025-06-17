namespace CodingLabpro.frmChild
{
    partial class AxisControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTop = new System.Windows.Forms.Label();
            this.labeltitle = new System.Windows.Forms.Label();
            this.Btn_stopmotor = new System.Windows.Forms.Button();
            this.Btn_XRight = new System.Windows.Forms.Button();
            this.Btn_XLeft = new System.Windows.Forms.Button();
            this.Btn_YDown = new System.Windows.Forms.Button();
            this.Btn_YUp = new System.Windows.Forms.Button();
            this.CblStepMotor = new System.Windows.Forms.ComboBox();
            this.labelstep = new System.Windows.Forms.Label();
            this.Btn_ResetHome = new System.Windows.Forms.Button();
            this.labelUnit2 = new System.Windows.Forms.Label();
            this.labelUnit1 = new System.Windows.Forms.Label();
            this.AxisScanYlabal = new System.Windows.Forms.Label();
            this.AxisScanXlabal = new System.Windows.Forms.Label();
            this.Sublabel1 = new System.Windows.Forms.Label();
            this.Sublabel2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_timerunit = new System.Windows.Forms.Label();
            this.Cbltimer = new System.Windows.Forms.ComboBox();
            this.labelDelay = new System.Windows.Forms.Label();
            this.Motortype2 = new System.Windows.Forms.ComboBox();
            this.Motortype = new System.Windows.Forms.ComboBox();
            this.TxtstepY = new System.Windows.Forms.TextBox();
            this.TxtstepX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_runscaning = new System.Windows.Forms.Button();
            this.Reportdata = new System.Windows.Forms.TextBox();
            this.GBreport = new System.Windows.Forms.GroupBox();
            this.TbAreaX = new System.Windows.Forms.TextBox();
            this.TbAreaY = new System.Windows.Forms.TextBox();
            this.GBmotorport = new System.Windows.Forms.GroupBox();
            this.RB_rs232 = new System.Windows.Forms.RadioButton();
            this.RB_gpib = new System.Windows.Forms.RadioButton();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Btn_clear = new System.Windows.Forms.Button();
            this.Btn_read = new System.Windows.Forms.Button();
            this.Btn_Error = new System.Windows.Forms.Button();
            this.GBSource = new System.Windows.Forms.GroupBox();
            this.RBsource_AC = new System.Windows.Forms.RadioButton();
            this.RBsource_DC = new System.Windows.Forms.RadioButton();
            this.GBMeas = new System.Windows.Forms.GroupBox();
            this.RBcurrent = new System.Windows.Forms.RadioButton();
            this.RBvoltage = new System.Windows.Forms.RadioButton();
            this.CBrange = new System.Windows.Forms.ComboBox();
            this.STriggerlabel = new System.Windows.Forms.Label();
            this.CBtrigger = new System.Windows.Forms.ComboBox();
            this.rangelabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GBreport.SuspendLayout();
            this.GBmotorport.SuspendLayout();
            this.GBSource.SuspendLayout();
            this.GBMeas.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTop
            // 
            this.labelTop.Font = new System.Drawing.Font("Cascadia Mono", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.ForeColor = System.Drawing.Color.White;
            this.labelTop.Location = new System.Drawing.Point(15, 7);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(249, 42);
            this.labelTop.TabIndex = 0;
            this.labelTop.Text = "Axis Control";
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Cascadia Mono Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.ForeColor = System.Drawing.Color.White;
            this.labeltitle.Location = new System.Drawing.Point(18, 42);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(154, 21);
            this.labeltitle.TabIndex = 1;
            this.labeltitle.Text = "Chuo Seiki MMC-2";
            // 
            // Btn_stopmotor
            // 
            this.Btn_stopmotor.FlatAppearance.BorderSize = 3;
            this.Btn_stopmotor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_stopmotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_stopmotor.ForeColor = System.Drawing.Color.Red;
            this.Btn_stopmotor.Location = new System.Drawing.Point(22, 281);
            this.Btn_stopmotor.Name = "Btn_stopmotor";
            this.Btn_stopmotor.Size = new System.Drawing.Size(86, 41);
            this.Btn_stopmotor.TabIndex = 9;
            this.Btn_stopmotor.Text = "Stop";
            this.Btn_stopmotor.UseVisualStyleBackColor = true;
            this.Btn_stopmotor.Click += new System.EventHandler(this.Btn_stopmotor_Click);
            // 
            // Btn_XRight
            // 
            this.Btn_XRight.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_XRight.ForeColor = System.Drawing.Color.Black;
            this.Btn_XRight.Location = new System.Drawing.Point(215, 224);
            this.Btn_XRight.Name = "Btn_XRight";
            this.Btn_XRight.Size = new System.Drawing.Size(86, 51);
            this.Btn_XRight.TabIndex = 8;
            this.Btn_XRight.Text = "X-";
            this.Btn_XRight.UseVisualStyleBackColor = true;
            this.Btn_XRight.Click += new System.EventHandler(this.Btn_XRight_Click);
            // 
            // Btn_XLeft
            // 
            this.Btn_XLeft.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_XLeft.ForeColor = System.Drawing.Color.Black;
            this.Btn_XLeft.Location = new System.Drawing.Point(22, 224);
            this.Btn_XLeft.Name = "Btn_XLeft";
            this.Btn_XLeft.Size = new System.Drawing.Size(86, 51);
            this.Btn_XLeft.TabIndex = 7;
            this.Btn_XLeft.Text = "X+";
            this.Btn_XLeft.UseVisualStyleBackColor = true;
            this.Btn_XLeft.Click += new System.EventHandler(this.Btn_XLeft_Click);
            // 
            // Btn_YDown
            // 
            this.Btn_YDown.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_YDown.ForeColor = System.Drawing.Color.Black;
            this.Btn_YDown.Location = new System.Drawing.Point(113, 281);
            this.Btn_YDown.Name = "Btn_YDown";
            this.Btn_YDown.Size = new System.Drawing.Size(95, 41);
            this.Btn_YDown.TabIndex = 6;
            this.Btn_YDown.Text = "Y -\r\n";
            this.Btn_YDown.UseVisualStyleBackColor = true;
            this.Btn_YDown.Click += new System.EventHandler(this.Btn_YDown_Click);
            // 
            // Btn_YUp
            // 
            this.Btn_YUp.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_YUp.ForeColor = System.Drawing.Color.Black;
            this.Btn_YUp.Location = new System.Drawing.Point(113, 177);
            this.Btn_YUp.Name = "Btn_YUp";
            this.Btn_YUp.Size = new System.Drawing.Size(96, 41);
            this.Btn_YUp.TabIndex = 5;
            this.Btn_YUp.Text = "Y +";
            this.Btn_YUp.UseVisualStyleBackColor = true;
            this.Btn_YUp.Click += new System.EventHandler(this.Btn_YUp_Click);
            // 
            // CblStepMotor
            // 
            this.CblStepMotor.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CblStepMotor.FormattingEnabled = true;
            this.CblStepMotor.Location = new System.Drawing.Point(204, 146);
            this.CblStepMotor.Name = "CblStepMotor";
            this.CblStepMotor.Size = new System.Drawing.Size(106, 28);
            this.CblStepMotor.TabIndex = 4;
            // 
            // labelstep
            // 
            this.labelstep.AutoSize = true;
            this.labelstep.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstep.ForeColor = System.Drawing.Color.White;
            this.labelstep.Location = new System.Drawing.Point(134, 148);
            this.labelstep.Name = "labelstep";
            this.labelstep.Size = new System.Drawing.Size(64, 21);
            this.labelstep.TabIndex = 3;
            this.labelstep.Text = "Step :";
            // 
            // Btn_ResetHome
            // 
            this.Btn_ResetHome.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ResetHome.ForeColor = System.Drawing.Color.Black;
            this.Btn_ResetHome.Location = new System.Drawing.Point(113, 224);
            this.Btn_ResetHome.Name = "Btn_ResetHome";
            this.Btn_ResetHome.Size = new System.Drawing.Size(96, 51);
            this.Btn_ResetHome.TabIndex = 2;
            this.Btn_ResetHome.Text = "Return to Origin";
            this.Btn_ResetHome.UseVisualStyleBackColor = true;
            this.Btn_ResetHome.Click += new System.EventHandler(this.Btn_ResetHome_Click);
            // 
            // labelUnit2
            // 
            this.labelUnit2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUnit2.AutoSize = true;
            this.labelUnit2.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnit2.ForeColor = System.Drawing.Color.White;
            this.labelUnit2.Location = new System.Drawing.Point(242, 431);
            this.labelUnit2.Name = "labelUnit2";
            this.labelUnit2.Size = new System.Drawing.Size(36, 28);
            this.labelUnit2.TabIndex = 21;
            this.labelUnit2.Text = "mm";
            // 
            // labelUnit1
            // 
            this.labelUnit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUnit1.AutoSize = true;
            this.labelUnit1.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnit1.ForeColor = System.Drawing.Color.White;
            this.labelUnit1.Location = new System.Drawing.Point(242, 394);
            this.labelUnit1.Name = "labelUnit1";
            this.labelUnit1.Size = new System.Drawing.Size(36, 28);
            this.labelUnit1.TabIndex = 20;
            this.labelUnit1.Text = "mm";
            // 
            // AxisScanYlabal
            // 
            this.AxisScanYlabal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AxisScanYlabal.AutoSize = true;
            this.AxisScanYlabal.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AxisScanYlabal.ForeColor = System.Drawing.Color.White;
            this.AxisScanYlabal.Location = new System.Drawing.Point(19, 431);
            this.AxisScanYlabal.Name = "AxisScanYlabal";
            this.AxisScanYlabal.Size = new System.Drawing.Size(82, 21);
            this.AxisScanYlabal.TabIndex = 17;
            this.AxisScanYlabal.Text = "Axis Y :";
            // 
            // AxisScanXlabal
            // 
            this.AxisScanXlabal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AxisScanXlabal.AutoSize = true;
            this.AxisScanXlabal.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AxisScanXlabal.ForeColor = System.Drawing.Color.White;
            this.AxisScanXlabal.Location = new System.Drawing.Point(19, 398);
            this.AxisScanXlabal.Name = "AxisScanXlabal";
            this.AxisScanXlabal.Size = new System.Drawing.Size(82, 21);
            this.AxisScanXlabal.TabIndex = 16;
            this.AxisScanXlabal.Text = "Axis X :";
            // 
            // Sublabel1
            // 
            this.Sublabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sublabel1.AutoSize = true;
            this.Sublabel1.Font = new System.Drawing.Font("Cascadia Mono Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sublabel1.ForeColor = System.Drawing.Color.White;
            this.Sublabel1.Location = new System.Drawing.Point(19, 365);
            this.Sublabel1.Name = "Sublabel1";
            this.Sublabel1.Size = new System.Drawing.Size(181, 21);
            this.Sublabel1.TabIndex = 15;
            this.Sublabel1.Text = "Total Scanning Area";
            // 
            // Sublabel2
            // 
            this.Sublabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sublabel2.AutoSize = true;
            this.Sublabel2.Font = new System.Drawing.Font("Cascadia Mono Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sublabel2.ForeColor = System.Drawing.Color.White;
            this.Sublabel2.Location = new System.Drawing.Point(19, 475);
            this.Sublabel2.Name = "Sublabel2";
            this.Sublabel2.Size = new System.Drawing.Size(226, 21);
            this.Sublabel2.TabIndex = 14;
            this.Sublabel2.Text = "Resolution Scanning Area";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(281, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Unit";
            // 
            // label_timerunit
            // 
            this.label_timerunit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_timerunit.AutoSize = true;
            this.label_timerunit.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timerunit.ForeColor = System.Drawing.Color.White;
            this.label_timerunit.Location = new System.Drawing.Point(255, 596);
            this.label_timerunit.Name = "label_timerunit";
            this.label_timerunit.Size = new System.Drawing.Size(28, 21);
            this.label_timerunit.TabIndex = 11;
            this.label_timerunit.Text = "ms";
            // 
            // Cbltimer
            // 
            this.Cbltimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cbltimer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbltimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbltimer.FormattingEnabled = true;
            this.Cbltimer.Location = new System.Drawing.Point(144, 594);
            this.Cbltimer.Name = "Cbltimer";
            this.Cbltimer.Size = new System.Drawing.Size(101, 28);
            this.Cbltimer.TabIndex = 10;
            // 
            // labelDelay
            // 
            this.labelDelay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDelay.AutoSize = true;
            this.labelDelay.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelay.ForeColor = System.Drawing.Color.White;
            this.labelDelay.Location = new System.Drawing.Point(19, 594);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(127, 21);
            this.labelDelay.TabIndex = 9;
            this.labelDelay.Text = "Delay Step : ";
            // 
            // Motortype2
            // 
            this.Motortype2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Motortype2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Motortype2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Motortype2.FormattingEnabled = true;
            this.Motortype2.Location = new System.Drawing.Point(247, 552);
            this.Motortype2.Name = "Motortype2";
            this.Motortype2.Size = new System.Drawing.Size(74, 33);
            this.Motortype2.TabIndex = 8;
            // 
            // Motortype
            // 
            this.Motortype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Motortype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Motortype.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Motortype.FormattingEnabled = true;
            this.Motortype.Location = new System.Drawing.Point(247, 514);
            this.Motortype.Name = "Motortype";
            this.Motortype.Size = new System.Drawing.Size(74, 33);
            this.Motortype.TabIndex = 7;
            // 
            // TxtstepY
            // 
            this.TxtstepY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtstepY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtstepY.Location = new System.Drawing.Point(104, 552);
            this.TxtstepY.Multiline = true;
            this.TxtstepY.Name = "TxtstepY";
            this.TxtstepY.Size = new System.Drawing.Size(132, 33);
            this.TxtstepY.TabIndex = 6;
            this.TxtstepY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtstepX
            // 
            this.TxtstepX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtstepX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtstepX.Location = new System.Drawing.Point(104, 514);
            this.TxtstepX.Multiline = true;
            this.TxtstepX.Name = "TxtstepX";
            this.TxtstepX.Size = new System.Drawing.Size(132, 32);
            this.TxtstepX.TabIndex = 5;
            this.TxtstepX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 552);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Step Y : ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Step X : ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Scanning";
            // 
            // Btn_runscaning
            // 
            this.Btn_runscaning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_runscaning.FlatAppearance.BorderSize = 2;
            this.Btn_runscaning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_runscaning.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_runscaning.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_runscaning.Location = new System.Drawing.Point(351, 757);
            this.Btn_runscaning.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_runscaning.Name = "Btn_runscaning";
            this.Btn_runscaning.Size = new System.Drawing.Size(187, 48);
            this.Btn_runscaning.TabIndex = 13;
            this.Btn_runscaning.Text = "RUN";
            this.Btn_runscaning.UseVisualStyleBackColor = true;
            this.Btn_runscaning.Click += new System.EventHandler(this.Btn_runscaning_Click);
            // 
            // Reportdata
            // 
            this.Reportdata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Reportdata.BackColor = System.Drawing.Color.Black;
            this.Reportdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Reportdata.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportdata.ForeColor = System.Drawing.Color.White;
            this.Reportdata.Location = new System.Drawing.Point(3, 22);
            this.Reportdata.Multiline = true;
            this.Reportdata.Name = "Reportdata";
            this.Reportdata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Reportdata.Size = new System.Drawing.Size(296, 147);
            this.Reportdata.TabIndex = 24;
            // 
            // GBreport
            // 
            this.GBreport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GBreport.Controls.Add(this.Reportdata);
            this.GBreport.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBreport.ForeColor = System.Drawing.Color.White;
            this.GBreport.Location = new System.Drawing.Point(22, 630);
            this.GBreport.Name = "GBreport";
            this.GBreport.Size = new System.Drawing.Size(302, 175);
            this.GBreport.TabIndex = 26;
            this.GBreport.TabStop = false;
            this.GBreport.Text = "Report loop Count ";
            // 
            // TbAreaX
            // 
            this.TbAreaX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAreaX.Location = new System.Drawing.Point(104, 394);
            this.TbAreaX.Multiline = true;
            this.TbAreaX.Name = "TbAreaX";
            this.TbAreaX.Size = new System.Drawing.Size(132, 31);
            this.TbAreaX.TabIndex = 27;
            this.TbAreaX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TbAreaY
            // 
            this.TbAreaY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAreaY.Location = new System.Drawing.Point(104, 431);
            this.TbAreaY.Multiline = true;
            this.TbAreaY.Name = "TbAreaY";
            this.TbAreaY.Size = new System.Drawing.Size(132, 28);
            this.TbAreaY.TabIndex = 28;
            this.TbAreaY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GBmotorport
            // 
            this.GBmotorport.Controls.Add(this.RB_rs232);
            this.GBmotorport.Controls.Add(this.RB_gpib);
            this.GBmotorport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBmotorport.Font = new System.Drawing.Font("Cascadia Code Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBmotorport.ForeColor = System.Drawing.Color.White;
            this.GBmotorport.Location = new System.Drawing.Point(22, 71);
            this.GBmotorport.Name = "GBmotorport";
            this.GBmotorport.Size = new System.Drawing.Size(288, 69);
            this.GBmotorport.TabIndex = 29;
            this.GBmotorport.TabStop = false;
            this.GBmotorport.Text = "Port Controlles";
            // 
            // RB_rs232
            // 
            this.RB_rs232.Appearance = System.Windows.Forms.Appearance.Button;
            this.RB_rs232.BackColor = System.Drawing.Color.LightGray;
            this.RB_rs232.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.RB_rs232.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RB_rs232.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_rs232.ForeColor = System.Drawing.Color.Black;
            this.RB_rs232.Location = new System.Drawing.Point(141, 22);
            this.RB_rs232.Name = "RB_rs232";
            this.RB_rs232.Size = new System.Drawing.Size(141, 36);
            this.RB_rs232.TabIndex = 31;
            this.RB_rs232.TabStop = true;
            this.RB_rs232.Text = "RS-232";
            this.RB_rs232.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RB_rs232.UseVisualStyleBackColor = false;
            // 
            // RB_gpib
            // 
            this.RB_gpib.Appearance = System.Windows.Forms.Appearance.Button;
            this.RB_gpib.BackColor = System.Drawing.Color.LightGray;
            this.RB_gpib.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkViolet;
            this.RB_gpib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RB_gpib.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_gpib.ForeColor = System.Drawing.Color.Black;
            this.RB_gpib.Location = new System.Drawing.Point(6, 22);
            this.RB_gpib.Name = "RB_gpib";
            this.RB_gpib.Size = new System.Drawing.Size(144, 36);
            this.RB_gpib.TabIndex = 30;
            this.RB_gpib.TabStop = true;
            this.RB_gpib.Text = "GP-IB";
            this.RB_gpib.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RB_gpib.UseVisualStyleBackColor = false;
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reset.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reset.ForeColor = System.Drawing.Color.White;
            this.Btn_Reset.Location = new System.Drawing.Point(357, 632);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(142, 62);
            this.Btn_Reset.TabIndex = 47;
            this.Btn_Reset.Text = "Reset\r\nMeasurement\r\n";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            // 
            // Btn_clear
            // 
            this.Btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_clear.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_clear.ForeColor = System.Drawing.Color.White;
            this.Btn_clear.Location = new System.Drawing.Point(505, 631);
            this.Btn_clear.Name = "Btn_clear";
            this.Btn_clear.Size = new System.Drawing.Size(142, 62);
            this.Btn_clear.TabIndex = 46;
            this.Btn_clear.Text = "Clear ERROR";
            this.Btn_clear.UseVisualStyleBackColor = true;
            // 
            // Btn_read
            // 
            this.Btn_read.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_read.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Btn_read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_read.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_read.ForeColor = System.Drawing.Color.White;
            this.Btn_read.Location = new System.Drawing.Point(357, 700);
            this.Btn_read.Name = "Btn_read";
            this.Btn_read.Size = new System.Drawing.Size(142, 43);
            this.Btn_read.TabIndex = 45;
            this.Btn_read.Text = "READ?";
            this.Btn_read.UseVisualStyleBackColor = true;
            // 
            // Btn_Error
            // 
            this.Btn_Error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Error.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Btn_Error.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Error.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Error.ForeColor = System.Drawing.Color.White;
            this.Btn_Error.Location = new System.Drawing.Point(505, 702);
            this.Btn_Error.Name = "Btn_Error";
            this.Btn_Error.Size = new System.Drawing.Size(142, 43);
            this.Btn_Error.TabIndex = 44;
            this.Btn_Error.Text = "Check ERROR";
            this.Btn_Error.UseVisualStyleBackColor = true;
            // 
            // GBSource
            // 
            this.GBSource.Controls.Add(this.RBsource_AC);
            this.GBSource.Controls.Add(this.RBsource_DC);
            this.GBSource.Font = new System.Drawing.Font("Cascadia Code Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBSource.ForeColor = System.Drawing.Color.White;
            this.GBSource.Location = new System.Drawing.Point(357, 190);
            this.GBSource.Name = "GBSource";
            this.GBSource.Size = new System.Drawing.Size(296, 81);
            this.GBSource.TabIndex = 42;
            this.GBSource.TabStop = false;
            this.GBSource.Text = "Source";
            // 
            // RBsource_AC
            // 
            this.RBsource_AC.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBsource_AC.BackColor = System.Drawing.Color.LightGray;
            this.RBsource_AC.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RBsource_AC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBsource_AC.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBsource_AC.ForeColor = System.Drawing.Color.Black;
            this.RBsource_AC.Location = new System.Drawing.Point(144, 22);
            this.RBsource_AC.Name = "RBsource_AC";
            this.RBsource_AC.Size = new System.Drawing.Size(142, 44);
            this.RBsource_AC.TabIndex = 13;
            this.RBsource_AC.TabStop = true;
            this.RBsource_AC.Text = "AC";
            this.RBsource_AC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBsource_AC.UseVisualStyleBackColor = false;
            // 
            // RBsource_DC
            // 
            this.RBsource_DC.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBsource_DC.BackColor = System.Drawing.Color.LightGray;
            this.RBsource_DC.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RBsource_DC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBsource_DC.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBsource_DC.ForeColor = System.Drawing.Color.Black;
            this.RBsource_DC.Location = new System.Drawing.Point(12, 22);
            this.RBsource_DC.Name = "RBsource_DC";
            this.RBsource_DC.Size = new System.Drawing.Size(138, 44);
            this.RBsource_DC.TabIndex = 12;
            this.RBsource_DC.TabStop = true;
            this.RBsource_DC.Text = "DC";
            this.RBsource_DC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBsource_DC.UseVisualStyleBackColor = false;
            // 
            // GBMeas
            // 
            this.GBMeas.Controls.Add(this.RBcurrent);
            this.GBMeas.Controls.Add(this.RBvoltage);
            this.GBMeas.Font = new System.Drawing.Font("Cascadia Code Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBMeas.ForeColor = System.Drawing.Color.White;
            this.GBMeas.Location = new System.Drawing.Point(357, 103);
            this.GBMeas.Name = "GBMeas";
            this.GBMeas.Size = new System.Drawing.Size(296, 81);
            this.GBMeas.TabIndex = 41;
            this.GBMeas.TabStop = false;
            this.GBMeas.Text = "Measurement";
            // 
            // RBcurrent
            // 
            this.RBcurrent.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBcurrent.BackColor = System.Drawing.Color.LightGray;
            this.RBcurrent.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.RBcurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBcurrent.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBcurrent.ForeColor = System.Drawing.Color.Black;
            this.RBcurrent.Location = new System.Drawing.Point(148, 22);
            this.RBcurrent.Name = "RBcurrent";
            this.RBcurrent.Size = new System.Drawing.Size(142, 44);
            this.RBcurrent.TabIndex = 13;
            this.RBcurrent.TabStop = true;
            this.RBcurrent.Text = "Current";
            this.RBcurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBcurrent.UseVisualStyleBackColor = false;
            // 
            // RBvoltage
            // 
            this.RBvoltage.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBvoltage.BackColor = System.Drawing.Color.LightGray;
            this.RBvoltage.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.RBvoltage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBvoltage.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBvoltage.ForeColor = System.Drawing.Color.Black;
            this.RBvoltage.Location = new System.Drawing.Point(12, 22);
            this.RBvoltage.Name = "RBvoltage";
            this.RBvoltage.Size = new System.Drawing.Size(142, 44);
            this.RBvoltage.TabIndex = 12;
            this.RBvoltage.TabStop = true;
            this.RBvoltage.Text = "Voltage";
            this.RBvoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBvoltage.UseVisualStyleBackColor = false;
            // 
            // CBrange
            // 
            this.CBrange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBrange.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBrange.FormattingEnabled = true;
            this.CBrange.Location = new System.Drawing.Point(471, 286);
            this.CBrange.Name = "CBrange";
            this.CBrange.Size = new System.Drawing.Size(155, 36);
            this.CBrange.TabIndex = 37;
            // 
            // STriggerlabel
            // 
            this.STriggerlabel.AutoSize = true;
            this.STriggerlabel.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STriggerlabel.ForeColor = System.Drawing.Color.White;
            this.STriggerlabel.Location = new System.Drawing.Point(374, 325);
            this.STriggerlabel.Name = "STriggerlabel";
            this.STriggerlabel.Size = new System.Drawing.Size(91, 42);
            this.STriggerlabel.TabIndex = 36;
            this.STriggerlabel.Text = "Source \r\nTrigger :";
            // 
            // CBtrigger
            // 
            this.CBtrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBtrigger.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBtrigger.FormattingEnabled = true;
            this.CBtrigger.Location = new System.Drawing.Point(471, 331);
            this.CBtrigger.Name = "CBtrigger";
            this.CBtrigger.Size = new System.Drawing.Size(155, 36);
            this.CBtrigger.TabIndex = 35;
            // 
            // rangelabel
            // 
            this.rangelabel.AutoSize = true;
            this.rangelabel.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangelabel.ForeColor = System.Drawing.Color.White;
            this.rangelabel.Location = new System.Drawing.Point(392, 295);
            this.rangelabel.Name = "rangelabel";
            this.rangelabel.Size = new System.Drawing.Size(73, 21);
            this.rangelabel.TabIndex = 34;
            this.rangelabel.Text = "Range :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(353, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 42);
            this.label5.TabIndex = 33;
            this.label5.Text = "Agilent 34401A\r\nDigit Multimeter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(351, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 35);
            this.label6.TabIndex = 32;
            this.label6.Text = "Measurement";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(544, 757);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 48);
            this.button1.TabIndex = 48;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AxisControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_runscaning);
            this.Controls.Add(this.labeltitle);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.GBmotorport);
            this.Controls.Add(this.Btn_clear);
            this.Controls.Add(this.TbAreaY);
            this.Controls.Add(this.Btn_read);
            this.Controls.Add(this.TbAreaX);
            this.Controls.Add(this.Btn_Error);
            this.Controls.Add(this.GBreport);
            this.Controls.Add(this.Cbltimer);
            this.Controls.Add(this.GBSource);
            this.Controls.Add(this.labelDelay);
            this.Controls.Add(this.GBMeas);
            this.Controls.Add(this.label_timerunit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelUnit2);
            this.Controls.Add(this.Motortype2);
            this.Controls.Add(this.CBrange);
            this.Controls.Add(this.STriggerlabel);
            this.Controls.Add(this.labelUnit1);
            this.Controls.Add(this.CBtrigger);
            this.Controls.Add(this.Motortype);
            this.Controls.Add(this.rangelabel);
            this.Controls.Add(this.Sublabel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AxisScanYlabal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AxisScanXlabal);
            this.Controls.Add(this.TxtstepY);
            this.Controls.Add(this.TxtstepX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sublabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_XRight);
            this.Controls.Add(this.Btn_stopmotor);
            this.Controls.Add(this.Btn_YDown);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.Btn_XLeft);
            this.Controls.Add(this.Btn_ResetHome);
            this.Controls.Add(this.labelstep);
            this.Controls.Add(this.CblStepMotor);
            this.Controls.Add(this.Btn_YUp);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AxisControl";
            this.Size = new System.Drawing.Size(680, 815);
            this.GBreport.ResumeLayout(false);
            this.GBreport.PerformLayout();
            this.GBmotorport.ResumeLayout(false);
            this.GBSource.ResumeLayout(false);
            this.GBMeas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_ResetHome;
        private System.Windows.Forms.ComboBox CblStepMotor;
        private System.Windows.Forms.Label labelstep;
        private System.Windows.Forms.Button Btn_YUp;
        private System.Windows.Forms.Button Btn_XRight;
        private System.Windows.Forms.Button Btn_XLeft;
        private System.Windows.Forms.Button Btn_YDown;
        private System.Windows.Forms.Button Btn_stopmotor;
        private System.Windows.Forms.TextBox TxtstepY;
        private System.Windows.Forms.TextBox TxtstepX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Motortype2;
        private System.Windows.Forms.ComboBox Motortype;
        private System.Windows.Forms.ComboBox Cbltimer;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_timerunit;
        private System.Windows.Forms.Button Btn_runscaning;
        private System.Windows.Forms.Label Sublabel2;
        private System.Windows.Forms.Label Sublabel1;
        private System.Windows.Forms.Label AxisScanYlabal;
        private System.Windows.Forms.Label AxisScanXlabal;
        private System.Windows.Forms.Label labelUnit1;
        private System.Windows.Forms.Label labelUnit2;
        private System.Windows.Forms.TextBox Reportdata;
        private System.Windows.Forms.GroupBox GBreport;
        private System.Windows.Forms.TextBox TbAreaX;
        private System.Windows.Forms.TextBox TbAreaY;
        private System.Windows.Forms.GroupBox GBmotorport;
        private System.Windows.Forms.RadioButton RB_gpib;
        private System.Windows.Forms.RadioButton RB_rs232;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Button Btn_clear;
        private System.Windows.Forms.Button Btn_read;
        private System.Windows.Forms.Button Btn_Error;
        private System.Windows.Forms.GroupBox GBSource;
        private System.Windows.Forms.RadioButton RBsource_AC;
        private System.Windows.Forms.RadioButton RBsource_DC;
        private System.Windows.Forms.GroupBox GBMeas;
        private System.Windows.Forms.RadioButton RBcurrent;
        private System.Windows.Forms.RadioButton RBvoltage;
        private System.Windows.Forms.ComboBox CBrange;
        private System.Windows.Forms.Label STriggerlabel;
        private System.Windows.Forms.ComboBox CBtrigger;
        private System.Windows.Forms.Label rangelabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}
