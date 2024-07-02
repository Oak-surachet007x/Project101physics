namespace CodingLabpro
{
    partial class Form1
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
            this.Button2_Click = new System.Windows.Forms.Button();
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
            this.Btn_SetDc = new System.Windows.Forms.Button();
            this.BtnError = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // Button2_Click
            // 
            this.Button2_Click.Location = new System.Drawing.Point(93, 12);
            this.Button2_Click.Name = "Button2_Click";
            this.Button2_Click.Size = new System.Drawing.Size(75, 23);
            this.Button2_Click.TabIndex = 1;
            this.Button2_Click.Text = "Diconnect";
            this.Button2_Click.UseVisualStyleBackColor = true;
            this.Button2_Click.Click += new System.EventHandler(this.Button2_Click_Click);
            // 
            // BtnMovestep
            // 
            this.BtnMovestep.Location = new System.Drawing.Point(11, 164);
            this.BtnMovestep.Name = "BtnMovestep";
            this.BtnMovestep.Size = new System.Drawing.Size(75, 23);
            this.BtnMovestep.TabIndex = 3;
            this.BtnMovestep.Text = "x step 10";
            this.BtnMovestep.UseVisualStyleBackColor = true;
            this.BtnMovestep.Click += new System.EventHandler(this.BtnMovestep_Click);
            // 
            // Btn_stepY10
            // 
            this.Btn_stepY10.Location = new System.Drawing.Point(92, 164);
            this.Btn_stepY10.Name = "Btn_stepY10";
            this.Btn_stepY10.Size = new System.Drawing.Size(75, 23);
            this.Btn_stepY10.TabIndex = 4;
            this.Btn_stepY10.Text = "y step 10";
            this.Btn_stepY10.UseVisualStyleBackColor = true;
            this.Btn_stepY10.Click += new System.EventHandler(this.Btn_stepY10_Click);
            // 
            // Btn_stepY500
            // 
            this.Btn_stepY500.Location = new System.Drawing.Point(93, 193);
            this.Btn_stepY500.Name = "Btn_stepY500";
            this.Btn_stepY500.Size = new System.Drawing.Size(75, 23);
            this.Btn_stepY500.TabIndex = 7;
            this.Btn_stepY500.Text = "y step 500";
            this.Btn_stepY500.UseVisualStyleBackColor = true;
            this.Btn_stepY500.Click += new System.EventHandler(this.Btn_stepY500_Click);
            // 
            // Btn_stepY1000
            // 
            this.Btn_stepY1000.Location = new System.Drawing.Point(93, 221);
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
            this.label1.Location = new System.Drawing.Point(43, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "y";
            // 
            // Btn_movestep500
            // 
            this.Btn_movestep500.Location = new System.Drawing.Point(11, 193);
            this.Btn_movestep500.Name = "Btn_movestep500";
            this.Btn_movestep500.Size = new System.Drawing.Size(75, 23);
            this.Btn_movestep500.TabIndex = 12;
            this.Btn_movestep500.Text = "x step 500";
            this.Btn_movestep500.UseVisualStyleBackColor = true;
            this.Btn_movestep500.Click += new System.EventHandler(this.Btn_movestep500_Click);
            // 
            // Btn_movestep1000
            // 
            this.Btn_movestep1000.Location = new System.Drawing.Point(11, 223);
            this.Btn_movestep1000.Name = "Btn_movestep1000";
            this.Btn_movestep1000.Size = new System.Drawing.Size(75, 23);
            this.Btn_movestep1000.TabIndex = 13;
            this.Btn_movestep1000.Text = "x step 1000";
            this.Btn_movestep1000.UseVisualStyleBackColor = true;
            this.Btn_movestep1000.Click += new System.EventHandler(this.Btn_movestep1000_Click);
            // 
            // Btn_ResetXY
            // 
            this.Btn_ResetXY.Location = new System.Drawing.Point(13, 56);
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
            this.label3.Location = new System.Drawing.Point(12, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "DC ";
            // 
            // Btn_Cleardmm
            // 
            this.Btn_Cleardmm.Location = new System.Drawing.Point(266, 12);
            this.Btn_Cleardmm.Name = "Btn_Cleardmm";
            this.Btn_Cleardmm.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cleardmm.TabIndex = 17;
            this.Btn_Cleardmm.Text = "Clear(DMM)";
            this.Btn_Cleardmm.UseVisualStyleBackColor = true;
            this.Btn_Cleardmm.Click += new System.EventHandler(this.Btn_Cleardmm_Click);
            // 
            // Btn_SetDc
            // 
            this.Btn_SetDc.Location = new System.Drawing.Point(40, 278);
            this.Btn_SetDc.Name = "Btn_SetDc";
            this.Btn_SetDc.Size = new System.Drawing.Size(75, 23);
            this.Btn_SetDc.TabIndex = 18;
            this.Btn_SetDc.Text = "SetDC";
            this.Btn_SetDc.UseVisualStyleBackColor = true;
            this.Btn_SetDc.Click += new System.EventHandler(this.Btn_SetDc_Click);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 350);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnError);
            this.Controls.Add(this.Btn_SetDc);
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
            this.Controls.Add(this.Button2_Click);
            this.Controls.Add(this.Connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Button2_Click;
        private System.Windows.Forms.Button BtnMovestep;
        private System.Windows.Forms.Button Btn_stepY10;
        private System.Windows.Forms.Button BtnMovestep1000_Click;
        private System.Windows.Forms.Button Btn_stepY500;
        private System.Windows.Forms.Button Btn_stepY1000;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button Btn_movestep500;
        private System.Windows.Forms.Button Btn_movestep1000;
        private System.Windows.Forms.Button Btn_ResetXY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Cleardmm;
        private System.Windows.Forms.Button Btn_SetDc;
        private System.Windows.Forms.Button BtnError;
        private System.Windows.Forms.TextBox textBox1;
    }
}

