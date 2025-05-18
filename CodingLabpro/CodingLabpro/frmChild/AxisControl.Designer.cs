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
            this.GBreport.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTop
            // 
            this.labelTop.Font = new System.Drawing.Font("Cascadia Mono", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.ForeColor = System.Drawing.Color.White;
            this.labelTop.Location = new System.Drawing.Point(15, 18);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(249, 42);
            this.labelTop.TabIndex = 0;
            this.labelTop.Text = "Axis Control";
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.ForeColor = System.Drawing.Color.White;
            this.labeltitle.Location = new System.Drawing.Point(18, 60);
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
            this.Btn_stopmotor.Location = new System.Drawing.Point(22, 260);
            this.Btn_stopmotor.Name = "Btn_stopmotor";
            this.Btn_stopmotor.Size = new System.Drawing.Size(86, 50);
            this.Btn_stopmotor.TabIndex = 9;
            this.Btn_stopmotor.Text = "Stop";
            this.Btn_stopmotor.UseVisualStyleBackColor = true;
            this.Btn_stopmotor.Click += new System.EventHandler(this.Btn_stopmotor_Click);
            // 
            // Btn_XRight
            // 
            this.Btn_XRight.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_XRight.ForeColor = System.Drawing.Color.Black;
            this.Btn_XRight.Location = new System.Drawing.Point(215, 203);
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
            this.Btn_XLeft.Location = new System.Drawing.Point(22, 203);
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
            this.Btn_YDown.Location = new System.Drawing.Point(113, 260);
            this.Btn_YDown.Name = "Btn_YDown";
            this.Btn_YDown.Size = new System.Drawing.Size(96, 51);
            this.Btn_YDown.TabIndex = 6;
            this.Btn_YDown.Text = "Y -\r\n";
            this.Btn_YDown.UseVisualStyleBackColor = true;
            this.Btn_YDown.Click += new System.EventHandler(this.Btn_YDown_Click);
            // 
            // Btn_YUp
            // 
            this.Btn_YUp.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_YUp.ForeColor = System.Drawing.Color.Black;
            this.Btn_YUp.Location = new System.Drawing.Point(113, 146);
            this.Btn_YUp.Name = "Btn_YUp";
            this.Btn_YUp.Size = new System.Drawing.Size(96, 51);
            this.Btn_YUp.TabIndex = 5;
            this.Btn_YUp.Text = "Y +";
            this.Btn_YUp.UseVisualStyleBackColor = true;
            this.Btn_YUp.Click += new System.EventHandler(this.Btn_YUp_Click);
            // 
            // CblStepMotor
            // 
            this.CblStepMotor.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CblStepMotor.FormattingEnabled = true;
            this.CblStepMotor.Location = new System.Drawing.Point(186, 92);
            this.CblStepMotor.Name = "CblStepMotor";
            this.CblStepMotor.Size = new System.Drawing.Size(106, 33);
            this.CblStepMotor.TabIndex = 4;
            // 
            // labelstep
            // 
            this.labelstep.AutoSize = true;
            this.labelstep.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstep.ForeColor = System.Drawing.Color.White;
            this.labelstep.Location = new System.Drawing.Point(102, 92);
            this.labelstep.Name = "labelstep";
            this.labelstep.Size = new System.Drawing.Size(78, 25);
            this.labelstep.TabIndex = 3;
            this.labelstep.Text = "Step :";
            // 
            // Btn_ResetHome
            // 
            this.Btn_ResetHome.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ResetHome.ForeColor = System.Drawing.Color.Black;
            this.Btn_ResetHome.Location = new System.Drawing.Point(113, 203);
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
            this.labelUnit2.Location = new System.Drawing.Point(242, 426);
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
            this.labelUnit1.Location = new System.Drawing.Point(242, 389);
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
            this.AxisScanYlabal.Location = new System.Drawing.Point(19, 426);
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
            this.AxisScanXlabal.Location = new System.Drawing.Point(19, 393);
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
            this.Sublabel1.Location = new System.Drawing.Point(19, 360);
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
            this.Sublabel2.Location = new System.Drawing.Point(19, 470);
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
            this.label4.Location = new System.Drawing.Point(256, 488);
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
            this.Cbltimer.Location = new System.Drawing.Point(140, 594);
            this.Cbltimer.Name = "Cbltimer";
            this.Cbltimer.Size = new System.Drawing.Size(112, 28);
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
            this.Motortype2.Location = new System.Drawing.Point(242, 547);
            this.Motortype2.Name = "Motortype2";
            this.Motortype2.Size = new System.Drawing.Size(69, 33);
            this.Motortype2.TabIndex = 8;
            // 
            // Motortype
            // 
            this.Motortype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Motortype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Motortype.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Motortype.FormattingEnabled = true;
            this.Motortype.Location = new System.Drawing.Point(242, 508);
            this.Motortype.Name = "Motortype";
            this.Motortype.Size = new System.Drawing.Size(69, 33);
            this.Motortype.TabIndex = 7;
            // 
            // TxtstepY
            // 
            this.TxtstepY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtstepY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtstepY.Location = new System.Drawing.Point(104, 547);
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
            this.TxtstepX.Location = new System.Drawing.Point(104, 509);
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
            this.label3.Location = new System.Drawing.Point(19, 547);
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
            this.label2.Location = new System.Drawing.Point(19, 514);
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
            this.label1.Location = new System.Drawing.Point(15, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Scanning";
            // 
            // Btn_runscaning
            // 
            this.Btn_runscaning.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_runscaning.FlatAppearance.BorderSize = 3;
            this.Btn_runscaning.Font = new System.Drawing.Font("Cascadia Mono", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_runscaning.ForeColor = System.Drawing.Color.Black;
            this.Btn_runscaning.Location = new System.Drawing.Point(0, 780);
            this.Btn_runscaning.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_runscaning.Name = "Btn_runscaning";
            this.Btn_runscaning.Size = new System.Drawing.Size(325, 53);
            this.Btn_runscaning.TabIndex = 13;
            this.Btn_runscaning.Text = "RUN";
            this.Btn_runscaning.UseVisualStyleBackColor = true;
            this.Btn_runscaning.Click += new System.EventHandler(this.Btn_runscaning_Click);
            // 
            // Reportdata
            // 
            this.Reportdata.BackColor = System.Drawing.Color.Black;
            this.Reportdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Reportdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Reportdata.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportdata.ForeColor = System.Drawing.Color.White;
            this.Reportdata.Location = new System.Drawing.Point(3, 22);
            this.Reportdata.Multiline = true;
            this.Reportdata.Name = "Reportdata";
            this.Reportdata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Reportdata.Size = new System.Drawing.Size(296, 115);
            this.Reportdata.TabIndex = 24;
            // 
            // GBreport
            // 
            this.GBreport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GBreport.Controls.Add(this.Reportdata);
            this.GBreport.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBreport.ForeColor = System.Drawing.Color.White;
            this.GBreport.Location = new System.Drawing.Point(11, 631);
            this.GBreport.Name = "GBreport";
            this.GBreport.Size = new System.Drawing.Size(302, 140);
            this.GBreport.TabIndex = 26;
            this.GBreport.TabStop = false;
            this.GBreport.Text = "Report loop Count ";
            // 
            // TbAreaX
            // 
            this.TbAreaX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAreaX.Location = new System.Drawing.Point(104, 389);
            this.TbAreaX.Multiline = true;
            this.TbAreaX.Name = "TbAreaX";
            this.TbAreaX.Size = new System.Drawing.Size(132, 31);
            this.TbAreaX.TabIndex = 27;
            this.TbAreaX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TbAreaY
            // 
            this.TbAreaY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAreaY.Location = new System.Drawing.Point(104, 426);
            this.TbAreaY.Multiline = true;
            this.TbAreaY.Name = "TbAreaY";
            this.TbAreaY.Size = new System.Drawing.Size(132, 28);
            this.TbAreaY.TabIndex = 28;
            this.TbAreaY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AxisControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.TbAreaY);
            this.Controls.Add(this.TbAreaX);
            this.Controls.Add(this.GBreport);
            this.Controls.Add(this.Cbltimer);
            this.Controls.Add(this.labelDelay);
            this.Controls.Add(this.label_timerunit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelUnit2);
            this.Controls.Add(this.Motortype2);
            this.Controls.Add(this.labelUnit1);
            this.Controls.Add(this.Motortype);
            this.Controls.Add(this.Sublabel2);
            this.Controls.Add(this.AxisScanYlabal);
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
            this.Controls.Add(this.Btn_runscaning);
            this.Controls.Add(this.labeltitle);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AxisControl";
            this.Size = new System.Drawing.Size(325, 833);
            this.GBreport.ResumeLayout(false);
            this.GBreport.PerformLayout();
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
    }
}
