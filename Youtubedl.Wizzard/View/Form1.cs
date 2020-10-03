using System;
using Youtubedl.Wizzard.Services;
using System.Windows.Forms;
using Youtubedl.Wizzard.Models;

namespace Youtubedl.Wizzard.View {
    public partial class StartForm : Form {
        YoutubedlWizard services = new YoutubedlWizard();
        Subtitle subtitle = new Subtitle();
        public StartForm() {
            InitializeComponent();
            SaveFolderTextBox.Text = SaveFolderBrowserDialog.SelectedPath;
        }

        private void retriveButton_Click(object sender, EventArgs e) {
            videoCombo.Items.Clear();
            audioCmb.Items.Clear();
            services.RetriveData(youtubeUrlTextBox.Text);
            services.FillVideoQualityList();
            services.FillSubtitleList();
            videoCombo.Items.AddRange(services.GetVideoAudioComboList(services.videoData.videoQuality, 5));
            audioCmb.Items.AddRange(services.GetVideoAudioComboList(services.videoData.audioQuality, 5));
            FillSubtitleComboBox();

        }

        private void AutoCaptionCheckBox_CheckedChanged(object sender, EventArgs e) {
            FillSubtitleComboBox();
        }

        private void FillSubtitleComboBox() {
            subtitleCmb.Items.Clear();
            if (AutoCaptionCheckBox.Checked) {
                subtitleCmb.Items.AddRange(services.GetSubtitleComboList(services.videoData.autoCaptionSubtitles, 7));
            }
            else {
                subtitleCmb.Items.AddRange(services.GetSubtitleComboList(services.videoData.availableSubtitles, 7));
            }
        }

        private void videoCombo_SelectedIndexChanged(object sender, EventArgs e) {
            if (videoCombo.SelectedItem.ToString().ToLower().Contains("video only") || videoCombo.SelectedIndex == 0) {
                audioCmb.Enabled = true;
            }
            else {
                audioCmb.Enabled = false;
            }
        }

        private void downloadButton_Click(object sender, EventArgs e) {
            if (!audioCmb.Enabled) {
                audioCmb.SelectedIndex = 0;
            }
            if (videoCombo.SelectedIndex == -1) {
                videoCombo.SelectedIndex = 0;
            }
            if (audioCmb.SelectedIndex == -1) {
                audioCmb.SelectedIndex = 0;
            }
            if (subtitleCmb.SelectedIndex == -1) {
                subtitleCmb.SelectedIndex = 0;
            }
            services.Download(youtubeUrlTextBox.Text,
                ((ComboboxItem)videoCombo.SelectedItem).Value,
                ((ComboboxItem)audioCmb.SelectedItem).Value,
                ((ComboboxItem)subtitleCmb.SelectedItem).Value,
                AutoCaptionCheckBox.Checked, SaveFolderBrowserDialog.SelectedPath);
        }

        private void SaveFolderButton_Click(object sender, EventArgs e) {
            SaveFolderBrowserDialog.ShowDialog(this);
            SaveFolderTextBox.Text = SaveFolderBrowserDialog.SelectedPath;
        }

        private void convertToSrtButton_Click(object sender, EventArgs e) {
            if (ConverSubtitleOpenFileDialog.ShowDialog(this) == DialogResult.OK) {
                subtitle.FixSubtitle(ConverSubtitleOpenFileDialog.FileName);
            }
        }
    }
}
