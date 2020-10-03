namespace Youtubedl.Wizard.View {
    partial class StartForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.youtubeUrlTextBox = new System.Windows.Forms.TextBox();
            this.retrieveButton = new System.Windows.Forms.Button();
            this.youtubeUrlLabel = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.videoCombo = new System.Windows.Forms.ComboBox();
            this.audioCmb = new System.Windows.Forms.ComboBox();
            this.subtitleCmb = new System.Windows.Forms.ComboBox();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.AutoCaptionCheckBox = new System.Windows.Forms.CheckBox();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.AudioLabel = new System.Windows.Forms.Label();
            this.videoLabel = new System.Windows.Forms.Label();
            this.SaveFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SaveFolderTextBox = new System.Windows.Forms.TextBox();
            this.SaveFolderButton = new System.Windows.Forms.Button();
            this.SaveFolderLable = new System.Windows.Forms.Label();
            this.convertToSrtButton = new System.Windows.Forms.Button();
            this.ConverSubtitleOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.optionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // youtubeUrlTextBox
            // 
            this.youtubeUrlTextBox.Location = new System.Drawing.Point(114, 60);
            this.youtubeUrlTextBox.Name = "youtubeUrlTextBox";
            this.youtubeUrlTextBox.Size = new System.Drawing.Size(285, 20);
            this.youtubeUrlTextBox.TabIndex = 2;
            // 
            // retrieveButton
            // 
            this.retrieveButton.Location = new System.Drawing.Point(405, 59);
            this.retrieveButton.Name = "retrieveButton";
            this.retrieveButton.Size = new System.Drawing.Size(90, 22);
            this.retrieveButton.TabIndex = 3;
            this.retrieveButton.Text = "Retrieve data";
            this.retrieveButton.UseVisualStyleBackColor = true;
            this.retrieveButton.Click += new System.EventHandler(this.retrieveButton_Click);
            // 
            // youtubeUrlLabel
            // 
            this.youtubeUrlLabel.AutoSize = true;
            this.youtubeUrlLabel.Location = new System.Drawing.Point(12, 63);
            this.youtubeUrlLabel.Name = "youtubeUrlLabel";
            this.youtubeUrlLabel.Size = new System.Drawing.Size(57, 13);
            this.youtubeUrlLabel.TabIndex = 2;
            this.youtubeUrlLabel.Text = "Video url : ";
            // 
            // downloadButton
            // 
            this.downloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadButton.Location = new System.Drawing.Point(497, 296);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(75, 23);
            this.downloadButton.TabIndex = 5;
            this.downloadButton.Text = "Dowload";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // videoCombo
            // 
            this.videoCombo.DropDownWidth = 570;
            this.videoCombo.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoCombo.FormattingEnabled = true;
            this.videoCombo.Location = new System.Drawing.Point(102, 40);
            this.videoCombo.Name = "videoCombo";
            this.videoCombo.Size = new System.Drawing.Size(285, 21);
            this.videoCombo.TabIndex = 0;
            this.videoCombo.SelectedIndexChanged += new System.EventHandler(this.videoCombo_SelectedIndexChanged);
            // 
            // audioCmb
            // 
            this.audioCmb.DropDownWidth = 570;
            this.audioCmb.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audioCmb.FormattingEnabled = true;
            this.audioCmb.Location = new System.Drawing.Point(102, 67);
            this.audioCmb.Name = "audioCmb";
            this.audioCmb.Size = new System.Drawing.Size(285, 21);
            this.audioCmb.TabIndex = 1;
            // 
            // subtitleCmb
            // 
            this.subtitleCmb.DropDownWidth = 285;
            this.subtitleCmb.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleCmb.FormattingEnabled = true;
            this.subtitleCmb.Location = new System.Drawing.Point(102, 94);
            this.subtitleCmb.Name = "subtitleCmb";
            this.subtitleCmb.Size = new System.Drawing.Size(285, 21);
            this.subtitleCmb.TabIndex = 2;
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsGroupBox.Controls.Add(this.AutoCaptionCheckBox);
            this.optionsGroupBox.Controls.Add(this.subtitleLabel);
            this.optionsGroupBox.Controls.Add(this.AudioLabel);
            this.optionsGroupBox.Controls.Add(this.videoLabel);
            this.optionsGroupBox.Controls.Add(this.videoCombo);
            this.optionsGroupBox.Controls.Add(this.subtitleCmb);
            this.optionsGroupBox.Controls.Add(this.audioCmb);
            this.optionsGroupBox.Location = new System.Drawing.Point(12, 100);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(560, 162);
            this.optionsGroupBox.TabIndex = 4;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Options";
            // 
            // AutoCaptionCheckBox
            // 
            this.AutoCaptionCheckBox.AutoSize = true;
            this.AutoCaptionCheckBox.Location = new System.Drawing.Point(393, 97);
            this.AutoCaptionCheckBox.Name = "AutoCaptionCheckBox";
            this.AutoCaptionCheckBox.Size = new System.Drawing.Size(86, 17);
            this.AutoCaptionCheckBox.TabIndex = 3;
            this.AutoCaptionCheckBox.Text = "Auto caption";
            this.AutoCaptionCheckBox.UseVisualStyleBackColor = true;
            this.AutoCaptionCheckBox.CheckedChanged += new System.EventHandler(this.AutoCaptionCheckBox_CheckedChanged);
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Location = new System.Drawing.Point(6, 97);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(48, 13);
            this.subtitleLabel.TabIndex = 6;
            this.subtitleLabel.Text = "Subtitle :";
            // 
            // AudioLabel
            // 
            this.AudioLabel.AutoSize = true;
            this.AudioLabel.Location = new System.Drawing.Point(6, 70);
            this.AudioLabel.Name = "AudioLabel";
            this.AudioLabel.Size = new System.Drawing.Size(73, 13);
            this.AudioLabel.TabIndex = 6;
            this.AudioLabel.Text = "Audio quality :";
            // 
            // videoLabel
            // 
            this.videoLabel.AutoSize = true;
            this.videoLabel.Location = new System.Drawing.Point(6, 43);
            this.videoLabel.Name = "videoLabel";
            this.videoLabel.Size = new System.Drawing.Size(73, 13);
            this.videoLabel.TabIndex = 6;
            this.videoLabel.Text = "Video quality :";
            // 
            // SaveFolderBrowserDialog
            // 
            this.SaveFolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // SaveFolderTextBox
            // 
            this.SaveFolderTextBox.Location = new System.Drawing.Point(114, 34);
            this.SaveFolderTextBox.Name = "SaveFolderTextBox";
            this.SaveFolderTextBox.ReadOnly = true;
            this.SaveFolderTextBox.Size = new System.Drawing.Size(285, 20);
            this.SaveFolderTextBox.TabIndex = 0;
            this.SaveFolderTextBox.TabStop = false;
            // 
            // SaveFolderButton
            // 
            this.SaveFolderButton.Location = new System.Drawing.Point(405, 33);
            this.SaveFolderButton.Name = "SaveFolderButton";
            this.SaveFolderButton.Size = new System.Drawing.Size(90, 22);
            this.SaveFolderButton.TabIndex = 1;
            this.SaveFolderButton.Text = "Select Folder";
            this.SaveFolderButton.UseVisualStyleBackColor = true;
            this.SaveFolderButton.Click += new System.EventHandler(this.SaveFolderButton_Click);
            // 
            // SaveFolderLable
            // 
            this.SaveFolderLable.AutoSize = true;
            this.SaveFolderLable.Location = new System.Drawing.Point(12, 37);
            this.SaveFolderLable.Name = "SaveFolderLable";
            this.SaveFolderLable.Size = new System.Drawing.Size(93, 13);
            this.SaveFolderLable.TabIndex = 8;
            this.SaveFolderLable.Text = "Download folder : ";
            // 
            // convertToSrtButton
            // 
            this.convertToSrtButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.convertToSrtButton.BackColor = System.Drawing.Color.Silver;
            this.convertToSrtButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.convertToSrtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertToSrtButton.Location = new System.Drawing.Point(12, 296);
            this.convertToSrtButton.Name = "convertToSrtButton";
            this.convertToSrtButton.Size = new System.Drawing.Size(197, 23);
            this.convertToSrtButton.TabIndex = 6;
            this.convertToSrtButton.Text = "Convert VTT subtitle to srt";
            this.convertToSrtButton.UseVisualStyleBackColor = false;
            this.convertToSrtButton.Click += new System.EventHandler(this.convertToSrtButton_Click);
            // 
            // ConverSubtitleOpenFileDialog
            // 
            this.ConverSubtitleOpenFileDialog.Filter = "VTT Files|*.vtt";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 331);
            this.Controls.Add(this.convertToSrtButton);
            this.Controls.Add(this.SaveFolderLable);
            this.Controls.Add(this.SaveFolderButton);
            this.Controls.Add(this.SaveFolderTextBox);
            this.Controls.Add(this.optionsGroupBox);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.youtubeUrlLabel);
            this.Controls.Add(this.retrieveButton);
            this.Controls.Add(this.youtubeUrlTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1095, 370);
            this.MinimumSize = new System.Drawing.Size(600, 290);
            this.Name = "StartForm";
            this.Text = "youtube-dl wizard";
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox youtubeUrlTextBox;
        private System.Windows.Forms.Button retrieveButton;
        private System.Windows.Forms.Label youtubeUrlLabel;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.ComboBox videoCombo;
        private System.Windows.Forms.ComboBox audioCmb;
        private System.Windows.Forms.ComboBox subtitleCmb;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Label AudioLabel;
        private System.Windows.Forms.Label videoLabel;
        private System.Windows.Forms.CheckBox AutoCaptionCheckBox;
        private System.Windows.Forms.FolderBrowserDialog SaveFolderBrowserDialog;
        private System.Windows.Forms.TextBox SaveFolderTextBox;
        private System.Windows.Forms.Button SaveFolderButton;
        private System.Windows.Forms.Label SaveFolderLable;
        private System.Windows.Forms.Button convertToSrtButton;
        private System.Windows.Forms.OpenFileDialog ConverSubtitleOpenFileDialog;
    }
}

