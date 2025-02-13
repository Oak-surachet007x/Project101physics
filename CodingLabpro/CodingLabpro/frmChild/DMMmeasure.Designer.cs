namespace CodingLabpro.frmChild
{
    partial class DMMmeasure
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
            this.LabelTop = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelTop
            // 
            this.LabelTop.AutoSize = true;
            this.LabelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.LabelTop.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTop.ForeColor = System.Drawing.Color.White;
            this.LabelTop.Location = new System.Drawing.Point(13, 17);
            this.LabelTop.Name = "LabelTop";
            this.LabelTop.Size = new System.Drawing.Size(191, 35);
            this.LabelTop.TabIndex = 0;
            this.LabelTop.Text = "Measurement";
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.White;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.ForeColor = System.Drawing.Color.Orange;
            this.Button1.Location = new System.Drawing.Point(19, 125);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(92, 29);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Test button";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Cascadia Code Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(15, 67);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(154, 42);
            this.LabelTitle.TabIndex = 2;
            this.LabelTitle.Text = "Agilent 34401A\r\nDigit Multimeter";
            // 
            // DMMmeasure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.LabelTop);
            this.Name = "DMMmeasure";
            this.Size = new System.Drawing.Size(315, 833);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTop;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label LabelTitle;
    }
}
