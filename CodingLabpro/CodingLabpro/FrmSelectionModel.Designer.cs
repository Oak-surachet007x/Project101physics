namespace CodingLabpro
{
    partial class FrmSelectionModel
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
            this.components = new System.ComponentModel.Container();
            this.Btn_ApplyModel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RB_ChuoseikiModel = new System.Windows.Forms.RadioButton();
            this.RB_VextaModel = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // Btn_ApplyModel
            // 
            this.Btn_ApplyModel.Location = new System.Drawing.Point(671, 399);
            this.Btn_ApplyModel.Name = "Btn_ApplyModel";
            this.Btn_ApplyModel.Size = new System.Drawing.Size(112, 38);
            this.Btn_ApplyModel.TabIndex = 2;
            this.Btn_ApplyModel.Text = "Apply";
            this.Btn_ApplyModel.UseVisualStyleBackColor = true;
            this.Btn_ApplyModel.Click += new System.EventHandler(this.Btn_ApplyModel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(212, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose Setup Stepper motor type";
            // 
            // RB_ChuoseikiModel
            // 
            this.RB_ChuoseikiModel.AutoSize = true;
            this.RB_ChuoseikiModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_ChuoseikiModel.ForeColor = System.Drawing.Color.White;
            this.RB_ChuoseikiModel.Location = new System.Drawing.Point(24, 98);
            this.RB_ChuoseikiModel.Name = "RB_ChuoseikiModel";
            this.RB_ChuoseikiModel.Size = new System.Drawing.Size(367, 29);
            this.RB_ChuoseikiModel.TabIndex = 6;
            this.RB_ChuoseikiModel.TabStop = true;
            this.RB_ChuoseikiModel.Text = "Chuo Seiki MMU-60X-H1 XY Stage";
            this.RB_ChuoseikiModel.UseVisualStyleBackColor = true;
            // 
            // RB_VextaModel
            // 
            this.RB_VextaModel.AutoSize = true;
            this.RB_VextaModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_VextaModel.ForeColor = System.Drawing.Color.White;
            this.RB_VextaModel.Location = new System.Drawing.Point(24, 63);
            this.RB_VextaModel.Name = "RB_VextaModel";
            this.RB_VextaModel.Size = new System.Drawing.Size(234, 29);
            this.RB_VextaModel.TabIndex = 5;
            this.RB_VextaModel.TabStop = true;
            this.RB_VextaModel.Text = "Vexta 5 phase ph544";
            this.RB_VextaModel.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmSelectionModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(808, 461);
            this.Controls.Add(this.RB_ChuoseikiModel);
            this.Controls.Add(this.RB_VextaModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_ApplyModel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelectionModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSelectionModel";
            this.Load += new System.EventHandler(this.FrmSelectionModel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_ApplyModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RB_ChuoseikiModel;
        private System.Windows.Forms.RadioButton RB_VextaModel;
        private System.Windows.Forms.ImageList imageList1;
    }
}