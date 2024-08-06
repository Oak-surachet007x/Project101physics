namespace CodingLabpro
{
    partial class frmMain
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
        private void InitializeComponent()
        {
            this.Connect = new System.Windows.Forms.Button();
            this.BtnDiconnect = new System.Windows.Forms.Button();
            this.BtnMovestep = new System.Windows.Forms.Button();
            this.Btn_stepY10 = new System.Windows.Forms.Button();
            this.Btn_stepY500 = new System.Windows.Forms.Button();
            this.Btn_stepY1000 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_movestep500 = new System.Windows.Forms.Button();
            this.Btn_movestep1000 = new System.Windows.Forms.Button();
            this.Btn_ResetXY = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Cleardmm = new System.Windows.Forms.Button();
            this.Btn_SetDC = new System.Windows.Forms.Button();
            this.BtnError = new System.Windows.Forms.Button();
            this.txtread = new System.Windows.Forms.TextBox();
            this.Btn_SetAC = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Btnposition = new System.Windows.Forms.Button();
            this.optAxis_y = new System.Windows.Forms.RadioButton();
            this.optAxis_x = new System.Windows.Forms.RadioButton();
            this.Btnenter = new System.Windows.Forms.Button();
            this.lbmotor = new System.Windows.Forms.Label();
            this.txt_IPloop = new System.Windows.Forms.TextBox();
            this.graphBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Btn_stepZ10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(12, 12);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnDiconnect
            // 
            this.BtnDiconnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnDiconnect.Location = new System.Drawing.Point(93, 12);
            this.BtnDiconnect.Name = "BtnDiconnect";
            this.BtnDiconnect.Size = new System.Drawing.Size(75, 23);
            this.BtnDiconnect.TabIndex = 1;
            this.BtnDiconnect.Text = "Diconnect";
            this.BtnDiconnect.UseVisualStyleBackColor = true;
            this.BtnDiconnect.Click += new System.EventHandler(this.BtnDiconnect_Click);
            // 
            // BtnMovestep
            // 
            this.BtnMovestep.Location = new System.Drawing.Point(11, 67);
            this.BtnMovestep.Name = "BtnMovestep";
            this.BtnMovestep.Size = new System.Drawing.Size(75, 23);
            this.BtnMovestep.TabIndex = 3;
            this.BtnMovestep.Text = "x step 10";
            this.BtnMovestep.UseVisualStyleBackColor = true;
            this.BtnMovestep.Click += new System.EventHandler(this.BtnMovestep_Click);
            // 
            // Btn_stepY10
            // 
            this.Btn_stepY10.Location = new System.Drawing.Point(11, 185);
            this.Btn_stepY10.Name = "Btn_stepY10";
            this.Btn_stepY10.Size = new System.Drawing.Size(75, 23);
            this.Btn_stepY10.TabIndex = 4;
            this.Btn_stepY10.Text = "y step 10";
            this.Btn_stepY10.UseVisualStyleBackColor = true;
            this.Btn_stepY10.Click += new System.EventHandler(this.Btn_stepY10_Click);
            // 
            // Btn_stepY500
            // 
            this.Btn_stepY500.Location = new System.Drawing.Point(12, 214);
            this.Btn_stepY500.Name = "Btn_stepY500";
            this.Btn_stepY500.Size = new System.Drawing.Size(75, 23);
            this.Btn_stepY500.TabIndex = 7;
            this.Btn_stepY500.Text = "y step 500";
            this.Btn_stepY500.UseVisualStyleBackColor = true;
            this.Btn_stepY500.Click += new System.EventHandler(this.Btn_stepY500_Click);
            // 
            // Btn_stepY1000
            // 
            this.Btn_stepY1000.Location = new System.Drawing.Point(12, 242);
            this.Btn_stepY1000.Name = "Btn_stepY1000";
            this.Btn_stepY1000.Size = new System.Drawing.Size(75, 23);
            this.Btn_stepY1000.TabIndex = 8;
            this.Btn_stepY1000.Text = "y step 1000";
            this.Btn_stepY1000.UseVisualStyleBackColor = true;
            this.Btn_stepY1000.Click += new System.EventHandler(this.Btn_stepY1000_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "y";
            // 
            // Btn_movestep500
            // 
            this.Btn_movestep500.Location = new System.Drawing.Point(11, 96);
            this.Btn_movestep500.Name = "Btn_movestep500";
            this.Btn_movestep500.Size = new System.Drawing.Size(75, 23);
            this.Btn_movestep500.TabIndex = 12;
            this.Btn_movestep500.Text = "x step 500";
            this.Btn_movestep500.UseVisualStyleBackColor = true;
            this.Btn_movestep500.Click += new System.EventHandler(this.Btn_movestep500_Click);
            // 
            // Btn_movestep1000
            // 
            this.Btn_movestep1000.Location = new System.Drawing.Point(11, 126);
            this.Btn_movestep1000.Name = "Btn_movestep1000";
            this.Btn_movestep1000.Size = new System.Drawing.Size(75, 23);
            this.Btn_movestep1000.TabIndex = 13;
            this.Btn_movestep1000.Text = "x step 1000";
            this.Btn_movestep1000.UseVisualStyleBackColor = true;
            this.Btn_movestep1000.Click += new System.EventHandler(this.Btn_movestep1000_Click);
            // 
            // Btn_ResetXY
            // 
            this.Btn_ResetXY.Location = new System.Drawing.Point(347, 12);
            this.Btn_ResetXY.Name = "Btn_ResetXY";
            this.Btn_ResetXY.Size = new System.Drawing.Size(75, 23);
            this.Btn_ResetXY.TabIndex = 14;
            this.Btn_ResetXY.Text = "Reset(0,0)";
            this.Btn_ResetXY.UseVisualStyleBackColor = true;
            this.Btn_ResetXY.Click += new System.EventHandler(this.Btn_ResetXY_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(653, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "DC ";
            // 
            // Btn_Cleardmm
            // 
            this.Btn_Cleardmm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cleardmm.Location = new System.Drawing.Point(266, 12);
            this.Btn_Cleardmm.Name = "Btn_Cleardmm";
            this.Btn_Cleardmm.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cleardmm.TabIndex = 17;
            this.Btn_Cleardmm.Text = "Clear(DMM)";
            this.Btn_Cleardmm.UseVisualStyleBackColor = true;
            this.Btn_Cleardmm.Click += new System.EventHandler(this.Btn_Cleardmm_Click);
            // 
            // Btn_SetDC
            // 
            this.Btn_SetDC.Location = new System.Drawing.Point(684, 12);
            this.Btn_SetDC.Name = "Btn_SetDC";
            this.Btn_SetDC.Size = new System.Drawing.Size(88, 23);
            this.Btn_SetDC.TabIndex = 18;
            this.Btn_SetDC.Text = "MEAS DC";
            this.Btn_SetDC.UseVisualStyleBackColor = true;
            this.Btn_SetDC.Click += new System.EventHandler(this.Btn_SetDC_Click);
            // 
            // BtnError
            // 
            this.BtnError.Location = new System.Drawing.Point(185, 12);
            this.BtnError.Name = "BtnError";
            this.BtnError.Size = new System.Drawing.Size(75, 23);
            this.BtnError.TabIndex = 19;
            this.BtnError.Text = "Read Error";
            this.BtnError.UseVisualStyleBackColor = true;
            this.BtnError.Click += new System.EventHandler(this.BtnError_Click);
            // 
            // txtread
            // 
            this.txtread.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtread.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtread.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtread.Location = new System.Drawing.Point(11, 286);
            this.txtread.Multiline = true;
            this.txtread.Name = "txtread";
            this.txtread.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtread.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtread.Size = new System.Drawing.Size(761, 163);
            this.txtread.TabIndex = 20;
            // 
            // Btn_SetAC
            // 
            this.Btn_SetAC.Location = new System.Drawing.Point(559, 12);
            this.Btn_SetAC.Name = "Btn_SetAC";
            this.Btn_SetAC.Size = new System.Drawing.Size(88, 23);
            this.Btn_SetAC.TabIndex = 21;
            this.Btn_SetAC.Text = "MEAS AC";
            this.Btn_SetAC.UseVisualStyleBackColor = true;
            this.Btn_SetAC.Click += new System.EventHandler(this.Btn_SetAC_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "AC";
            // 
            // Btnposition
            // 
            this.Btnposition.Location = new System.Drawing.Point(428, 12);
            this.Btnposition.Name = "Btnposition";
            this.Btnposition.Size = new System.Drawing.Size(82, 23);
            this.Btnposition.TabIndex = 23;
            this.Btnposition.Text = "Position x,y";
            this.Btnposition.UseVisualStyleBackColor = true;
            this.Btnposition.Click += new System.EventHandler(this.Btnposition_Click);
            // 
            // optAxis_y
            // 
            this.optAxis_y.AutoSize = true;
            this.optAxis_y.Location = new System.Drawing.Point(166, 64);
            this.optAxis_y.Margin = new System.Windows.Forms.Padding(2);
            this.optAxis_y.Name = "optAxis_y";
            this.optAxis_y.Size = new System.Drawing.Size(54, 17);
            this.optAxis_y.TabIndex = 24;
            this.optAxis_y.TabStop = true;
            this.optAxis_y.Text = "Axis Y";
            this.optAxis_y.UseVisualStyleBackColor = true;
            // 
            // optAxis_x
            // 
            this.optAxis_x.AutoSize = true;
            this.optAxis_x.Location = new System.Drawing.Point(107, 64);
            this.optAxis_x.Margin = new System.Windows.Forms.Padding(2);
            this.optAxis_x.Name = "optAxis_x";
            this.optAxis_x.Size = new System.Drawing.Size(54, 17);
            this.optAxis_x.TabIndex = 25;
            this.optAxis_x.TabStop = true;
            this.optAxis_x.Text = "Axis X";
            this.optAxis_x.UseVisualStyleBackColor = true;
            // 
            // Btnenter
            // 
            this.Btnenter.Location = new System.Drawing.Point(107, 126);
            this.Btnenter.Margin = new System.Windows.Forms.Padding(2);
            this.Btnenter.Name = "Btnenter";
            this.Btnenter.Size = new System.Drawing.Size(108, 26);
            this.Btnenter.TabIndex = 26;
            this.Btnenter.Text = "Enter";
            this.Btnenter.UseVisualStyleBackColor = true;
            this.Btnenter.Click += new System.EventHandler(this.Btnenter_Click);
            // 
            // lbmotor
            // 
            this.lbmotor.AutoSize = true;
            this.lbmotor.Location = new System.Drawing.Point(107, 46);
            this.lbmotor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbmotor.Name = "lbmotor";
            this.lbmotor.Size = new System.Drawing.Size(97, 13);
            this.lbmotor.TabIndex = 27;
            this.lbmotor.Text = "Set loop Stepmotor";
            // 
            // txt_IPloop
            // 
            this.txt_IPloop.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_IPloop.Location = new System.Drawing.Point(107, 85);
            this.txt_IPloop.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IPloop.MaxLength = 3;
            this.txt_IPloop.Multiline = true;
            this.txt_IPloop.Name = "txt_IPloop";
            this.txt_IPloop.Size = new System.Drawing.Size(109, 34);
            this.txt_IPloop.TabIndex = 28;
            // 
            // graphBox1
            // 
            this.graphBox1.BackColor = System.Drawing.SystemColors.Control;
            this.graphBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.graphBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphBox1.ForeColor = System.Drawing.Color.Coral;
            this.graphBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.graphBox1.Location = new System.Drawing.Point(347, 46);
            this.graphBox1.Margin = new System.Windows.Forms.Padding(2);
            this.graphBox1.Name = "graphBox1";
            this.graphBox1.Padding = new System.Windows.Forms.Padding(2);
            this.graphBox1.Size = new System.Drawing.Size(424, 219);
            this.graphBox1.TabIndex = 29;
            this.graphBox1.TabStop = false;
            this.graphBox1.Text = "graph Data DC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Z";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Z step 1000";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Z step 500";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Btn_stepZ10
            // 
            this.Btn_stepZ10.Location = new System.Drawing.Point(106, 185);
            this.Btn_stepZ10.Name = "Btn_stepZ10";
            this.Btn_stepZ10.Size = new System.Drawing.Size(75, 23);
            this.Btn_stepZ10.TabIndex = 30;
            this.Btn_stepZ10.Text = "Z step 10";
            this.Btn_stepZ10.UseVisualStyleBackColor = true;
            this.Btn_stepZ10.Click += new System.EventHandler(this.Btn_stepZ10_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_stepZ10);
            this.Controls.Add(this.Btnenter);
            this.Controls.Add(this.Btnposition);
            this.Controls.Add(this.graphBox1);
            this.Controls.Add(this.txt_IPloop);
            this.Controls.Add(this.lbmotor);
            this.Controls.Add(this.optAxis_x);
            this.Controls.Add(this.optAxis_y);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_SetAC);
            this.Controls.Add(this.txtread);
            this.Controls.Add(this.BtnError);
            this.Controls.Add(this.Btn_SetDC);
            this.Controls.Add(this.Btn_Cleardmm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_ResetXY);
            this.Controls.Add(this.Btn_movestep1000);
            this.Controls.Add(this.Btn_movestep500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_stepY1000);
            this.Controls.Add(this.Btn_stepY500);
            this.Controls.Add(this.Btn_stepY10);
            this.Controls.Add(this.BtnMovestep);
            this.Controls.Add(this.BtnDiconnect);
            this.Controls.Add(this.Connect);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Physics101";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button BtnDiconnect;
        private System.Windows.Forms.Button BtnMovestep;
        private System.Windows.Forms.Button Btn_stepY10;
     
        private System.Windows.Forms.Button Btn_stepY500;
        private System.Windows.Forms.Button Btn_stepY1000;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button Btn_movestep500;
        private System.Windows.Forms.Button Btn_movestep1000;
        private System.Windows.Forms.Button Btn_ResetXY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Cleardmm;
        private System.Windows.Forms.Button Btn_SetDC;
        private System.Windows.Forms.Button BtnError;
        private System.Windows.Forms.TextBox txtread;
        private System.Windows.Forms.Button Btn_SetAC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btnposition;
        private System.Windows.Forms.RadioButton optAxis_y;
        private System.Windows.Forms.RadioButton optAxis_x;
        private System.Windows.Forms.Button Btnenter;
        private System.Windows.Forms.Label lbmotor;
        private System.Windows.Forms.TextBox txt_IPloop;
        private System.Windows.Forms.GroupBox graphBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Btn_stepZ10;
    }
}

