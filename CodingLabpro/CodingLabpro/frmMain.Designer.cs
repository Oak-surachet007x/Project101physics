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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Connect = new System.Windows.Forms.Button();
            this.BtnDiconnect = new System.Windows.Forms.Button();
            this.BtnMovestep = new System.Windows.Forms.Button();
            this.Btn_stepY10 = new System.Windows.Forms.Button();
            this.Btn_stepY500 = new System.Windows.Forms.Button();
            this.Btn_stepY1000 = new System.Windows.Forms.Button();
            this.Btn_movestep500 = new System.Windows.Forms.Button();
            this.Btn_movestep1000 = new System.Windows.Forms.Button();
            this.Btn_ResetXY = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Cleardmm = new System.Windows.Forms.Button();
            this.Btn_SetDC = new System.Windows.Forms.Button();
            this.BtnError = new System.Windows.Forms.Button();
            this.Btn_SetAC = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.optAxis_x = new System.Windows.Forms.RadioButton();
            this.Btnenter = new System.Windows.Forms.Button();
            this.txt_IPloop = new System.Windows.Forms.TextBox();
            this.graphBox1 = new System.Windows.Forms.GroupBox();
            this.chartDC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.optAxis_y = new System.Windows.Forms.RadioButton();
            this.txtread = new System.Windows.Forms.TextBox();
            this.Boxread = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Ptgpib = new System.Windows.Forms.RadioButton();
            this.Ptrs232 = new System.Windows.Forms.RadioButton();
            this.Boxloopmotor = new System.Windows.Forms.GroupBox();
            this.Boxposition = new System.Windows.Forms.GroupBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.graphBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDC)).BeginInit();
            this.Boxread.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Boxloopmotor.SuspendLayout();
            this.Boxposition.SuspendLayout();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(118, 22);
            this.Connect.Margin = new System.Windows.Forms.Padding(4);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(100, 64);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnDiconnect
            // 
            this.BtnDiconnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnDiconnect.Location = new System.Drawing.Point(226, 22);
            this.BtnDiconnect.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDiconnect.Name = "BtnDiconnect";
            this.BtnDiconnect.Size = new System.Drawing.Size(100, 64);
            this.BtnDiconnect.TabIndex = 1;
            this.BtnDiconnect.Text = "Diconnect";
            this.BtnDiconnect.UseVisualStyleBackColor = true;
            this.BtnDiconnect.Click += new System.EventHandler(this.BtnDiconnect_Click);
            // 
            // BtnMovestep
            // 
            this.BtnMovestep.Location = new System.Drawing.Point(8, 22);
            this.BtnMovestep.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMovestep.Name = "BtnMovestep";
            this.BtnMovestep.Size = new System.Drawing.Size(100, 28);
            this.BtnMovestep.TabIndex = 3;
            this.BtnMovestep.Text = "x step 10";
            this.BtnMovestep.UseVisualStyleBackColor = true;
            this.BtnMovestep.Click += new System.EventHandler(this.BtnMovestep_Click);
            // 
            // Btn_stepY10
            // 
            this.Btn_stepY10.Location = new System.Drawing.Point(118, 22);
            this.Btn_stepY10.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_stepY10.Name = "Btn_stepY10";
            this.Btn_stepY10.Size = new System.Drawing.Size(100, 28);
            this.Btn_stepY10.TabIndex = 4;
            this.Btn_stepY10.Text = "y step 10";
            this.Btn_stepY10.UseVisualStyleBackColor = true;
            this.Btn_stepY10.Click += new System.EventHandler(this.Btn_stepY10_Click);
            // 
            // Btn_stepY500
            // 
            this.Btn_stepY500.Location = new System.Drawing.Point(118, 54);
            this.Btn_stepY500.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_stepY500.Name = "Btn_stepY500";
            this.Btn_stepY500.Size = new System.Drawing.Size(100, 28);
            this.Btn_stepY500.TabIndex = 7;
            this.Btn_stepY500.Text = "y step 500";
            this.Btn_stepY500.UseVisualStyleBackColor = true;
            this.Btn_stepY500.Click += new System.EventHandler(this.Btn_stepY500_Click);
            // 
            // Btn_stepY1000
            // 
            this.Btn_stepY1000.Location = new System.Drawing.Point(118, 88);
            this.Btn_stepY1000.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_stepY1000.Name = "Btn_stepY1000";
            this.Btn_stepY1000.Size = new System.Drawing.Size(100, 28);
            this.Btn_stepY1000.TabIndex = 8;
            this.Btn_stepY1000.Text = "y step 1000";
            this.Btn_stepY1000.UseVisualStyleBackColor = true;
            this.Btn_stepY1000.Click += new System.EventHandler(this.Btn_stepY1000_Click);
            // 
            // Btn_movestep500
            // 
            this.Btn_movestep500.Location = new System.Drawing.Point(8, 54);
            this.Btn_movestep500.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_movestep500.Name = "Btn_movestep500";
            this.Btn_movestep500.Size = new System.Drawing.Size(100, 28);
            this.Btn_movestep500.TabIndex = 12;
            this.Btn_movestep500.Text = "x step 500";
            this.Btn_movestep500.UseVisualStyleBackColor = true;
            this.Btn_movestep500.Click += new System.EventHandler(this.Btn_movestep500_Click);
            // 
            // Btn_movestep1000
            // 
            this.Btn_movestep1000.Location = new System.Drawing.Point(8, 88);
            this.Btn_movestep1000.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_movestep1000.Name = "Btn_movestep1000";
            this.Btn_movestep1000.Size = new System.Drawing.Size(100, 28);
            this.Btn_movestep1000.TabIndex = 13;
            this.Btn_movestep1000.Text = "x step 1000";
            this.Btn_movestep1000.UseVisualStyleBackColor = true;
            this.Btn_movestep1000.Click += new System.EventHandler(this.Btn_movestep1000_Click);
            // 
            // Btn_ResetXY
            // 
            this.Btn_ResetXY.Location = new System.Drawing.Point(474, 15);
            this.Btn_ResetXY.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ResetXY.Name = "Btn_ResetXY";
            this.Btn_ResetXY.Size = new System.Drawing.Size(111, 28);
            this.Btn_ResetXY.TabIndex = 14;
            this.Btn_ResetXY.Text = "Reset(0,0)";
            this.Btn_ResetXY.UseVisualStyleBackColor = true;
            this.Btn_ResetXY.Click += new System.EventHandler(this.Btn_ResetXY_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(871, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "DC ";
            // 
            // Btn_Cleardmm
            // 
            this.Btn_Cleardmm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cleardmm.Location = new System.Drawing.Point(355, 15);
            this.Btn_Cleardmm.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cleardmm.Name = "Btn_Cleardmm";
            this.Btn_Cleardmm.Size = new System.Drawing.Size(111, 28);
            this.Btn_Cleardmm.TabIndex = 17;
            this.Btn_Cleardmm.Text = "Clear(DMM)";
            this.Btn_Cleardmm.UseVisualStyleBackColor = true;
            this.Btn_Cleardmm.Click += new System.EventHandler(this.Btn_Cleardmm_Click);
            // 
            // Btn_SetDC
            // 
            this.Btn_SetDC.Location = new System.Drawing.Point(912, 15);
            this.Btn_SetDC.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_SetDC.Name = "Btn_SetDC";
            this.Btn_SetDC.Size = new System.Drawing.Size(117, 28);
            this.Btn_SetDC.TabIndex = 18;
            this.Btn_SetDC.Text = "MEAS DC";
            this.Btn_SetDC.UseVisualStyleBackColor = true;
            this.Btn_SetDC.Click += new System.EventHandler(this.Btn_SetDC_Click);
            // 
            // BtnError
            // 
            this.BtnError.Location = new System.Drawing.Point(589, 15);
            this.BtnError.Margin = new System.Windows.Forms.Padding(4);
            this.BtnError.Name = "BtnError";
            this.BtnError.Size = new System.Drawing.Size(111, 28);
            this.BtnError.TabIndex = 19;
            this.BtnError.Text = "Read Error";
            this.BtnError.UseVisualStyleBackColor = true;
            this.BtnError.Click += new System.EventHandler(this.BtnError_Click);
            // 
            // Btn_SetAC
            // 
            this.Btn_SetAC.Location = new System.Drawing.Point(745, 15);
            this.Btn_SetAC.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_SetAC.Name = "Btn_SetAC";
            this.Btn_SetAC.Size = new System.Drawing.Size(117, 28);
            this.Btn_SetAC.TabIndex = 21;
            this.Btn_SetAC.Text = "MEAS AC";
            this.Btn_SetAC.UseVisualStyleBackColor = true;
            this.Btn_SetAC.Click += new System.EventHandler(this.Btn_SetAC_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(709, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "AC";
            // 
            // optAxis_x
            // 
            this.optAxis_x.AutoSize = true;
            this.optAxis_x.Location = new System.Drawing.Point(15, 26);
            this.optAxis_x.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optAxis_x.Name = "optAxis_x";
            this.optAxis_x.Size = new System.Drawing.Size(64, 20);
            this.optAxis_x.TabIndex = 25;
            this.optAxis_x.Text = "Axis X";
            this.optAxis_x.UseVisualStyleBackColor = true;
            // 
            // Btnenter
            // 
            this.Btnenter.Location = new System.Drawing.Point(236, 26);
            this.Btnenter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btnenter.Name = "Btnenter";
            this.Btnenter.Size = new System.Drawing.Size(90, 45);
            this.Btnenter.TabIndex = 26;
            this.Btnenter.Text = "Enter";
            this.Btnenter.UseVisualStyleBackColor = true;
            this.Btnenter.Click += new System.EventHandler(this.Btnenter_Click);
            // 
            // txt_IPloop
            // 
            this.txt_IPloop.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_IPloop.Location = new System.Drawing.Point(86, 26);
            this.txt_IPloop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_IPloop.MaxLength = 3;
            this.txt_IPloop.Multiline = true;
            this.txt_IPloop.Name = "txt_IPloop";
            this.txt_IPloop.Size = new System.Drawing.Size(144, 41);
            this.txt_IPloop.TabIndex = 28;
            // 
            // graphBox1
            // 
            this.graphBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.graphBox1.BackColor = System.Drawing.SystemColors.Control;
            this.graphBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.graphBox1.Controls.Add(this.chartDC);
            this.graphBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphBox1.ForeColor = System.Drawing.Color.Coral;
            this.graphBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.graphBox1.Location = new System.Drawing.Point(463, 49);
            this.graphBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graphBox1.MaximumSize = new System.Drawing.Size(1600, 630);
            this.graphBox1.MinimumSize = new System.Drawing.Size(565, 0);
            this.graphBox1.Name = "graphBox1";
            this.graphBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graphBox1.Size = new System.Drawing.Size(565, 279);
            this.graphBox1.TabIndex = 29;
            this.graphBox1.TabStop = false;
            this.graphBox1.Text = "graph Data DC";
            // 
            // chartDC
            // 
            chartArea3.Name = "ChartArea1";
            this.chartDC.ChartAreas.Add(chartArea3);
            this.chartDC.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartDC.Legends.Add(legend3);
            this.chartDC.Location = new System.Drawing.Point(3, 17);
            this.chartDC.Name = "chartDC";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartDC.Series.Add(series3);
            this.chartDC.Size = new System.Drawing.Size(559, 260);
            this.chartDC.TabIndex = 0;
            this.chartDC.Text = "chart1";
            // 
            // optAxis_y
            // 
            this.optAxis_y.AutoSize = true;
            this.optAxis_y.Location = new System.Drawing.Point(15, 51);
            this.optAxis_y.Name = "optAxis_y";
            this.optAxis_y.Size = new System.Drawing.Size(65, 20);
            this.optAxis_y.TabIndex = 35;
            this.optAxis_y.TabStop = true;
            this.optAxis_y.Text = "Axis Y";
            this.optAxis_y.UseVisualStyleBackColor = true;
            // 
            // txtread
            // 
            this.txtread.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtread.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtread.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtread.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtread.Location = new System.Drawing.Point(17, 33);
            this.txtread.Margin = new System.Windows.Forms.Padding(4);
            this.txtread.Multiline = true;
            this.txtread.Name = "txtread";
            this.txtread.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtread.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtread.Size = new System.Drawing.Size(1007, 181);
            this.txtread.TabIndex = 20;
            // 
            // Boxread
            // 
            this.Boxread.Controls.Add(this.txtread);
            this.Boxread.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Boxread.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Boxread.Location = new System.Drawing.Point(0, 333);
            this.Boxread.Name = "Boxread";
            this.Boxread.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Boxread.Size = new System.Drawing.Size(1037, 227);
            this.Boxread.TabIndex = 34;
            this.Boxread.TabStop = false;
            this.Boxread.Text = "Output";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Ptgpib);
            this.groupBox2.Controls.Add(this.Ptrs232);
            this.groupBox2.Controls.Add(this.Connect);
            this.groupBox2.Controls.Add(this.BtnDiconnect);
            this.groupBox2.Location = new System.Drawing.Point(15, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 100);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "section connect";
            // 
            // Ptgpib
            // 
            this.Ptgpib.AutoSize = true;
            this.Ptgpib.Location = new System.Drawing.Point(8, 57);
            this.Ptgpib.Name = "Ptgpib";
            this.Ptgpib.Size = new System.Drawing.Size(86, 20);
            this.Ptgpib.TabIndex = 3;
            this.Ptgpib.TabStop = true;
            this.Ptgpib.Text = "GPIB Port";
            this.Ptgpib.UseVisualStyleBackColor = true;
            // 
            // Ptrs232
            // 
            this.Ptrs232.AutoSize = true;
            this.Ptrs232.Location = new System.Drawing.Point(8, 31);
            this.Ptrs232.Name = "Ptrs232";
            this.Ptrs232.Size = new System.Drawing.Size(97, 20);
            this.Ptrs232.TabIndex = 2;
            this.Ptrs232.TabStop = true;
            this.Ptrs232.Text = "Rs-232 Port";
            this.Ptrs232.UseVisualStyleBackColor = true;
            // 
            // Boxloopmotor
            // 
            this.Boxloopmotor.Controls.Add(this.Btnenter);
            this.Boxloopmotor.Controls.Add(this.txt_IPloop);
            this.Boxloopmotor.Controls.Add(this.optAxis_y);
            this.Boxloopmotor.Controls.Add(this.optAxis_x);
            this.Boxloopmotor.Location = new System.Drawing.Point(15, 117);
            this.Boxloopmotor.Name = "Boxloopmotor";
            this.Boxloopmotor.Size = new System.Drawing.Size(333, 80);
            this.Boxloopmotor.TabIndex = 37;
            this.Boxloopmotor.TabStop = false;
            this.Boxloopmotor.Text = "Set loop Stepmotor";
            // 
            // Boxposition
            // 
            this.Boxposition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Boxposition.Controls.Add(this.Btn_stepY500);
            this.Boxposition.Controls.Add(this.Btn_stepY10);
            this.Boxposition.Controls.Add(this.Btn_stepY1000);
            this.Boxposition.Controls.Add(this.Btn_movestep1000);
            this.Boxposition.Controls.Add(this.Btn_movestep500);
            this.Boxposition.Controls.Add(this.BtnMovestep);
            this.Boxposition.ForeColor = System.Drawing.Color.DarkBlue;
            this.Boxposition.Location = new System.Drawing.Point(15, 204);
            this.Boxposition.Name = "Boxposition";
            this.Boxposition.Size = new System.Drawing.Size(230, 124);
            this.Boxposition.TabIndex = 38;
            this.Boxposition.TabStop = false;
            this.Boxposition.Text = "MStep position";
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 4800;
            this.serialPort.PortName = "COM5";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1037, 560);
            this.Controls.Add(this.Boxposition);
            this.Controls.Add(this.Boxloopmotor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnError);
            this.Controls.Add(this.Boxread);
            this.Controls.Add(this.graphBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_SetAC);
            this.Controls.Add(this.Btn_SetDC);
            this.Controls.Add(this.Btn_Cleardmm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_ResetXY);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Physics101";
            this.graphBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDC)).EndInit();
            this.Boxread.ResumeLayout(false);
            this.Boxread.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Boxloopmotor.ResumeLayout(false);
            this.Boxloopmotor.PerformLayout();
            this.Boxposition.ResumeLayout(false);
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

        private System.Windows.Forms.Button Btn_movestep500;
        private System.Windows.Forms.Button Btn_movestep1000;
        private System.Windows.Forms.Button Btn_ResetXY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Cleardmm;
        private System.Windows.Forms.Button Btn_SetDC;
        private System.Windows.Forms.Button BtnError;
        private System.Windows.Forms.Button Btn_SetAC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton optAxis_x;
        private System.Windows.Forms.Button Btnenter;
        private System.Windows.Forms.TextBox txt_IPloop;
        private System.Windows.Forms.GroupBox graphBox1;
        private System.Windows.Forms.RadioButton optAxis_y;
        private System.Windows.Forms.TextBox txtread;
        private System.Windows.Forms.GroupBox Boxread;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Ptgpib;
        private System.Windows.Forms.RadioButton Ptrs232;
        private System.Windows.Forms.GroupBox Boxloopmotor;
        private System.Windows.Forms.GroupBox Boxposition;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDC;
        private System.IO.Ports.SerialPort serialPort;
    }
}

