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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.rangelabel = new System.Windows.Forms.Label();
            this.CBtrigger = new System.Windows.Forms.ComboBox();
            this.STriggerlabel = new System.Windows.Forms.Label();
            this.CBrange = new System.Windows.Forms.ComboBox();
            this.Delaylabel = new System.Windows.Forms.Label();
            this.CBdelay = new System.Windows.Forms.ComboBox();
            this.UnitTime = new System.Windows.Forms.Label();
            this.RBvoltage = new System.Windows.Forms.RadioButton();
            this.RBcurrent = new System.Windows.Forms.RadioButton();
            this.GBMeas = new System.Windows.Forms.GroupBox();
            this.GBSource = new System.Windows.Forms.GroupBox();
            this.RBsource_AC = new System.Windows.Forms.RadioButton();
            this.RBsource_DC = new System.Windows.Forms.RadioButton();
            this.Btn_Setup = new System.Windows.Forms.Button();
            this.Btn_Error = new System.Windows.Forms.Button();
            this.Btn_read = new System.Windows.Forms.Button();
            this.Btn_clear = new System.Windows.Forms.Button();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.GBMeas.SuspendLayout();
            this.GBSource.SuspendLayout();
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
            // rangelabel
            // 
            this.rangelabel.AutoSize = true;
            this.rangelabel.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangelabel.ForeColor = System.Drawing.Color.White;
            this.rangelabel.Location = new System.Drawing.Point(54, 314);
            this.rangelabel.Name = "rangelabel";
            this.rangelabel.Size = new System.Drawing.Size(73, 21);
            this.rangelabel.TabIndex = 3;
            this.rangelabel.Text = "Range :";
            // 
            // CBtrigger
            // 
            this.CBtrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBtrigger.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBtrigger.FormattingEnabled = true;
            this.CBtrigger.Location = new System.Drawing.Point(133, 350);
            this.CBtrigger.Name = "CBtrigger";
            this.CBtrigger.Size = new System.Drawing.Size(155, 36);
            this.CBtrigger.TabIndex = 4;
            // 
            // STriggerlabel
            // 
            this.STriggerlabel.AutoSize = true;
            this.STriggerlabel.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STriggerlabel.ForeColor = System.Drawing.Color.White;
            this.STriggerlabel.Location = new System.Drawing.Point(36, 344);
            this.STriggerlabel.Name = "STriggerlabel";
            this.STriggerlabel.Size = new System.Drawing.Size(91, 42);
            this.STriggerlabel.TabIndex = 5;
            this.STriggerlabel.Text = "Source \r\nTrigger :";
            // 
            // CBrange
            // 
            this.CBrange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBrange.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBrange.FormattingEnabled = true;
            this.CBrange.Location = new System.Drawing.Point(133, 305);
            this.CBrange.Name = "CBrange";
            this.CBrange.Size = new System.Drawing.Size(155, 36);
            this.CBrange.TabIndex = 6;
            // 
            // Delaylabel
            // 
            this.Delaylabel.AutoSize = true;
            this.Delaylabel.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delaylabel.ForeColor = System.Drawing.Color.White;
            this.Delaylabel.Location = new System.Drawing.Point(9, 403);
            this.Delaylabel.Name = "Delaylabel";
            this.Delaylabel.Size = new System.Drawing.Size(118, 21);
            this.Delaylabel.TabIndex = 7;
            this.Delaylabel.Text = "Time Delay :";
            // 
            // CBdelay
            // 
            this.CBdelay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBdelay.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBdelay.FormattingEnabled = true;
            this.CBdelay.Location = new System.Drawing.Point(133, 394);
            this.CBdelay.Name = "CBdelay";
            this.CBdelay.Size = new System.Drawing.Size(121, 36);
            this.CBdelay.TabIndex = 8;
            // 
            // UnitTime
            // 
            this.UnitTime.AutoSize = true;
            this.UnitTime.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitTime.ForeColor = System.Drawing.Color.White;
            this.UnitTime.Location = new System.Drawing.Point(260, 403);
            this.UnitTime.Name = "UnitTime";
            this.UnitTime.Size = new System.Drawing.Size(28, 21);
            this.UnitTime.TabIndex = 9;
            this.UnitTime.Text = "ms";
            // 
            // RBvoltage
            // 
            this.RBvoltage.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBvoltage.BackColor = System.Drawing.Color.LightGray;
            this.RBvoltage.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.RBvoltage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBvoltage.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBvoltage.ForeColor = System.Drawing.Color.Black;
            this.RBvoltage.Location = new System.Drawing.Point(12, 22);
            this.RBvoltage.Name = "RBvoltage";
            this.RBvoltage.Size = new System.Drawing.Size(142, 44);
            this.RBvoltage.TabIndex = 12;
            this.RBvoltage.TabStop = true;
            this.RBvoltage.Text = "Voltage";
            this.RBvoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBvoltage.UseVisualStyleBackColor = false;
            // 
            // RBcurrent
            // 
            this.RBcurrent.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBcurrent.BackColor = System.Drawing.Color.LightGray;
            this.RBcurrent.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.RBcurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBcurrent.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBcurrent.ForeColor = System.Drawing.Color.Black;
            this.RBcurrent.Location = new System.Drawing.Point(144, 22);
            this.RBcurrent.Name = "RBcurrent";
            this.RBcurrent.Size = new System.Drawing.Size(142, 44);
            this.RBcurrent.TabIndex = 13;
            this.RBcurrent.TabStop = true;
            this.RBcurrent.Text = "Current";
            this.RBcurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBcurrent.UseVisualStyleBackColor = false;
            // 
            // GBMeas
            // 
            this.GBMeas.Controls.Add(this.RBcurrent);
            this.GBMeas.Controls.Add(this.RBvoltage);
            this.GBMeas.Font = new System.Drawing.Font("Cascadia Code Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBMeas.ForeColor = System.Drawing.Color.White;
            this.GBMeas.Location = new System.Drawing.Point(19, 122);
            this.GBMeas.Name = "GBMeas";
            this.GBMeas.Size = new System.Drawing.Size(296, 81);
            this.GBMeas.TabIndex = 14;
            this.GBMeas.TabStop = false;
            this.GBMeas.Text = "Measurement";
            // 
            // GBSource
            // 
            this.GBSource.Controls.Add(this.RBsource_AC);
            this.GBSource.Controls.Add(this.RBsource_DC);
            this.GBSource.Font = new System.Drawing.Font("Cascadia Code Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBSource.ForeColor = System.Drawing.Color.White;
            this.GBSource.Location = new System.Drawing.Point(19, 209);
            this.GBSource.Name = "GBSource";
            this.GBSource.Size = new System.Drawing.Size(296, 81);
            this.GBSource.TabIndex = 15;
            this.GBSource.TabStop = false;
            this.GBSource.Text = "Source";
            // 
            // RBsource_AC
            // 
            this.RBsource_AC.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBsource_AC.BackColor = System.Drawing.Color.LightGray;
            this.RBsource_AC.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RBsource_AC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBsource_AC.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBsource_AC.ForeColor = System.Drawing.Color.Black;
            this.RBsource_AC.Location = new System.Drawing.Point(144, 22);
            this.RBsource_AC.Name = "RBsource_AC";
            this.RBsource_AC.Size = new System.Drawing.Size(142, 44);
            this.RBsource_AC.TabIndex = 13;
            this.RBsource_AC.TabStop = true;
            this.RBsource_AC.Text = "AC";
            this.RBsource_AC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBsource_AC.UseVisualStyleBackColor = false;
            // 
            // RBsource_DC
            // 
            this.RBsource_DC.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBsource_DC.BackColor = System.Drawing.Color.LightGray;
            this.RBsource_DC.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RBsource_DC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBsource_DC.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBsource_DC.ForeColor = System.Drawing.Color.Black;
            this.RBsource_DC.Location = new System.Drawing.Point(12, 22);
            this.RBsource_DC.Name = "RBsource_DC";
            this.RBsource_DC.Size = new System.Drawing.Size(138, 44);
            this.RBsource_DC.TabIndex = 12;
            this.RBsource_DC.TabStop = true;
            this.RBsource_DC.Text = "DC";
            this.RBsource_DC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBsource_DC.UseVisualStyleBackColor = false;
            // 
            // Btn_Setup
            // 
            this.Btn_Setup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Setup.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Setup.ForeColor = System.Drawing.Color.Black;
            this.Btn_Setup.Location = new System.Drawing.Point(0, 765);
            this.Btn_Setup.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Setup.Name = "Btn_Setup";
            this.Btn_Setup.Size = new System.Drawing.Size(325, 68);
            this.Btn_Setup.TabIndex = 16;
            this.Btn_Setup.Text = "Setup ";
            this.Btn_Setup.UseVisualStyleBackColor = true;
            this.Btn_Setup.Click += new System.EventHandler(this.Btn_Setup_Click);
            // 
            // Btn_Error
            // 
            this.Btn_Error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Error.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Btn_Error.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Error.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Error.ForeColor = System.Drawing.Color.White;
            this.Btn_Error.Location = new System.Drawing.Point(163, 710);
            this.Btn_Error.Name = "Btn_Error";
            this.Btn_Error.Size = new System.Drawing.Size(142, 43);
            this.Btn_Error.TabIndex = 17;
            this.Btn_Error.Text = "Check ERROR";
            this.Btn_Error.UseVisualStyleBackColor = true;
            this.Btn_Error.Click += new System.EventHandler(this.Btn_Error_Click);
            // 
            // Btn_read
            // 
            this.Btn_read.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_read.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Btn_read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_read.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_read.ForeColor = System.Drawing.Color.White;
            this.Btn_read.Location = new System.Drawing.Point(15, 710);
            this.Btn_read.Name = "Btn_read";
            this.Btn_read.Size = new System.Drawing.Size(142, 43);
            this.Btn_read.TabIndex = 18;
            this.Btn_read.Text = "READ?";
            this.Btn_read.UseVisualStyleBackColor = true;
            this.Btn_read.Click += new System.EventHandler(this.Btn_read_Click);
            // 
            // Btn_clear
            // 
            this.Btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_clear.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_clear.ForeColor = System.Drawing.Color.White;
            this.Btn_clear.Location = new System.Drawing.Point(163, 642);
            this.Btn_clear.Name = "Btn_clear";
            this.Btn_clear.Size = new System.Drawing.Size(142, 62);
            this.Btn_clear.TabIndex = 19;
            this.Btn_clear.Text = "Clear ERROR";
            this.Btn_clear.UseVisualStyleBackColor = true;
            this.Btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reset.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reset.ForeColor = System.Drawing.Color.White;
            this.Btn_Reset.Location = new System.Drawing.Point(15, 642);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(142, 62);
            this.Btn_Reset.TabIndex = 20;
            this.Btn_Reset.Text = "Reset\r\nMeasurement\r\n";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // DMMmeasure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Btn_clear);
            this.Controls.Add(this.Btn_read);
            this.Controls.Add(this.Btn_Error);
            this.Controls.Add(this.Btn_Setup);
            this.Controls.Add(this.GBSource);
            this.Controls.Add(this.GBMeas);
            this.Controls.Add(this.UnitTime);
            this.Controls.Add(this.CBdelay);
            this.Controls.Add(this.Delaylabel);
            this.Controls.Add(this.CBrange);
            this.Controls.Add(this.STriggerlabel);
            this.Controls.Add(this.CBtrigger);
            this.Controls.Add(this.rangelabel);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.LabelTop);
            this.Name = "DMMmeasure";
            this.Size = new System.Drawing.Size(325, 833);
            this.GBMeas.ResumeLayout(false);
            this.GBSource.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTop;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label rangelabel;
        private System.Windows.Forms.ComboBox CBtrigger;
        private System.Windows.Forms.Label STriggerlabel;
        private System.Windows.Forms.ComboBox CBrange;
        private System.Windows.Forms.Label Delaylabel;
        private System.Windows.Forms.ComboBox CBdelay;
        private System.Windows.Forms.Label UnitTime;
        private System.Windows.Forms.RadioButton RBvoltage;
        private System.Windows.Forms.RadioButton RBcurrent;
        private System.Windows.Forms.GroupBox GBMeas;
        private System.Windows.Forms.GroupBox GBSource;
        private System.Windows.Forms.RadioButton RBsource_AC;
        private System.Windows.Forms.RadioButton RBsource_DC;
        private System.Windows.Forms.Button Btn_Setup;
        private System.Windows.Forms.Button Btn_Error;
        private System.Windows.Forms.Button Btn_read;
        private System.Windows.Forms.Button Btn_clear;
        private System.Windows.Forms.Button Btn_Reset;
    }
}
