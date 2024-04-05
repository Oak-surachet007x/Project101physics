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
            this.txtMMC2Address = new System.Windows.Forms.Button();
            this.txtDMMAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(88, 55);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMMC2Address
            // 
            this.txtMMC2Address.Location = new System.Drawing.Point(88, 110);
            this.txtMMC2Address.Name = "txtMMC2Address";
            this.txtMMC2Address.Size = new System.Drawing.Size(75, 23);
            this.txtMMC2Address.TabIndex = 1;
            this.txtMMC2Address.Text = "Diconnect";
            this.txtMMC2Address.UseVisualStyleBackColor = true;
            // 
            // txtDMMAddress
            // 
            this.txtDMMAddress.Location = new System.Drawing.Point(220, 55);
            this.txtDMMAddress.Name = "txtDMMAddress";
            this.txtDMMAddress.Size = new System.Drawing.Size(100, 20);
            this.txtDMMAddress.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 350);
            this.Controls.Add(this.txtDMMAddress);
            this.Controls.Add(this.txtMMC2Address);
            this.Controls.Add(this.Connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button txtMMC2Address;
        private System.Windows.Forms.TextBox txtDMMAddress;
    }
}

