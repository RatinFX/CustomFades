namespace CustomFades
{
	partial class MainForm
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
            this.FadeOutGroup = new System.Windows.Forms.GroupBox();
            this.cbxFOAddLength = new System.Windows.Forms.CheckBox();
            this.cbxFOReduceLength = new System.Windows.Forms.CheckBox();
            this.lblFO = new System.Windows.Forms.Label();
            this.nudFO = new System.Windows.Forms.NumericUpDown();
            this.cbxFOToZero = new System.Windows.Forms.CheckBox();
            this.lbFadeOutCurve = new System.Windows.Forms.Label();
            this.cbxFOCurve = new System.Windows.Forms.ComboBox();
            this.cbxChangeFOCurveType = new System.Windows.Forms.CheckBox();
            this.cbxFOTimecode = new System.Windows.Forms.ComboBox();
            this.FadeInGroup = new System.Windows.Forms.GroupBox();
            this.cbxFIAddLength = new System.Windows.Forms.CheckBox();
            this.cbxFIReduceLength = new System.Windows.Forms.CheckBox();
            this.lblFI = new System.Windows.Forms.Label();
            this.cbxFIToZero = new System.Windows.Forms.CheckBox();
            this.nudFI = new System.Windows.Forms.NumericUpDown();
            this.lbFadeInCurve = new System.Windows.Forms.Label();
            this.cbxFICurve = new System.Windows.Forms.ComboBox();
            this.cbxFITimecode = new System.Windows.Forms.ComboBox();
            this.cbxChangeFICurveType = new System.Windows.Forms.CheckBox();
            this.btRun = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiCreatedByRatinFX = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.FadeOutGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFO)).BeginInit();
            this.FadeInGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFI)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // FadeOutGroup
            // 
            this.FadeOutGroup.Controls.Add(this.cbxFOAddLength);
            this.FadeOutGroup.Controls.Add(this.cbxFOReduceLength);
            this.FadeOutGroup.Controls.Add(this.lblFO);
            this.FadeOutGroup.Controls.Add(this.nudFO);
            this.FadeOutGroup.Controls.Add(this.cbxFOToZero);
            this.FadeOutGroup.Controls.Add(this.lbFadeOutCurve);
            this.FadeOutGroup.Controls.Add(this.cbxFOCurve);
            this.FadeOutGroup.Controls.Add(this.cbxChangeFOCurveType);
            this.FadeOutGroup.Controls.Add(this.cbxFOTimecode);
            this.FadeOutGroup.ForeColor = System.Drawing.Color.White;
            this.FadeOutGroup.Location = new System.Drawing.Point(12, 144);
            this.FadeOutGroup.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.FadeOutGroup.Name = "FadeOutGroup";
            this.FadeOutGroup.Size = new System.Drawing.Size(329, 102);
            this.FadeOutGroup.TabIndex = 15;
            this.FadeOutGroup.TabStop = false;
            this.FadeOutGroup.Text = "Fade out";
            // 
            // cbxFOAddLength
            // 
            this.cbxFOAddLength.AutoSize = true;
            this.cbxFOAddLength.ForeColor = System.Drawing.Color.White;
            this.cbxFOAddLength.Location = new System.Drawing.Point(112, 46);
            this.cbxFOAddLength.Name = "cbxFOAddLength";
            this.cbxFOAddLength.Size = new System.Drawing.Size(77, 17);
            this.cbxFOAddLength.TabIndex = 3;
            this.cbxFOAddLength.Text = "Add length";
            this.cbxFOAddLength.UseVisualStyleBackColor = true;
            this.cbxFOAddLength.CheckedChanged += new System.EventHandler(this.cbxFOAddLength_CheckedChanged);
            // 
            // cbxFOReduceLength
            // 
            this.cbxFOReduceLength.AutoSize = true;
            this.cbxFOReduceLength.ForeColor = System.Drawing.Color.White;
            this.cbxFOReduceLength.Location = new System.Drawing.Point(200, 46);
            this.cbxFOReduceLength.Name = "cbxFOReduceLength";
            this.cbxFOReduceLength.Size = new System.Drawing.Size(100, 17);
            this.cbxFOReduceLength.TabIndex = 4;
            this.cbxFOReduceLength.Text = "Reduce Length";
            this.cbxFOReduceLength.UseVisualStyleBackColor = true;
            this.cbxFOReduceLength.CheckedChanged += new System.EventHandler(this.cbxFOReduceLength_CheckedChanged);
            // 
            // lblFO
            // 
            this.lblFO.AutoSize = true;
            this.lblFO.ForeColor = System.Drawing.Color.White;
            this.lblFO.Location = new System.Drawing.Point(8, 20);
            this.lblFO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFO.Name = "lblFO";
            this.lblFO.Size = new System.Drawing.Size(68, 13);
            this.lblFO.TabIndex = 0;
            this.lblFO.Text = "New Length:";
            // 
            // nudFO
            // 
            this.nudFO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.nudFO.ForeColor = System.Drawing.Color.White;
            this.nudFO.Location = new System.Drawing.Point(96, 18);
            this.nudFO.Margin = new System.Windows.Forms.Padding(4);
            this.nudFO.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFO.Name = "nudFO";
            this.nudFO.Size = new System.Drawing.Size(98, 20);
            this.nudFO.TabIndex = 0;
            // 
            // cbxFOToZero
            // 
            this.cbxFOToZero.AutoSize = true;
            this.cbxFOToZero.ForeColor = System.Drawing.Color.White;
            this.cbxFOToZero.Location = new System.Drawing.Point(11, 46);
            this.cbxFOToZero.Name = "cbxFOToZero";
            this.cbxFOToZero.Size = new System.Drawing.Size(95, 17);
            this.cbxFOToZero.TabIndex = 2;
            this.cbxFOToZero.Text = "Set length to 0";
            this.cbxFOToZero.UseVisualStyleBackColor = true;
            this.cbxFOToZero.CheckedChanged += new System.EventHandler(this.cbxFOToZero_CheckedChanged);
            // 
            // lbFadeOutCurve
            // 
            this.lbFadeOutCurve.AutoSize = true;
            this.lbFadeOutCurve.ForeColor = System.Drawing.Color.White;
            this.lbFadeOutCurve.Location = new System.Drawing.Point(8, 72);
            this.lbFadeOutCurve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFadeOutCurve.Name = "lbFadeOutCurve";
            this.lbFadeOutCurve.Size = new System.Drawing.Size(61, 13);
            this.lbFadeOutCurve.TabIndex = 2;
            this.lbFadeOutCurve.Text = "Curve type:";
            // 
            // cbxFOCurve
            // 
            this.cbxFOCurve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cbxFOCurve.Enabled = false;
            this.cbxFOCurve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxFOCurve.ForeColor = System.Drawing.Color.White;
            this.cbxFOCurve.FormattingEnabled = true;
            this.cbxFOCurve.Items.AddRange(new object[] {
            "Fast",
            "Linear",
            "Sharp",
            "Slow",
            "Smooth"});
            this.cbxFOCurve.Location = new System.Drawing.Point(96, 69);
            this.cbxFOCurve.Margin = new System.Windows.Forms.Padding(4);
            this.cbxFOCurve.Name = "cbxFOCurve";
            this.cbxFOCurve.Size = new System.Drawing.Size(98, 21);
            this.cbxFOCurve.TabIndex = 5;
            this.cbxFOCurve.Text = "Smooth";
            // 
            // cbxChangeFOCurveType
            // 
            this.cbxChangeFOCurveType.AutoSize = true;
            this.cbxChangeFOCurveType.ForeColor = System.Drawing.Color.White;
            this.cbxChangeFOCurveType.Location = new System.Drawing.Point(200, 71);
            this.cbxChangeFOCurveType.Name = "cbxChangeFOCurveType";
            this.cbxChangeFOCurveType.Size = new System.Drawing.Size(93, 17);
            this.cbxChangeFOCurveType.TabIndex = 6;
            this.cbxChangeFOCurveType.Text = "Change curve";
            this.cbxChangeFOCurveType.UseVisualStyleBackColor = true;
            this.cbxChangeFOCurveType.CheckedChanged += new System.EventHandler(this.cbxChangeFOCurveType_CheckedChanged);
            // 
            // cbxFOTimecode
            // 
            this.cbxFOTimecode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cbxFOTimecode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxFOTimecode.ForeColor = System.Drawing.Color.White;
            this.cbxFOTimecode.FormattingEnabled = true;
            this.cbxFOTimecode.Items.AddRange(new object[] {
            "Frames",
            "Seconds"});
            this.cbxFOTimecode.Location = new System.Drawing.Point(200, 17);
            this.cbxFOTimecode.Margin = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.cbxFOTimecode.Name = "cbxFOTimecode";
            this.cbxFOTimecode.Size = new System.Drawing.Size(118, 21);
            this.cbxFOTimecode.TabIndex = 1;
            this.cbxFOTimecode.Text = "Frames";
            // 
            // FadeInGroup
            // 
            this.FadeInGroup.Controls.Add(this.cbxFIAddLength);
            this.FadeInGroup.Controls.Add(this.cbxFIReduceLength);
            this.FadeInGroup.Controls.Add(this.lblFI);
            this.FadeInGroup.Controls.Add(this.cbxFIToZero);
            this.FadeInGroup.Controls.Add(this.nudFI);
            this.FadeInGroup.Controls.Add(this.lbFadeInCurve);
            this.FadeInGroup.Controls.Add(this.cbxFICurve);
            this.FadeInGroup.Controls.Add(this.cbxFITimecode);
            this.FadeInGroup.Controls.Add(this.cbxChangeFICurveType);
            this.FadeInGroup.ForeColor = System.Drawing.Color.White;
            this.FadeInGroup.Location = new System.Drawing.Point(12, 34);
            this.FadeInGroup.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.FadeInGroup.Name = "FadeInGroup";
            this.FadeInGroup.Size = new System.Drawing.Size(329, 102);
            this.FadeInGroup.TabIndex = 14;
            this.FadeInGroup.TabStop = false;
            this.FadeInGroup.Text = "Fade in";
            // 
            // cbxFIAddLength
            // 
            this.cbxFIAddLength.AutoSize = true;
            this.cbxFIAddLength.ForeColor = System.Drawing.Color.White;
            this.cbxFIAddLength.Location = new System.Drawing.Point(112, 46);
            this.cbxFIAddLength.Name = "cbxFIAddLength";
            this.cbxFIAddLength.Size = new System.Drawing.Size(77, 17);
            this.cbxFIAddLength.TabIndex = 3;
            this.cbxFIAddLength.Text = "Add length";
            this.cbxFIAddLength.UseVisualStyleBackColor = true;
            this.cbxFIAddLength.CheckedChanged += new System.EventHandler(this.cbxFIAddLength_CheckedChanged);
            // 
            // cbxFIReduceLength
            // 
            this.cbxFIReduceLength.AutoSize = true;
            this.cbxFIReduceLength.ForeColor = System.Drawing.Color.White;
            this.cbxFIReduceLength.Location = new System.Drawing.Point(200, 46);
            this.cbxFIReduceLength.Name = "cbxFIReduceLength";
            this.cbxFIReduceLength.Size = new System.Drawing.Size(100, 17);
            this.cbxFIReduceLength.TabIndex = 4;
            this.cbxFIReduceLength.Text = "Reduce Length";
            this.cbxFIReduceLength.UseVisualStyleBackColor = true;
            this.cbxFIReduceLength.CheckedChanged += new System.EventHandler(this.cbxFIReduceLength_CheckedChanged);
            // 
            // lblFI
            // 
            this.lblFI.AutoSize = true;
            this.lblFI.ForeColor = System.Drawing.Color.White;
            this.lblFI.Location = new System.Drawing.Point(8, 20);
            this.lblFI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFI.Name = "lblFI";
            this.lblFI.Size = new System.Drawing.Size(68, 13);
            this.lblFI.TabIndex = 0;
            this.lblFI.Text = "New Length:";
            // 
            // cbxFIToZero
            // 
            this.cbxFIToZero.AutoSize = true;
            this.cbxFIToZero.ForeColor = System.Drawing.Color.White;
            this.cbxFIToZero.Location = new System.Drawing.Point(11, 46);
            this.cbxFIToZero.Name = "cbxFIToZero";
            this.cbxFIToZero.Size = new System.Drawing.Size(95, 17);
            this.cbxFIToZero.TabIndex = 2;
            this.cbxFIToZero.Text = "Set length to 0";
            this.cbxFIToZero.UseVisualStyleBackColor = true;
            this.cbxFIToZero.CheckedChanged += new System.EventHandler(this.cbxFIToZero_CheckedChanged);
            // 
            // nudFI
            // 
            this.nudFI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.nudFI.ForeColor = System.Drawing.Color.White;
            this.nudFI.Location = new System.Drawing.Point(96, 18);
            this.nudFI.Margin = new System.Windows.Forms.Padding(4);
            this.nudFI.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFI.Name = "nudFI";
            this.nudFI.Size = new System.Drawing.Size(98, 20);
            this.nudFI.TabIndex = 0;
            // 
            // lbFadeInCurve
            // 
            this.lbFadeInCurve.AutoSize = true;
            this.lbFadeInCurve.ForeColor = System.Drawing.Color.White;
            this.lbFadeInCurve.Location = new System.Drawing.Point(8, 72);
            this.lbFadeInCurve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFadeInCurve.Name = "lbFadeInCurve";
            this.lbFadeInCurve.Size = new System.Drawing.Size(61, 13);
            this.lbFadeInCurve.TabIndex = 2;
            this.lbFadeInCurve.Text = "Curve type:";
            // 
            // cbxFICurve
            // 
            this.cbxFICurve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cbxFICurve.Enabled = false;
            this.cbxFICurve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxFICurve.ForeColor = System.Drawing.Color.White;
            this.cbxFICurve.FormattingEnabled = true;
            this.cbxFICurve.Items.AddRange(new object[] {
            "Fast",
            "Linear",
            "Sharp",
            "Slow",
            "Smooth"});
            this.cbxFICurve.Location = new System.Drawing.Point(96, 69);
            this.cbxFICurve.Margin = new System.Windows.Forms.Padding(4);
            this.cbxFICurve.Name = "cbxFICurve";
            this.cbxFICurve.Size = new System.Drawing.Size(98, 21);
            this.cbxFICurve.TabIndex = 5;
            this.cbxFICurve.Text = "Smooth";
            // 
            // cbxFITimecode
            // 
            this.cbxFITimecode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cbxFITimecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxFITimecode.ForeColor = System.Drawing.Color.White;
            this.cbxFITimecode.FormattingEnabled = true;
            this.cbxFITimecode.Items.AddRange(new object[] {
            "Frames",
            "Seconds"});
            this.cbxFITimecode.Location = new System.Drawing.Point(200, 17);
            this.cbxFITimecode.Margin = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.cbxFITimecode.Name = "cbxFITimecode";
            this.cbxFITimecode.Size = new System.Drawing.Size(118, 21);
            this.cbxFITimecode.TabIndex = 1;
            this.cbxFITimecode.Text = "Frames";
            // 
            // cbxChangeFICurveType
            // 
            this.cbxChangeFICurveType.AutoSize = true;
            this.cbxChangeFICurveType.ForeColor = System.Drawing.Color.White;
            this.cbxChangeFICurveType.Location = new System.Drawing.Point(200, 72);
            this.cbxChangeFICurveType.Name = "cbxChangeFICurveType";
            this.cbxChangeFICurveType.Size = new System.Drawing.Size(93, 17);
            this.cbxChangeFICurveType.TabIndex = 6;
            this.cbxChangeFICurveType.Text = "Change curve";
            this.cbxChangeFICurveType.UseVisualStyleBackColor = true;
            this.cbxChangeFICurveType.CheckedChanged += new System.EventHandler(this.cbxChangeFICurveType_CheckedChanged);
            // 
            // btRun
            // 
            this.btRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(93)))), ((int)(((byte)(137)))));
            this.btRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRun.ForeColor = System.Drawing.Color.White;
            this.btRun.Location = new System.Drawing.Point(12, 254);
            this.btRun.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(329, 28);
            this.btRun.TabIndex = 16;
            this.btRun.Text = "Run";
            this.btRun.UseVisualStyleBackColor = false;
            this.btRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreatedByRatinFX,
            this.tsmiAbout});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(353, 24);
            this.menuStrip.TabIndex = 18;
            this.menuStrip.Text = "menuStrip";
            // 
            // tsmiCreatedByRatinFX
            // 
            this.tsmiCreatedByRatinFX.ForeColor = System.Drawing.Color.White;
            this.tsmiCreatedByRatinFX.Name = "tsmiCreatedByRatinFX";
            this.tsmiCreatedByRatinFX.Size = new System.Drawing.Size(119, 20);
            this.tsmiCreatedByRatinFX.Text = "Created by RatinFX";
            this.tsmiCreatedByRatinFX.Click += new System.EventHandler(this.tsmiCreatedByRatinFX_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.ForeColor = System.Drawing.Color.White;
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(52, 20);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(353, 294);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.FadeOutGroup);
            this.Controls.Add(this.FadeInGroup);
            this.Controls.Add(this.btRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Custom fades";
            this.FadeOutGroup.ResumeLayout(false);
            this.FadeOutGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFO)).EndInit();
            this.FadeInGroup.ResumeLayout(false);
            this.FadeInGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFI)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.GroupBox FadeOutGroup;
        private System.Windows.Forms.CheckBox cbxFOAddLength;
        private System.Windows.Forms.CheckBox cbxFOReduceLength;
        private System.Windows.Forms.Label lblFO;
        private System.Windows.Forms.NumericUpDown nudFO;
        private System.Windows.Forms.CheckBox cbxFOToZero;
        private System.Windows.Forms.Label lbFadeOutCurve;
        private System.Windows.Forms.ComboBox cbxFOCurve;
        private System.Windows.Forms.CheckBox cbxChangeFOCurveType;
        private System.Windows.Forms.ComboBox cbxFOTimecode;
        private System.Windows.Forms.GroupBox FadeInGroup;
        private System.Windows.Forms.CheckBox cbxFIAddLength;
        private System.Windows.Forms.CheckBox cbxFIReduceLength;
        private System.Windows.Forms.Label lblFI;
        private System.Windows.Forms.CheckBox cbxFIToZero;
        private System.Windows.Forms.NumericUpDown nudFI;
        private System.Windows.Forms.Label lbFadeInCurve;
        private System.Windows.Forms.ComboBox cbxFICurve;
        private System.Windows.Forms.ComboBox cbxFITimecode;
        private System.Windows.Forms.CheckBox cbxChangeFICurveType;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreatedByRatinFX;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
    }
}

