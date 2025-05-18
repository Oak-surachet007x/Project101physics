namespace CodingLabpro.Models
{
    partial class MessageBox_Notify
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
            this.MessageBorder = new System.Windows.Forms.Panel();
            this.labelType = new System.Windows.Forms.Label();
            this.IbMessage = new System.Windows.Forms.Label();
            this.Messagetimer = new System.Windows.Forms.Timer(this.components);
            this.HideTimer = new System.Windows.Forms.Timer(this.components);
            this.picIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // MessageBorder
            // 
            this.MessageBorder.BackColor = System.Drawing.Color.Blue;
            this.MessageBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.MessageBorder.Location = new System.Drawing.Point(0, 0);
            this.MessageBorder.Name = "MessageBorder";
            this.MessageBorder.Size = new System.Drawing.Size(14, 130);
            this.MessageBorder.TabIndex = 0;
            this.MessageBorder.Paint += new System.Windows.Forms.PaintEventHandler(this.LineBorder_Paint);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.Color.White;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.ForeColor = System.Drawing.Color.Black;
            this.labelType.Location = new System.Drawing.Point(77, 12);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(57, 24);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Type";
            // 
            // IbMessage
            // 
            this.IbMessage.AutoSize = true;
            this.IbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IbMessage.ForeColor = System.Drawing.Color.Black;
            this.IbMessage.Location = new System.Drawing.Point(78, 36);
            this.IbMessage.Name = "IbMessage";
            this.IbMessage.Size = new System.Drawing.Size(84, 15);
            this.IbMessage.TabIndex = 3;
            this.IbMessage.Text = "Text Message";
            // 
            // Messagetimer
            // 
            this.Messagetimer.Enabled = true;
            this.Messagetimer.Interval = 1;
            this.Messagetimer.Tick += new System.EventHandler(this.Messagetimer_Tick);
            // 
            // HideTimer
            // 
            this.HideTimer.Interval = 10;
            this.HideTimer.Tick += new System.EventHandler(this.HideTimer_Tick);
            // 
            // picIcon
            // 
            this.picIcon.Image = global::CodingLabpro.Properties.Resources.info_16dp_0000F5_FILL0_wght400_GRAD0_opsz48;
            this.picIcon.Location = new System.Drawing.Point(20, 12);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(49, 47);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 1;
            this.picIcon.TabStop = false;
            // 
            // MessageBox_Notify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 130);
            this.Controls.Add(this.IbMessage);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.MessageBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBox_Notify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MessageBox_Notify";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MessageBox_Notify_FormClosed);
            this.Load += new System.EventHandler(this.MessageBox_Notify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MessageBorder;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label IbMessage;
        private System.Windows.Forms.Timer Messagetimer;
        private System.Windows.Forms.Timer HideTimer;
    }
}