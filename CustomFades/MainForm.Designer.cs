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
            this.lbFadeOut = new System.Windows.Forms.Label();
            this.nudFadeOut = new System.Windows.Forms.NumericUpDown();
            this.cbxFadeOutToZero = new System.Windows.Forms.CheckBox();
            this.lbFadeOutCurve = new System.Windows.Forms.Label();
            this.cbxFadeOutCurve = new System.Windows.Forms.ComboBox();
            this.cbxChangeFadeOutCurveType = new System.Windows.Forms.CheckBox();
            this.cbxFadeOutTimecode = new System.Windows.Forms.ComboBox();
            this.FadeInGroup = new System.Windows.Forms.GroupBox();
            this.cbxFIAddLength = new System.Windows.Forms.CheckBox();
            this.cbxFIReduceLength = new System.Windows.Forms.CheckBox();
            this.lbFadeIn = new System.Windows.Forms.Label();
            this.cbxFadeInToZero = new System.Windows.Forms.CheckBox();
            this.nudFadeIn = new System.Windows.Forms.NumericUpDown();
            this.lbFadeInCurve = new System.Windows.Forms.Label();
            this.cbxFadeInCurve = new System.Windows.Forms.ComboBox();
            this.cbxFadeInTimecode = new System.Windows.Forms.ComboBox();
            this.cbxChangeFadeInCurveType = new System.Windows.Forms.CheckBox();
            this.btRun = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiCreator = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.FadeOutGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFadeOut)).BeginInit();
            this.FadeInGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFadeIn)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // FadeOutGroup
            // 
            this.FadeOutGroup.Controls.Add(this.cbxFOAddLength);
            this.FadeOutGroup.Controls.Add(this.cbxFOReduceLength);
            this.FadeOutGroup.Controls.Add(this.lbFadeOut);
            this.FadeOutGroup.Controls.Add(this.nudFadeOut);
            this.FadeOutGroup.Controls.Add(this.cbxFadeOutToZero);
            this.FadeOutGroup.Controls.Add(this.lbFadeOutCurve);
            this.FadeOutGroup.Controls.Add(this.cbxFadeOutCurve);
            this.FadeOutGroup.Controls.Add(this.cbxChangeFadeOutCurveType);
            this.FadeOutGroup.Controls.Add(this.cbxFadeOutTimecode);
            this.FadeOutGroup.ForeColor = System.Drawing.Color.White;
            this.FadeOutGroup.Location = new System.Drawing.Point(12, 144);
            this.FadeOutGroup.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
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
            // lbFadeOut
            // 
            this.lbFadeOut.AutoSize = true;
            this.lbFadeOut.ForeColor = System.Drawing.Color.White;
            this.lbFadeOut.Location = new System.Drawing.Point(8, 20);
            this.lbFadeOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFadeOut.Name = "lbFadeOut";
            this.lbFadeOut.Size = new System.Drawing.Size(68, 13);
            this.lbFadeOut.TabIndex = 0;
            this.lbFadeOut.Text = "New Length:";
            // 
            // nudFadeOut
            // 
            this.nudFadeOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.nudFadeOut.ForeColor = System.Drawing.Color.White;
            this.nudFadeOut.Location = new System.Drawing.Point(96, 18);
            this.nudFadeOut.Margin = new System.Windows.Forms.Padding(4);
            this.nudFadeOut.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFadeOut.Name = "nudFadeOut";
            this.nudFadeOut.Size = new System.Drawing.Size(98, 20);
            this.nudFadeOut.TabIndex = 0;
            // 
            // cbxFadeOutToZero
            // 
            this.cbxFadeOutToZero.AutoSize = true;
            this.cbxFadeOutToZero.ForeColor = System.Drawing.Color.White;
            this.cbxFadeOutToZero.Location = new System.Drawing.Point(11, 46);
            this.cbxFadeOutToZero.Name = "cbxFadeOutToZero";
            this.cbxFadeOutToZero.Size = new System.Drawing.Size(95, 17);
            this.cbxFadeOutToZero.TabIndex = 2;
            this.cbxFadeOutToZero.Text = "Set length to 0";
            this.cbxFadeOutToZero.UseVisualStyleBackColor = true;
            this.cbxFadeOutToZero.CheckedChanged += new System.EventHandler(this.cbxFadeOutToZero_CheckedChanged);
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
            // cbxFadeOutCurve
            // 
            this.cbxFadeOutCurve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cbxFadeOutCurve.Enabled = false;
            this.cbxFadeOutCurve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxFadeOutCurve.ForeColor = System.Drawing.Color.White;
            this.cbxFadeOutCurve.FormattingEnabled = true;
            this.cbxFadeOutCurve.Items.AddRange(new object[] {
            "Fast",
            "Linear",
            "Sharp",
            "Slow",
            "Smooth"});
            this.cbxFadeOutCurve.Location = new System.Drawing.Point(96, 69);
            this.cbxFadeOutCurve.Margin = new System.Windows.Forms.Padding(4);
            this.cbxFadeOutCurve.Name = "cbxFadeOutCurve";
            this.cbxFadeOutCurve.Size = new System.Drawing.Size(98, 21);
            this.cbxFadeOutCurve.TabIndex = 5;
            this.cbxFadeOutCurve.Text = "Smooth";
            // 
            // cbxChangeFadeOutCurveType
            // 
            this.cbxChangeFadeOutCurveType.AutoSize = true;
            this.cbxChangeFadeOutCurveType.ForeColor = System.Drawing.Color.White;
            this.cbxChangeFadeOutCurveType.Location = new System.Drawing.Point(200, 71);
            this.cbxChangeFadeOutCurveType.Name = "cbxChangeFadeOutCurveType";
            this.cbxChangeFadeOutCurveType.Size = new System.Drawing.Size(93, 17);
            this.cbxChangeFadeOutCurveType.TabIndex = 6;
            this.cbxChangeFadeOutCurveType.Text = "Change curve";
            this.cbxChangeFadeOutCurveType.UseVisualStyleBackColor = true;
            this.cbxChangeFadeOutCurveType.CheckedChanged += new System.EventHandler(this.cbxChangeFadeOutCurveType_CheckedChanged);
            // 
            // cbxFadeOutTimecode
            // 
            this.cbxFadeOutTimecode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cbxFadeOutTimecode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxFadeOutTimecode.ForeColor = System.Drawing.Color.White;
            this.cbxFadeOutTimecode.FormattingEnabled = true;
            this.cbxFadeOutTimecode.Items.AddRange(new object[] {
            "Frames",
            "Seconds"});
            this.cbxFadeOutTimecode.Location = new System.Drawing.Point(200, 17);
            this.cbxFadeOutTimecode.Margin = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.cbxFadeOutTimecode.Name = "cbxFadeOutTimecode";
            this.cbxFadeOutTimecode.Size = new System.Drawing.Size(118, 21);
            this.cbxFadeOutTimecode.TabIndex = 1;
            this.cbxFadeOutTimecode.Text = "Frames";
            // 
            // FadeInGroup
            // 
            this.FadeInGroup.Controls.Add(this.cbxFIAddLength);
            this.FadeInGroup.Controls.Add(this.cbxFIReduceLength);
            this.FadeInGroup.Controls.Add(this.lbFadeIn);
            this.FadeInGroup.Controls.Add(this.cbxFadeInToZero);
            this.FadeInGroup.Controls.Add(this.nudFadeIn);
            this.FadeInGroup.Controls.Add(this.lbFadeInCurve);
            this.FadeInGroup.Controls.Add(this.cbxFadeInCurve);
            this.FadeInGroup.Controls.Add(this.cbxFadeInTimecode);
            this.FadeInGroup.Controls.Add(this.cbxChangeFadeInCurveType);
            this.FadeInGroup.ForeColor = System.Drawing.Color.White;
            this.FadeInGroup.Location = new System.Drawing.Point(12, 36);
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
            // lbFadeIn
            // 
            this.lbFadeIn.AutoSize = true;
            this.lbFadeIn.ForeColor = System.Drawing.Color.White;
            this.lbFadeIn.Location = new System.Drawing.Point(8, 20);
            this.lbFadeIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFadeIn.Name = "lbFadeIn";
            this.lbFadeIn.Size = new System.Drawing.Size(68, 13);
            this.lbFadeIn.TabIndex = 0;
            this.lbFadeIn.Text = "New Length:";
            // 
            // cbxFadeInToZero
            // 
            this.cbxFadeInToZero.AutoSize = true;
            this.cbxFadeInToZero.ForeColor = System.Drawing.Color.White;
            this.cbxFadeInToZero.Location = new System.Drawing.Point(11, 46);
            this.cbxFadeInToZero.Name = "cbxFadeInToZero";
            this.cbxFadeInToZero.Size = new System.Drawing.Size(95, 17);
            this.cbxFadeInToZero.TabIndex = 2;
            this.cbxFadeInToZero.Text = "Set length to 0";
            this.cbxFadeInToZero.UseVisualStyleBackColor = true;
            this.cbxFadeInToZero.CheckedChanged += new System.EventHandler(this.cbxFadeInToZero_CheckedChanged);
            // 
            // nudFadeIn
            // 
            this.nudFadeIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.nudFadeIn.ForeColor = System.Drawing.Color.White;
            this.nudFadeIn.Location = new System.Drawing.Point(96, 18);
            this.nudFadeIn.Margin = new System.Windows.Forms.Padding(4);
            this.nudFadeIn.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFadeIn.Name = "nudFadeIn";
            this.nudFadeIn.Size = new System.Drawing.Size(98, 20);
            this.nudFadeIn.TabIndex = 0;
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
            // cbxFadeInCurve
            // 
            this.cbxFadeInCurve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cbxFadeInCurve.Enabled = false;
            this.cbxFadeInCurve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxFadeInCurve.ForeColor = System.Drawing.Color.White;
            this.cbxFadeInCurve.FormattingEnabled = true;
            this.cbxFadeInCurve.Items.AddRange(new object[] {
            "Fast",
            "Linear",
            "Sharp",
            "Slow",
            "Smooth"});
            this.cbxFadeInCurve.Location = new System.Drawing.Point(96, 69);
            this.cbxFadeInCurve.Margin = new System.Windows.Forms.Padding(4);
            this.cbxFadeInCurve.Name = "cbxFadeInCurve";
            this.cbxFadeInCurve.Size = new System.Drawing.Size(98, 21);
            this.cbxFadeInCurve.TabIndex = 5;
            this.cbxFadeInCurve.Text = "Smooth";
            // 
            // cbxFadeInTimecode
            // 
            this.cbxFadeInTimecode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cbxFadeInTimecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxFadeInTimecode.ForeColor = System.Drawing.Color.White;
            this.cbxFadeInTimecode.FormattingEnabled = true;
            this.cbxFadeInTimecode.Items.AddRange(new object[] {
            "Frames",
            "Seconds"});
            this.cbxFadeInTimecode.Location = new System.Drawing.Point(200, 17);
            this.cbxFadeInTimecode.Margin = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.cbxFadeInTimecode.Name = "cbxFadeInTimecode";
            this.cbxFadeInTimecode.Size = new System.Drawing.Size(118, 21);
            this.cbxFadeInTimecode.TabIndex = 1;
            this.cbxFadeInTimecode.Text = "Frames";
            // 
            // cbxChangeFadeInCurveType
            // 
            this.cbxChangeFadeInCurveType.AutoSize = true;
            this.cbxChangeFadeInCurveType.ForeColor = System.Drawing.Color.White;
            this.cbxChangeFadeInCurveType.Location = new System.Drawing.Point(200, 72);
            this.cbxChangeFadeInCurveType.Name = "cbxChangeFadeInCurveType";
            this.cbxChangeFadeInCurveType.Size = new System.Drawing.Size(93, 17);
            this.cbxChangeFadeInCurveType.TabIndex = 6;
            this.cbxChangeFadeInCurveType.Text = "Change curve";
            this.cbxChangeFadeInCurveType.UseVisualStyleBackColor = true;
            this.cbxChangeFadeInCurveType.CheckedChanged += new System.EventHandler(this.cbxChangeFadeInCurveType_CheckedChanged);
            // 
            // btRun
            // 
            this.btRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(93)))), ((int)(((byte)(137)))));
            this.btRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRun.ForeColor = System.Drawing.Color.White;
            this.btRun.Location = new System.Drawing.Point(12, 256);
            this.btRun.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(329, 26);
            this.btRun.TabIndex = 16;
            this.btRun.Text = "Run";
            this.btRun.UseVisualStyleBackColor = false;
            this.btRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreator,
            this.tsmiAbout});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(353, 24);
            this.menuStrip.TabIndex = 18;
            this.menuStrip.Text = "menuStrip";
            // 
            // tsmiCreator
            // 
            this.tsmiCreator.ForeColor = System.Drawing.Color.White;
            this.tsmiCreator.Name = "tsmiCreator";
            this.tsmiCreator.Size = new System.Drawing.Size(58, 20);
            this.tsmiCreator.Text = "Creator";
            this.tsmiCreator.Click += new System.EventHandler(this.tsmiCreator_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudFadeOut)).EndInit();
            this.FadeInGroup.ResumeLayout(false);
            this.FadeInGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFadeIn)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.GroupBox FadeOutGroup;
        private System.Windows.Forms.CheckBox cbxFOAddLength;
        private System.Windows.Forms.CheckBox cbxFOReduceLength;
        private System.Windows.Forms.Label lbFadeOut;
        private System.Windows.Forms.NumericUpDown nudFadeOut;
        private System.Windows.Forms.CheckBox cbxFadeOutToZero;
        private System.Windows.Forms.Label lbFadeOutCurve;
        private System.Windows.Forms.ComboBox cbxFadeOutCurve;
        private System.Windows.Forms.CheckBox cbxChangeFadeOutCurveType;
        private System.Windows.Forms.ComboBox cbxFadeOutTimecode;
        private System.Windows.Forms.GroupBox FadeInGroup;
        private System.Windows.Forms.CheckBox cbxFIAddLength;
        private System.Windows.Forms.CheckBox cbxFIReduceLength;
        private System.Windows.Forms.Label lbFadeIn;
        private System.Windows.Forms.CheckBox cbxFadeInToZero;
        private System.Windows.Forms.NumericUpDown nudFadeIn;
        private System.Windows.Forms.Label lbFadeInCurve;
        private System.Windows.Forms.ComboBox cbxFadeInCurve;
        private System.Windows.Forms.ComboBox cbxFadeInTimecode;
        private System.Windows.Forms.CheckBox cbxChangeFadeInCurveType;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreator;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
    }
}

