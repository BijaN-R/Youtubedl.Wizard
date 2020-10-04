namespace Youtubedl.Wizard.Models {
    public class DownloadItems {
        public DownloadItems() {
            subtitleValue = new SubtitleValues();
        }

        public string url { get; set; }
        public string videoValue { get; set; }
        public string audioValue { get; set; }
        public SubtitleValues subtitleValue { get; set; }
        public bool autoCaption { get; set; }
    }
}