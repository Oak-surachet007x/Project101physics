namespace CodingLabpro
{
    partial class frmMain01
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
        /// 

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GBconnect = new System.Windows.Forms.GroupBox();
            this.buttonLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnDiconnect = new System.Windows.Forms.Button();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.Cblistaddress3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cblistaddress2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cblistaddress = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GBoutput = new System.Windows.Forms.GroupBox();
            this.textread = new System.Windows.Forms.TextBox();
            this.labelTop = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.GBconnect.SuspendLayout();
            this.buttonLayoutPanel2.SuspendLayout();
            this.GBoutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.46154F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.GBconnect, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.GBoutput, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 520);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1484, 241);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(580, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 221);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Measurement";
            // 
            // GBconnect
            // 
            this.GBconnect.Controls.Add(this.buttonLayoutPanel2);
            this.GBconnect.Controls.Add(this.Cblistaddress3);
            this.GBconnect.Controls.Add(this.label3);
            this.GBconnect.Controls.Add(this.Cblistaddress2);
            this.GBconnect.Controls.Add(this.label2);
            this.GBconnect.Controls.Add(this.Cblistaddress);
            this.GBconnect.Controls.Add(this.label1);
            this.GBconnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBconnect.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBconnect.ForeColor = System.Drawing.Color.White;
            this.GBconnect.Location = new System.Drawing.Point(1150, 10);
            this.GBconnect.Margin = new System.Windows.Forms.Padding(10);
            this.GBconnect.Name = "GBconnect";
            this.GBconnect.Size = new System.Drawing.Size(324, 221);
            this.GBconnect.TabIndex = 2;
            this.GBconnect.TabStop = false;
            this.GBconnect.Text = "Connection";
            // 
            // buttonLayoutPanel2
            // 
            this.buttonLayoutPanel2.ColumnCount = 2;
            this.buttonLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonLayoutPanel2.Controls.Add(this.BtnDiconnect, 0, 0);
            this.buttonLayoutPanel2.Controls.Add(this.BtnConnect, 1, 0);
            this.buttonLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLayoutPanel2.Location = new System.Drawing.Point(3, 182);
            this.buttonLayoutPanel2.Name = "buttonLayoutPanel2";
            this.buttonLayoutPanel2.RowCount = 1;
            this.buttonLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonLayoutPanel2.Size = new System.Drawing.Size(318, 36);
            this.buttonLayoutPanel2.TabIndex = 6;
            // 
            // BtnDiconnect
            // 
            this.BtnDiconnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDiconnect.ForeColor = System.Drawing.Color.Black;
            this.BtnDiconnect.Location = new System.Drawing.Point(3, 3);
            this.BtnDiconnect.Name = "BtnDiconnect";
            this.BtnDiconnect.Size = new System.Drawing.Size(153, 30);
            this.BtnDiconnect.TabIndex = 4;
            this.BtnDiconnect.Text = "Diconnect";
            this.BtnDiconnect.UseVisualStyleBackColor = true;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnConnect.ForeColor = System.Drawing.Color.Black;
            this.BtnConnect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnConnect.Location = new System.Drawing.Point(162, 3);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(153, 30);
            this.BtnConnect.TabIndex = 6;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // Cblistaddress3
            // 
            this.Cblistaddress3.FormattingEnabled = true;
            this.Cblistaddress3.Items.AddRange(new object[] {
            "PORT1",
            "Port2",
            "port3",
            "port4"});
            this.Cblistaddress3.Location = new System.Drawing.Point(14, 147);
            this.Cblistaddress3.Name = "Cblistaddress3";
            this.Cblistaddress3.Size = new System.Drawing.Size(300, 29);
            this.Cblistaddress3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "RS-232 Port : Z-Axis Controller";
            // 
            // Cblistaddress2
            // 
            this.Cblistaddress2.FormattingEnabled = true;
            this.Cblistaddress2.Items.AddRange(new object[] {
            "Port1"});
            this.Cblistaddress2.Location = new System.Drawing.Point(15, 96);
            this.Cblistaddress2.Name = "Cblistaddress2";
            this.Cblistaddress2.Size = new System.Drawing.Size(300, 29);
            this.Cblistaddress2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "GP-IB Port : XY-Axis Controller";
            // 
            // Cblistaddress
            // 
            this.Cblistaddress.FormattingEnabled = true;
            this.Cblistaddress.Items.AddRange(new object[] {
            "Port 1"});
            this.Cblistaddress.Location = new System.Drawing.Point(14, 45);
            this.Cblistaddress.Name = "Cblistaddress";
            this.Cblistaddress.Size = new System.Drawing.Size(300, 29);
            this.Cblistaddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "GP-IB Port : Multimeter";
            // 
            // GBoutput
            // 
            this.GBoutput.Controls.Add(this.textread);
            this.GBoutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBoutput.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBoutput.ForeColor = System.Drawing.Color.White;
            this.GBoutput.Location = new System.Drawing.Point(10, 10);
            this.GBoutput.Margin = new System.Windows.Forms.Padding(10);
            this.GBoutput.Name = "GBoutput";
            this.GBoutput.Size = new System.Drawing.Size(550, 221);
            this.GBoutput.TabIndex = 0;
            this.GBoutput.TabStop = false;
            this.GBoutput.Text = "OUTPUT";
            // 
            // textread
            // 
            this.textread.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textread.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textread.ForeColor = System.Drawing.Color.White;
            this.textread.Location = new System.Drawing.Point(3, 22);
            this.textread.Multiline = true;
            this.textread.Name = "textread";
            this.textread.ReadOnly = true;
            this.textread.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textread.Size = new System.Drawing.Size(544, 196);
            this.textread.TabIndex = 0;
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.BackColor = System.Drawing.Color.Transparent;
            this.labelTop.Font = new System.Drawing.Font("Cascadia Mono", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.ForeColor = System.Drawing.Color.White;
            this.labelTop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTop.Location = new System.Drawing.Point(80, 17);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(264, 49);
            this.labelTop.TabIndex = 2;
            this.labelTop.Text = "MainControl";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(80, 66);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(370, 21);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Aglient 34401A And MMC-2 Axis Controller";
            // 
            // frmMain01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmMain01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain01";
            this.ResizeEnd += new System.EventHandler(this.frmMain01_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.frmMain01_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GBconnect.ResumeLayout(false);
            this.GBconnect.PerformLayout();
            this.buttonLayoutPanel2.ResumeLayout(false);
            this.GBoutput.ResumeLayout(false);
            this.GBoutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox GBoutput;

        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GBconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cblistaddress3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cblistaddress2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cblistaddress;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Button BtnDiconnect;
        private System.Windows.Forms.TableLayoutPanel buttonLayoutPanel2;
        private System.Windows.Forms.TextBox textread;
        private System.IO.Ports.SerialPort serialPort1;
    }
}