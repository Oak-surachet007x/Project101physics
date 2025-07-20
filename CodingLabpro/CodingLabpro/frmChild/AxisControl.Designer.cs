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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label totalAreaXLabel;
            System.Windows.Forms.Label totalAreaYLabel;
            System.Windows.Forms.Label moveStepYLabel;
            System.Windows.Forms.Label moveStepXLabel;
            System.Windows.Forms.Label delaySteppingLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AxisControl));
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
            this.Sublabel1 = new System.Windows.Forms.Label();
            this.Sublabel2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_timerunit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_runscaning = new System.Windows.Forms.Button();
            this.Reportdata = new System.Windows.Forms.TextBox();
            this.GBreport = new System.Windows.Forms.GroupBox();
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCancel_scaning = new System.Windows.Forms.Button();
            this.CBtrigger = new System.Windows.Forms.ComboBox();
            this.STriggerlabel = new System.Windows.Forms.Label();
            this.GBautozero = new System.Windows.Forms.GroupBox();
            this.RB_autoOnce = new System.Windows.Forms.RadioButton();
            this.RB_autoON = new System.Windows.Forms.RadioButton();
            this.RB_autoOFF = new System.Windows.Forms.RadioButton();
            this.totalAreaXTextBox = new System.Windows.Forms.TextBox();
            this.totalAreaYTextBox = new System.Windows.Forms.TextBox();
            this.moveStepYTextBox = new System.Windows.Forms.TextBox();
            this.moveStepXTextBox = new System.Windows.Forms.TextBox();
            this.unitXComboBox = new System.Windows.Forms.ComboBox();
            this.unitYComboBox = new System.Windows.Forms.ComboBox();
            this.delaySteppingComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Numeric_Range = new System.Windows.Forms.NumericUpDown();
            this.Numeric_Resolution = new System.Windows.Forms.NumericUpDown();
            this.GBResolution = new System.Windows.Forms.GroupBox();
            this.RB_resolution6digits = new System.Windows.Forms.RadioButton();
            this.RB_resolutionCustom = new System.Windows.Forms.RadioButton();
            this.RB_resolution4digits = new System.Windows.Forms.RadioButton();
            this.RB_resolutionAuto = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_autorange = new System.Windows.Forms.RadioButton();
            this.RB_Customrange = new System.Windows.Forms.RadioButton();
            this.CBrange = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InputValue_area = new System.Windows.Forms.BindingSource(this.components);
            totalAreaXLabel = new System.Windows.Forms.Label();
            totalAreaYLabel = new System.Windows.Forms.Label();
            moveStepYLabel = new System.Windows.Forms.Label();
            moveStepXLabel = new System.Windows.Forms.Label();
            delaySteppingLabel = new System.Windows.Forms.Label();
            this.GBreport.SuspendLayout();
            this.GBmotorport.SuspendLayout();
            this.GBSource.SuspendLayout();
            this.GBMeas.SuspendLayout();
            this.GBautozero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Range)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Resolution)).BeginInit();
            this.GBResolution.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputValue_area)).BeginInit();
            this.SuspendLayout();
            // 
            // totalAreaXLabel
            // 
            totalAreaXLabel.AutoSize = true;
            totalAreaXLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            totalAreaXLabel.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalAreaXLabel.ForeColor = System.Drawing.Color.White;
            totalAreaXLabel.Location = new System.Drawing.Point(21, 396);
            totalAreaXLabel.Name = "totalAreaXLabel";
            totalAreaXLabel.Size = new System.Drawing.Size(73, 21);
            totalAreaXLabel.TabIndex = 49;
            totalAreaXLabel.Text = "Area X:";
            // 
            // totalAreaYLabel
            // 
            totalAreaYLabel.AutoSize = true;
            totalAreaYLabel.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalAreaYLabel.ForeColor = System.Drawing.Color.White;
            totalAreaYLabel.Location = new System.Drawing.Point(21, 430);
            totalAreaYLabel.Name = "totalAreaYLabel";
            totalAreaYLabel.Size = new System.Drawing.Size(73, 21);
            totalAreaYLabel.TabIndex = 50;
            totalAreaYLabel.Text = "Area Y:";
            // 
            // moveStepYLabel
            // 
            moveStepYLabel.AutoSize = true;
            moveStepYLabel.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            moveStepYLabel.ForeColor = System.Drawing.Color.White;
            moveStepYLabel.Location = new System.Drawing.Point(21, 534);
            moveStepYLabel.Name = "moveStepYLabel";
            moveStepYLabel.Size = new System.Drawing.Size(73, 21);
            moveStepYLabel.TabIndex = 51;
            moveStepYLabel.Text = "Step Y:";
            // 
            // moveStepXLabel
            // 
            moveStepXLabel.AutoSize = true;
            moveStepXLabel.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            moveStepXLabel.ForeColor = System.Drawing.Color.White;
            moveStepXLabel.Location = new System.Drawing.Point(21, 502);
            moveStepXLabel.Name = "moveStepXLabel";
            moveStepXLabel.Size = new System.Drawing.Size(73, 21);
            moveStepXLabel.TabIndex = 52;
            moveStepXLabel.Text = "Step X:";
            // 
            // delaySteppingLabel
            // 
            delaySteppingLabel.AutoSize = true;
            delaySteppingLabel.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            delaySteppingLabel.ForeColor = System.Drawing.Color.White;
            delaySteppingLabel.Location = new System.Drawing.Point(19, 567);
            delaySteppingLabel.Name = "delaySteppingLabel";
            delaySteppingLabel.Size = new System.Drawing.Size(109, 21);
            delaySteppingLabel.TabIndex = 55;
            delaySteppingLabel.Text = "Delay Step:";
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
            this.labelUnit2.AutoSize = true;
            this.labelUnit2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnit2.ForeColor = System.Drawing.Color.White;
            this.labelUnit2.Location = new System.Drawing.Point(242, 430);
            this.labelUnit2.Name = "labelUnit2";
            this.labelUnit2.Size = new System.Drawing.Size(28, 21);
            this.labelUnit2.TabIndex = 21;
            this.labelUnit2.Text = "mm";
            // 
            // labelUnit1
            // 
            this.labelUnit1.AutoSize = true;
            this.labelUnit1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnit1.ForeColor = System.Drawing.Color.White;
            this.labelUnit1.Location = new System.Drawing.Point(242, 396);
            this.labelUnit1.Name = "labelUnit1";
            this.labelUnit1.Size = new System.Drawing.Size(28, 21);
            this.labelUnit1.TabIndex = 20;
            this.labelUnit1.Text = "mm";
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
            this.Sublabel2.AutoSize = true;
            this.Sublabel2.Font = new System.Drawing.Font("Cascadia Mono Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sublabel2.ForeColor = System.Drawing.Color.White;
            this.Sublabel2.Location = new System.Drawing.Point(19, 468);
            this.Sublabel2.Name = "Sublabel2";
            this.Sublabel2.Size = new System.Drawing.Size(226, 21);
            this.Sublabel2.TabIndex = 14;
            this.Sublabel2.Text = "Resolution Scanning Area";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(281, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Unit";
            // 
            // label_timerunit
            // 
            this.label_timerunit.AutoSize = true;
            this.label_timerunit.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timerunit.ForeColor = System.Drawing.Color.White;
            this.label_timerunit.Location = new System.Drawing.Point(276, 567);
            this.label_timerunit.Name = "label_timerunit";
            this.label_timerunit.Size = new System.Drawing.Size(28, 21);
            this.label_timerunit.TabIndex = 11;
            this.label_timerunit.Text = "ms";
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
            this.Btn_runscaning.Location = new System.Drawing.Point(350, 751);
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
            this.Reportdata.Size = new System.Drawing.Size(296, 165);
            this.Reportdata.TabIndex = 24;
            // 
            // GBreport
            // 
            this.GBreport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GBreport.Controls.Add(this.Reportdata);
            this.GBreport.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBreport.ForeColor = System.Drawing.Color.White;
            this.GBreport.Location = new System.Drawing.Point(22, 612);
            this.GBreport.Name = "GBreport";
            this.GBreport.Size = new System.Drawing.Size(302, 193);
            this.GBreport.TabIndex = 26;
            this.GBreport.TabStop = false;
            this.GBreport.Text = "Report loop Count ";
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
            this.RB_rs232.CheckedChanged += new System.EventHandler(this.RB_rs232_CheckedChanged);
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
            this.RB_gpib.CheckedChanged += new System.EventHandler(this.RB_gpib_CheckedChanged);
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reset.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reset.ForeColor = System.Drawing.Color.White;
            this.Btn_Reset.Location = new System.Drawing.Point(356, 634);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(142, 54);
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
            this.Btn_clear.Location = new System.Drawing.Point(504, 634);
            this.Btn_clear.Name = "Btn_clear";
            this.Btn_clear.Size = new System.Drawing.Size(142, 53);
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
            this.Btn_read.Location = new System.Drawing.Point(356, 694);
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
            this.Btn_Error.Location = new System.Drawing.Point(504, 696);
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
            this.RBsource_AC.CheckedChanged += new System.EventHandler(this.RBsource_AC_CheckedChanged);
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
            this.RBsource_DC.CheckedChanged += new System.EventHandler(this.RBsource_DC_CheckedChanged);
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
            this.RBcurrent.CheckedChanged += new System.EventHandler(this.RBcurrent_CheckedChanged);
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
            this.RBvoltage.CheckedChanged += new System.EventHandler(this.RBvoltage_CheckedChanged);
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
            // BtnCancel_scaning
            // 
            this.BtnCancel_scaning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel_scaning.FlatAppearance.BorderSize = 3;
            this.BtnCancel_scaning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel_scaning.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel_scaning.ForeColor = System.Drawing.Color.Red;
            this.BtnCancel_scaning.Location = new System.Drawing.Point(543, 751);
            this.BtnCancel_scaning.Name = "BtnCancel_scaning";
            this.BtnCancel_scaning.Size = new System.Drawing.Size(119, 48);
            this.BtnCancel_scaning.TabIndex = 48;
            this.BtnCancel_scaning.Text = "Cancel";
            this.BtnCancel_scaning.UseVisualStyleBackColor = true;
            this.BtnCancel_scaning.Click += new System.EventHandler(this.BtnCancel_scaning_Click);
            // 
            // CBtrigger
            // 
            this.CBtrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBtrigger.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBtrigger.FormattingEnabled = true;
            this.CBtrigger.Location = new System.Drawing.Point(511, 487);
            this.CBtrigger.Name = "CBtrigger";
            this.CBtrigger.Size = new System.Drawing.Size(138, 36);
            this.CBtrigger.TabIndex = 35;
            this.CBtrigger.SelectedIndexChanged += new System.EventHandler(this.CBtrigger_SelectedIndexChanged);
            // 
            // STriggerlabel
            // 
            this.STriggerlabel.AutoSize = true;
            this.STriggerlabel.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STriggerlabel.ForeColor = System.Drawing.Color.White;
            this.STriggerlabel.Location = new System.Drawing.Point(352, 490);
            this.STriggerlabel.Name = "STriggerlabel";
            this.STriggerlabel.Size = new System.Drawing.Size(154, 21);
            this.STriggerlabel.TabIndex = 36;
            this.STriggerlabel.Text = "Source Trigger :";
            // 
            // GBautozero
            // 
            this.GBautozero.Controls.Add(this.RB_autoOnce);
            this.GBautozero.Controls.Add(this.RB_autoON);
            this.GBautozero.Controls.Add(this.RB_autoOFF);
            this.GBautozero.Font = new System.Drawing.Font("Cascadia Code Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBautozero.ForeColor = System.Drawing.Color.White;
            this.GBautozero.Location = new System.Drawing.Point(357, 531);
            this.GBautozero.Name = "GBautozero";
            this.GBautozero.Size = new System.Drawing.Size(103, 96);
            this.GBautozero.TabIndex = 49;
            this.GBautozero.TabStop = false;
            this.GBautozero.Text = "Auto Zero";
            // 
            // RB_autoOnce
            // 
            this.RB_autoOnce.AutoSize = true;
            this.RB_autoOnce.Location = new System.Drawing.Point(9, 62);
            this.RB_autoOnce.Name = "RB_autoOnce";
            this.RB_autoOnce.Size = new System.Drawing.Size(58, 21);
            this.RB_autoOnce.TabIndex = 2;
            this.RB_autoOnce.TabStop = true;
            this.RB_autoOnce.Text = "ONCE";
            this.RB_autoOnce.UseVisualStyleBackColor = true;
            this.RB_autoOnce.CheckedChanged += new System.EventHandler(this.RB_autoOnce_CheckedChanged);
            // 
            // RB_autoON
            // 
            this.RB_autoON.AutoSize = true;
            this.RB_autoON.Location = new System.Drawing.Point(9, 41);
            this.RB_autoON.Name = "RB_autoON";
            this.RB_autoON.Size = new System.Drawing.Size(42, 21);
            this.RB_autoON.TabIndex = 1;
            this.RB_autoON.TabStop = true;
            this.RB_autoON.Text = "ON";
            this.RB_autoON.UseVisualStyleBackColor = true;
            this.RB_autoON.CheckedChanged += new System.EventHandler(this.RB_autoON_CheckedChanged);
            // 
            // RB_autoOFF
            // 
            this.RB_autoOFF.AutoSize = true;
            this.RB_autoOFF.Location = new System.Drawing.Point(9, 20);
            this.RB_autoOFF.Name = "RB_autoOFF";
            this.RB_autoOFF.Size = new System.Drawing.Size(50, 21);
            this.RB_autoOFF.TabIndex = 0;
            this.RB_autoOFF.TabStop = true;
            this.RB_autoOFF.Text = "OFF";
            this.RB_autoOFF.UseVisualStyleBackColor = true;
            this.RB_autoOFF.CheckedChanged += new System.EventHandler(this.RB_autoOFF_CheckedChanged);
            // 
            // totalAreaXTextBox
            // 
            this.totalAreaXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InputValue_area, "TotalAreaX", true));
            this.totalAreaXTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAreaXTextBox.Location = new System.Drawing.Point(113, 397);
            this.totalAreaXTextBox.Name = "totalAreaXTextBox";
            this.totalAreaXTextBox.Size = new System.Drawing.Size(123, 29);
            this.totalAreaXTextBox.TabIndex = 50;
            this.totalAreaXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalAreaYTextBox
            // 
            this.totalAreaYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InputValue_area, "TotalAreaY", true));
            this.totalAreaYTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAreaYTextBox.Location = new System.Drawing.Point(113, 433);
            this.totalAreaYTextBox.Name = "totalAreaYTextBox";
            this.totalAreaYTextBox.Size = new System.Drawing.Size(123, 29);
            this.totalAreaYTextBox.TabIndex = 51;
            this.totalAreaYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // moveStepYTextBox
            // 
            this.moveStepYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InputValue_area, "MoveStepY", true));
            this.moveStepYTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveStepYTextBox.Location = new System.Drawing.Point(113, 533);
            this.moveStepYTextBox.Name = "moveStepYTextBox";
            this.moveStepYTextBox.Size = new System.Drawing.Size(123, 26);
            this.moveStepYTextBox.TabIndex = 52;
            this.moveStepYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // moveStepXTextBox
            // 
            this.moveStepXTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InputValue_area, "MoveStepX", true));
            this.moveStepXTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveStepXTextBox.Location = new System.Drawing.Point(113, 499);
            this.moveStepXTextBox.Name = "moveStepXTextBox";
            this.moveStepXTextBox.Size = new System.Drawing.Size(123, 26);
            this.moveStepXTextBox.TabIndex = 53;
            this.moveStepXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // unitXComboBox
            // 
            this.unitXComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InputValue_area, "UnitX", true));
            this.unitXComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitXComboBox.FormattingEnabled = true;
            this.unitXComboBox.Location = new System.Drawing.Point(246, 497);
            this.unitXComboBox.Name = "unitXComboBox";
            this.unitXComboBox.Size = new System.Drawing.Size(75, 28);
            this.unitXComboBox.TabIndex = 54;
            // 
            // unitYComboBox
            // 
            this.unitYComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InputValue_area, "UnitY", true));
            this.unitYComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitYComboBox.FormattingEnabled = true;
            this.unitYComboBox.Location = new System.Drawing.Point(246, 531);
            this.unitYComboBox.Name = "unitYComboBox";
            this.unitYComboBox.Size = new System.Drawing.Size(75, 28);
            this.unitYComboBox.TabIndex = 55;
            // 
            // delaySteppingComboBox
            // 
            this.delaySteppingComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InputValue_area, "DelayStepping", true));
            this.delaySteppingComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delaySteppingComboBox.FormattingEnabled = true;
            this.delaySteppingComboBox.Location = new System.Drawing.Point(138, 565);
            this.delaySteppingComboBox.Name = "delaySteppingComboBox";
            this.delaySteppingComboBox.Size = new System.Drawing.Size(132, 28);
            this.delaySteppingComboBox.TabIndex = 56;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.InputValue_area;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            this.errorProvider1.RightToLeft = true;
            // 
            // Numeric_Range
            // 
            this.Numeric_Range.DecimalPlaces = 2;
            this.Numeric_Range.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numeric_Range.Location = new System.Drawing.Point(8, 53);
            this.Numeric_Range.Name = "Numeric_Range";
            this.Numeric_Range.Size = new System.Drawing.Size(195, 29);
            this.Numeric_Range.TabIndex = 57;
            // 
            // Numeric_Resolution
            // 
            this.Numeric_Resolution.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Numeric_Resolution.DecimalPlaces = 5;
            this.Numeric_Resolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numeric_Resolution.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Numeric_Resolution.Location = new System.Drawing.Point(157, 49);
            this.Numeric_Resolution.Name = "Numeric_Resolution";
            this.Numeric_Resolution.Size = new System.Drawing.Size(128, 25);
            this.Numeric_Resolution.TabIndex = 59;
            // 
            // GBResolution
            // 
            this.GBResolution.Controls.Add(this.RB_resolution6digits);
            this.GBResolution.Controls.Add(this.RB_resolutionCustom);
            this.GBResolution.Controls.Add(this.RB_resolution4digits);
            this.GBResolution.Controls.Add(this.RB_resolutionAuto);
            this.GBResolution.Controls.Add(this.Numeric_Resolution);
            this.GBResolution.Font = new System.Drawing.Font("Cascadia Code Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBResolution.ForeColor = System.Drawing.Color.White;
            this.GBResolution.Location = new System.Drawing.Point(356, 383);
            this.GBResolution.Name = "GBResolution";
            this.GBResolution.Size = new System.Drawing.Size(297, 91);
            this.GBResolution.TabIndex = 61;
            this.GBResolution.TabStop = false;
            this.GBResolution.Text = "Resolution";
            // 
            // RB_resolution6digits
            // 
            this.RB_resolution6digits.AutoSize = true;
            this.RB_resolution6digits.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_resolution6digits.Location = new System.Drawing.Point(158, 26);
            this.RB_resolution6digits.Name = "RB_resolution6digits";
            this.RB_resolution6digits.Size = new System.Drawing.Size(69, 21);
            this.RB_resolution6digits.TabIndex = 64;
            this.RB_resolution6digits.TabStop = true;
            this.RB_resolution6digits.Text = "6 digits";
            this.RB_resolution6digits.UseVisualStyleBackColor = true;
            // 
            // RB_resolutionCustom
            // 
            this.RB_resolutionCustom.AutoSize = true;
            this.RB_resolutionCustom.Location = new System.Drawing.Point(72, 53);
            this.RB_resolutionCustom.Name = "RB_resolutionCustom";
            this.RB_resolutionCustom.Size = new System.Drawing.Size(74, 21);
            this.RB_resolutionCustom.TabIndex = 63;
            this.RB_resolutionCustom.TabStop = true;
            this.RB_resolutionCustom.Text = "Custom";
            this.RB_resolutionCustom.UseVisualStyleBackColor = true;
            this.RB_resolutionCustom.CheckedChanged += new System.EventHandler(this.RB_resolutionCustom_CheckedChanged);
            // 
            // RB_resolution4digits
            // 
            this.RB_resolution4digits.AutoSize = true;
            this.RB_resolution4digits.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_resolution4digits.Location = new System.Drawing.Point(72, 26);
            this.RB_resolution4digits.Name = "RB_resolution4digits";
            this.RB_resolution4digits.Size = new System.Drawing.Size(69, 21);
            this.RB_resolution4digits.TabIndex = 62;
            this.RB_resolution4digits.TabStop = true;
            this.RB_resolution4digits.Text = "4 digits";
            this.RB_resolution4digits.UseVisualStyleBackColor = true;
            // 
            // RB_resolutionAuto
            // 
            this.RB_resolutionAuto.AutoSize = true;
            this.RB_resolutionAuto.Location = new System.Drawing.Point(8, 26);
            this.RB_resolutionAuto.Name = "RB_resolutionAuto";
            this.RB_resolutionAuto.Size = new System.Drawing.Size(58, 21);
            this.RB_resolutionAuto.TabIndex = 61;
            this.RB_resolutionAuto.TabStop = true;
            this.RB_resolutionAuto.Text = "Auto";
            this.RB_resolutionAuto.UseVisualStyleBackColor = true;
            this.RB_resolutionAuto.CheckedChanged += new System.EventHandler(this.RB_resolutionAuto_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CBrange);
            this.groupBox1.Controls.Add(this.RB_Customrange);
            this.groupBox1.Controls.Add(this.RB_autorange);
            this.groupBox1.Controls.Add(this.Numeric_Range);
            this.groupBox1.Font = new System.Drawing.Font("Cascadia Code Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(356, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 96);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Range";
            // 
            // RB_autorange
            // 
            this.RB_autorange.AutoSize = true;
            this.RB_autorange.Location = new System.Drawing.Point(8, 23);
            this.RB_autorange.Name = "RB_autorange";
            this.RB_autorange.Size = new System.Drawing.Size(58, 21);
            this.RB_autorange.TabIndex = 58;
            this.RB_autorange.TabStop = true;
            this.RB_autorange.Text = "Auto";
            this.RB_autorange.UseVisualStyleBackColor = true;
            this.RB_autorange.CheckedChanged += new System.EventHandler(this.RB_autorange_CheckedChanged);
            // 
            // RB_Customrange
            // 
            this.RB_Customrange.AutoSize = true;
            this.RB_Customrange.Location = new System.Drawing.Point(72, 23);
            this.RB_Customrange.Name = "RB_Customrange";
            this.RB_Customrange.Size = new System.Drawing.Size(74, 21);
            this.RB_Customrange.TabIndex = 65;
            this.RB_Customrange.TabStop = true;
            this.RB_Customrange.Text = "Custom";
            this.RB_Customrange.UseVisualStyleBackColor = true;
            this.RB_Customrange.CheckedChanged += new System.EventHandler(this.RB_Customrange_CheckedChanged);
            // 
            // CBrange
            // 
            this.CBrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBrange.FormattingEnabled = true;
            this.CBrange.IntegralHeight = false;
            this.CBrange.Location = new System.Drawing.Point(209, 53);
            this.CBrange.Name = "CBrange";
            this.CBrange.Size = new System.Drawing.Size(78, 28);
            this.CBrange.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "Unit";
            // 
            // InputValue_area
            // 
            this.InputValue_area.DataSource = typeof(CodingLabpro.CommandDevice.CalculateArea_Bind);
            // 
            // AxisControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBResolution);
            this.Controls.Add(delaySteppingLabel);
            this.Controls.Add(this.delaySteppingComboBox);
            this.Controls.Add(this.unitYComboBox);
            this.Controls.Add(this.unitXComboBox);
            this.Controls.Add(moveStepXLabel);
            this.Controls.Add(this.moveStepXTextBox);
            this.Controls.Add(moveStepYLabel);
            this.Controls.Add(this.moveStepYTextBox);
            this.Controls.Add(totalAreaYLabel);
            this.Controls.Add(this.totalAreaYTextBox);
            this.Controls.Add(totalAreaXLabel);
            this.Controls.Add(this.totalAreaXTextBox);
            this.Controls.Add(this.GBautozero);
            this.Controls.Add(this.BtnCancel_scaning);
            this.Controls.Add(this.Btn_runscaning);
            this.Controls.Add(this.labeltitle);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.GBmotorport);
            this.Controls.Add(this.Btn_clear);
            this.Controls.Add(this.Btn_read);
            this.Controls.Add(this.Btn_Error);
            this.Controls.Add(this.GBreport);
            this.Controls.Add(this.GBSource);
            this.Controls.Add(this.GBMeas);
            this.Controls.Add(this.label_timerunit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelUnit2);
            this.Controls.Add(this.STriggerlabel);
            this.Controls.Add(this.labelUnit1);
            this.Controls.Add(this.CBtrigger);
            this.Controls.Add(this.Sublabel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
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
            this.Load += new System.EventHandler(this.AxisControl_Load);
            this.GBreport.ResumeLayout(false);
            this.GBreport.PerformLayout();
            this.GBmotorport.ResumeLayout(false);
            this.GBSource.ResumeLayout(false);
            this.GBMeas.ResumeLayout(false);
            this.GBautozero.ResumeLayout(false);
            this.GBautozero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Range)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Resolution)).EndInit();
            this.GBResolution.ResumeLayout(false);
            this.GBResolution.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputValue_area)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_timerunit;
        private System.Windows.Forms.Button Btn_runscaning;
        private System.Windows.Forms.Label Sublabel2;
        private System.Windows.Forms.Label Sublabel1;
        private System.Windows.Forms.Label labelUnit1;
        private System.Windows.Forms.Label labelUnit2;
        private System.Windows.Forms.TextBox Reportdata;
        private System.Windows.Forms.GroupBox GBreport;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnCancel_scaning;
        private System.Windows.Forms.ComboBox CBtrigger;
        private System.Windows.Forms.Label STriggerlabel;
        private System.Windows.Forms.GroupBox GBautozero;
        private System.Windows.Forms.RadioButton RB_autoON;
        private System.Windows.Forms.RadioButton RB_autoOFF;
        private System.Windows.Forms.BindingSource InputValue_area;
        private System.Windows.Forms.TextBox totalAreaXTextBox;
        private System.Windows.Forms.TextBox totalAreaYTextBox;
        private System.Windows.Forms.TextBox moveStepYTextBox;
        private System.Windows.Forms.TextBox moveStepXTextBox;
        private System.Windows.Forms.ComboBox unitXComboBox;
        private System.Windows.Forms.ComboBox unitYComboBox;
        private System.Windows.Forms.ComboBox delaySteppingComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown Numeric_Range;
        private System.Windows.Forms.RadioButton RB_autoOnce;
        private System.Windows.Forms.NumericUpDown Numeric_Resolution;
        private System.Windows.Forms.GroupBox GBResolution;
        private System.Windows.Forms.RadioButton RB_resolutionAuto;
        private System.Windows.Forms.RadioButton RB_resolutionCustom;
        private System.Windows.Forms.RadioButton RB_resolution4digits;
        private System.Windows.Forms.RadioButton RB_resolution6digits;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_autorange;
        private System.Windows.Forms.RadioButton RB_Customrange;
        private System.Windows.Forms.ComboBox CBrange;
        private System.Windows.Forms.Label label2;
    }
}
