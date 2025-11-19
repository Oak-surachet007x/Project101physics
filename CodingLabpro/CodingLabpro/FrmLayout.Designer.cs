namespace CodingLabpro
{
    partial class FrmLayout
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
            this.Menupanel = new System.Windows.Forms.Panel();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FormLayoutpanel = new System.Windows.Forms.Panel();
            this.ucMenu2 = new CodingLabpro.Models.ucMenu();
            this.ucMenu1 = new CodingLabpro.Models.ucMenu();
            this.Menupanel.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menupanel
            // 
            this.Menupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.Menupanel.Controls.Add(this.ucMenu2);
            this.Menupanel.Controls.Add(this.ucMenu1);
            this.Menupanel.Controls.Add(this.panel_Logo);
            this.Menupanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menupanel.Location = new System.Drawing.Point(0, 0);
            this.Menupanel.Name = "Menupanel";
            this.Menupanel.Size = new System.Drawing.Size(150, 761);
            this.Menupanel.TabIndex = 0;
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackColor = System.Drawing.Color.White;
            this.panel_Logo.Controls.Add(this.pictureBox1);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(150, 144);
            this.panel_Logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CodingLabpro.Properties.Resources.Applied_Physics_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(8, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormLayoutpanel
            // 
            this.FormLayoutpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormLayoutpanel.Location = new System.Drawing.Point(150, 0);
            this.FormLayoutpanel.Name = "FormLayoutpanel";
            this.FormLayoutpanel.Size = new System.Drawing.Size(1234, 761);
            this.FormLayoutpanel.TabIndex = 1;
            // 
            // ucMenu2
            // 
            this.ucMenu2.BackColor = System.Drawing.Color.Transparent;
            this.ucMenu2.BorderColor = System.Drawing.Color.Transparent;
            this.ucMenu2.Icon = global::CodingLabpro.Properties.Resources.dynamic_form_16dp_E8EAED;
            this.ucMenu2.Location = new System.Drawing.Point(0, 249);
            this.ucMenu2.Name = "ucMenu2";
            this.ucMenu2.Size = new System.Drawing.Size(150, 52);
            this.ucMenu2.TabIndex = 2;
            this.ucMenu2.textlabel = "Old Form";
            // 
            // ucMenu1
            // 
            this.ucMenu1.BackColor = System.Drawing.Color.Transparent;
            this.ucMenu1.BorderColor = System.Drawing.Color.Transparent;
            this.ucMenu1.Icon = global::CodingLabpro.Properties.Resources.monitor_heart_70dp_8C1AF6_FILL0_wght400_GRAD0_opsz48;
            this.ucMenu1.Location = new System.Drawing.Point(0, 191);
            this.ucMenu1.Name = "ucMenu1";
            this.ucMenu1.Size = new System.Drawing.Size(150, 52);
            this.ucMenu1.TabIndex = 1;
            this.ucMenu1.textlabel = "MainControl";
            // 
            // FrmLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.FormLayoutpanel);
            this.Controls.Add(this.Menupanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "FrmLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLayout";
            this.Menupanel.ResumeLayout(false);
            this.panel_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menupanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.Panel FormLayoutpanel;
        private Models.ucMenu ucMenu1;
        private Models.ucMenu ucMenu2;
    }
}