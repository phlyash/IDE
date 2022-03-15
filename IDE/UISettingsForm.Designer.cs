namespace IDE
{
    partial class UISettingsForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.BGCPanel = new System.Windows.Forms.Panel();
            this.BGCButton = new System.Windows.Forms.Button();
            this.BGCLabel = new System.Windows.Forms.Label();
            this.PCPanel = new System.Windows.Forms.Panel();
            this.PCButton = new System.Windows.Forms.Button();
            this.PCLabel = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.FCPanel = new System.Windows.Forms.Panel();
            this.FCButton = new System.Windows.Forms.Button();
            this.FCLabel = new System.Windows.Forms.Label();
            this.FTextBox = new System.Windows.Forms.TextBox();
            this.FButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.FLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(587, 506);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.BGCPanel);
            this.splitContainer3.Panel1.Controls.Add(this.BGCButton);
            this.splitContainer3.Panel1.Controls.Add(this.BGCLabel);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.PCPanel);
            this.splitContainer3.Panel2.Controls.Add(this.PCButton);
            this.splitContainer3.Panel2.Controls.Add(this.PCLabel);
            this.splitContainer3.Size = new System.Drawing.Size(587, 236);
            this.splitContainer3.SplitterDistance = 123;
            this.splitContainer3.TabIndex = 0;
            // 
            // BGCPanel
            // 
            this.BGCPanel.Location = new System.Drawing.Point(444, 21);
            this.BGCPanel.Name = "BGCPanel";
            this.BGCPanel.Size = new System.Drawing.Size(95, 81);
            this.BGCPanel.TabIndex = 5;
            // 
            // BGCButton
            // 
            this.BGCButton.Location = new System.Drawing.Point(181, 46);
            this.BGCButton.Name = "BGCButton";
            this.BGCButton.Size = new System.Drawing.Size(75, 23);
            this.BGCButton.TabIndex = 4;
            this.BGCButton.Text = "Choose";
            this.BGCButton.UseVisualStyleBackColor = true;
            this.BGCButton.Click += new System.EventHandler(this.BGCButton_Click);
            // 
            // BGCLabel
            // 
            this.BGCLabel.AutoSize = true;
            this.BGCLabel.Location = new System.Drawing.Point(48, 51);
            this.BGCLabel.Name = "BGCLabel";
            this.BGCLabel.Size = new System.Drawing.Size(92, 13);
            this.BGCLabel.TabIndex = 3;
            this.BGCLabel.Text = "Backgorund Color";
            // 
            // PCPanel
            // 
            this.PCPanel.Location = new System.Drawing.Point(444, 14);
            this.PCPanel.Name = "PCPanel";
            this.PCPanel.Size = new System.Drawing.Size(95, 81);
            this.PCPanel.TabIndex = 5;
            // 
            // PCButton
            // 
            this.PCButton.Location = new System.Drawing.Point(181, 39);
            this.PCButton.Name = "PCButton";
            this.PCButton.Size = new System.Drawing.Size(75, 23);
            this.PCButton.TabIndex = 4;
            this.PCButton.Text = "Choose";
            this.PCButton.UseVisualStyleBackColor = true;
            this.PCButton.Click += new System.EventHandler(this.PCButton_Click);
            // 
            // PCLabel
            // 
            this.PCLabel.AutoSize = true;
            this.PCLabel.Location = new System.Drawing.Point(48, 44);
            this.PCLabel.Name = "PCLabel";
            this.PCLabel.Size = new System.Drawing.Size(61, 13);
            this.PCLabel.TabIndex = 3;
            this.PCLabel.Text = "Panel Color";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.FCPanel);
            this.splitContainer2.Panel1.Controls.Add(this.FCButton);
            this.splitContainer2.Panel1.Controls.Add(this.FCLabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.FTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.FButton);
            this.splitContainer2.Panel2.Controls.Add(this.SaveButton);
            this.splitContainer2.Panel2.Controls.Add(this.FLabel);
            this.splitContainer2.Size = new System.Drawing.Size(587, 266);
            this.splitContainer2.SplitterDistance = 121;
            this.splitContainer2.TabIndex = 0;
            // 
            // FCPanel
            // 
            this.FCPanel.Location = new System.Drawing.Point(444, 15);
            this.FCPanel.Name = "FCPanel";
            this.FCPanel.Size = new System.Drawing.Size(95, 81);
            this.FCPanel.TabIndex = 2;
            // 
            // FCButton
            // 
            this.FCButton.Location = new System.Drawing.Point(181, 41);
            this.FCButton.Name = "FCButton";
            this.FCButton.Size = new System.Drawing.Size(75, 23);
            this.FCButton.TabIndex = 1;
            this.FCButton.Text = "Choose";
            this.FCButton.UseVisualStyleBackColor = true;
            this.FCButton.Click += new System.EventHandler(this.FCButton_Click);
            // 
            // FCLabel
            // 
            this.FCLabel.AutoSize = true;
            this.FCLabel.Location = new System.Drawing.Point(48, 46);
            this.FCLabel.Name = "FCLabel";
            this.FCLabel.Size = new System.Drawing.Size(55, 13);
            this.FCLabel.TabIndex = 0;
            this.FCLabel.Text = "Font Color";
            // 
            // FTextBox
            // 
            this.FTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.FTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FTextBox.Location = new System.Drawing.Point(444, 16);
            this.FTextBox.Multiline = true;
            this.FTextBox.Name = "FTextBox";
            this.FTextBox.ReadOnly = true;
            this.FTextBox.Size = new System.Drawing.Size(95, 81);
            this.FTextBox.TabIndex = 3;
            this.FTextBox.Text = "Pack my box with five dozen liquor jugs.\r\n\r\n\r\n";
            // 
            // FButton
            // 
            this.FButton.Location = new System.Drawing.Point(181, 41);
            this.FButton.Name = "FButton";
            this.FButton.Size = new System.Drawing.Size(75, 23);
            this.FButton.TabIndex = 2;
            this.FButton.Text = "Choose";
            this.FButton.UseVisualStyleBackColor = true;
            this.FButton.Click += new System.EventHandler(this.FButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(500, 106);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FLabel
            // 
            this.FLabel.AutoSize = true;
            this.FLabel.Location = new System.Drawing.Point(48, 46);
            this.FLabel.Name = "FLabel";
            this.FLabel.Size = new System.Drawing.Size(28, 13);
            this.FLabel.TabIndex = 0;
            this.FLabel.Text = "Font";
            // 
            // UISettingsForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(587, 506);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UISettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label FCLabel;
        private System.Windows.Forms.Label FLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel FCPanel;
        private System.Windows.Forms.Button FCButton;
        private System.Windows.Forms.TextBox FTextBox;
        private System.Windows.Forms.Button FButton;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Panel BGCPanel;
        private System.Windows.Forms.Button BGCButton;
        private System.Windows.Forms.Label BGCLabel;
        private System.Windows.Forms.Panel PCPanel;
        private System.Windows.Forms.Button PCButton;
        private System.Windows.Forms.Label PCLabel;
    }
}