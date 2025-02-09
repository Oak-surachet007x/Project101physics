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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Btn_stopmotor = new System.Windows.Forms.Button();
            this.Btn_XRight = new System.Windows.Forms.Button();
            this.Btn_XLeft = new System.Windows.Forms.Button();
            this.Btn_YDown = new System.Windows.Forms.Button();
            this.Btn_YUp = new System.Windows.Forms.Button();
            this.CblStepMotor = new System.Windows.Forms.ComboBox();
            this.labelstep = new System.Windows.Forms.Label();
            this.Btn_ResetHome = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTop
            // 
            this.labelTop.Font = new System.Drawing.Font("Cascadia Mono", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.ForeColor = System.Drawing.Color.White;
            this.labelTop.Location = new System.Drawing.Point(6, 11);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(249, 42);
            this.labelTop.TabIndex = 0;
            this.labelTop.Text = "Axis Control";
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.ForeColor = System.Drawing.Color.White;
            this.labeltitle.Location = new System.Drawing.Point(13, 57);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(136, 17);
            this.labeltitle.TabIndex = 1;
            this.labeltitle.Text = "Chuo seiki MMC-2";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Btn_stopmotor);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_XRight);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_XLeft);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_YDown);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_YUp);
            this.splitContainer1.Panel1.Controls.Add(this.CblStepMotor);
            this.splitContainer1.Panel1.Controls.Add(this.labelstep);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_ResetHome);
            this.splitContainer1.Panel1.Controls.Add(this.labelTop);
            this.splitContainer1.Panel1.Controls.Add(this.labeltitle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label_timerunit);
            this.splitContainer1.Panel2.Controls.Add(this.Cbltimer);
            this.splitContainer1.Panel2.Controls.Add(this.labelDelay);
            this.splitContainer1.Panel2.Controls.Add(this.Motortype2);
            this.splitContainer1.Panel2.Controls.Add(this.Motortype);
            this.splitContainer1.Panel2.Controls.Add(this.TxtstepY);
            this.splitContainer1.Panel2.Controls.Add(this.TxtstepX);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.Btn_runscaning);
            this.splitContainer1.Size = new System.Drawing.Size(315, 833);
            this.splitContainer1.SplitterDistance = 500;
            this.splitContainer1.TabIndex = 2;
            // 
            // Btn_stopmotor
            // 
            this.Btn_stopmotor.FlatAppearance.BorderSize = 3;
            this.Btn_stopmotor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_stopmotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_stopmotor.ForeColor = System.Drawing.Color.Red;
            this.Btn_stopmotor.Location = new System.Drawing.Point(22, 255);
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
            this.Btn_XRight.Location = new System.Drawing.Point(216, 197);
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
            this.Btn_XLeft.Location = new System.Drawing.Point(22, 197);
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
            this.Btn_YDown.Location = new System.Drawing.Point(114, 254);
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
            this.Btn_YUp.Location = new System.Drawing.Point(114, 140);
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
            this.CblStepMotor.Location = new System.Drawing.Point(171, 91);
            this.CblStepMotor.Name = "CblStepMotor";
            this.CblStepMotor.Size = new System.Drawing.Size(122, 33);
            this.CblStepMotor.TabIndex = 4;
            // 
            // labelstep
            // 
            this.labelstep.AutoSize = true;
            this.labelstep.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstep.ForeColor = System.Drawing.Color.White;
            this.labelstep.Location = new System.Drawing.Point(87, 94);
            this.labelstep.Name = "labelstep";
            this.labelstep.Size = new System.Drawing.Size(78, 25);
            this.labelstep.TabIndex = 3;
            this.labelstep.Text = "Step :";
            // 
            // Btn_ResetHome
            // 
            this.Btn_ResetHome.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ResetHome.ForeColor = System.Drawing.Color.Black;
            this.Btn_ResetHome.Location = new System.Drawing.Point(114, 197);
            this.Btn_ResetHome.Name = "Btn_ResetHome";
            this.Btn_ResetHome.Size = new System.Drawing.Size(96, 51);
            this.Btn_ResetHome.TabIndex = 2;
            this.Btn_ResetHome.Text = "Return to Origin";
            this.Btn_ResetHome.UseVisualStyleBackColor = true;
            this.Btn_ResetHome.Click += new System.EventHandler(this.Btn_ResetHome_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(253, 51);
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
            this.label_timerunit.Location = new System.Drawing.Point(270, 177);
            this.label_timerunit.Name = "label_timerunit";
            this.label_timerunit.Size = new System.Drawing.Size(28, 21);
            this.label_timerunit.TabIndex = 11;
            this.label_timerunit.Text = "ms";
            // 
            // Cbltimer
            // 
            this.Cbltimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbltimer.FormattingEnabled = true;
            this.Cbltimer.Location = new System.Drawing.Point(143, 172);
            this.Cbltimer.Name = "Cbltimer";
            this.Cbltimer.Size = new System.Drawing.Size(121, 28);
            this.Cbltimer.TabIndex = 10;
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelay.ForeColor = System.Drawing.Color.White;
            this.labelDelay.Location = new System.Drawing.Point(21, 172);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(127, 21);
            this.labelDelay.TabIndex = 9;
            this.labelDelay.Text = "Delay Step : ";
            // 
            // Motortype2
            // 
            this.Motortype2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Motortype2.FormattingEnabled = true;
            this.Motortype2.Location = new System.Drawing.Point(230, 125);
            this.Motortype2.Name = "Motortype2";
            this.Motortype2.Size = new System.Drawing.Size(63, 33);
            this.Motortype2.TabIndex = 8;
            // 
            // Motortype
            // 
            this.Motortype.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Motortype.FormattingEnabled = true;
            this.Motortype.Location = new System.Drawing.Point(230, 78);
            this.Motortype.Name = "Motortype";
            this.Motortype.Size = new System.Drawing.Size(63, 33);
            this.Motortype.TabIndex = 7;
            // 
            // TxtstepY
            // 
            this.TxtstepY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtstepY.Location = new System.Drawing.Point(104, 125);
            this.TxtstepY.Multiline = true;
            this.TxtstepY.Name = "TxtstepY";
            this.TxtstepY.Size = new System.Drawing.Size(120, 33);
            this.TxtstepY.TabIndex = 6;
            this.TxtstepY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtstepX
            // 
            this.TxtstepX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtstepX.Location = new System.Drawing.Point(104, 78);
            this.TxtstepX.Multiline = true;
            this.TxtstepX.Name = "TxtstepX";
            this.TxtstepX.Size = new System.Drawing.Size(120, 32);
            this.TxtstepX.TabIndex = 5;
            this.TxtstepX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Step Y : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Step X : ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Scaning";
            // 
            // Btn_runscaning
            // 
            this.Btn_runscaning.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_runscaning.FlatAppearance.BorderSize = 3;
            this.Btn_runscaning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_runscaning.Font = new System.Drawing.Font("Cascadia Mono", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_runscaning.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_runscaning.Location = new System.Drawing.Point(0, 276);
            this.Btn_runscaning.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_runscaning.Name = "Btn_runscaning";
            this.Btn_runscaning.Size = new System.Drawing.Size(315, 53);
            this.Btn_runscaning.TabIndex = 13;
            this.Btn_runscaning.Text = "RUN";
            this.Btn_runscaning.UseVisualStyleBackColor = true;
            this.Btn_runscaning.Click += new System.EventHandler(this.Btn_runscaning_Click);
            // 
            // AxisControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.splitContainer1);
            this.Name = "AxisControl";
            this.Size = new System.Drawing.Size(315, 833);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
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
    }
}
