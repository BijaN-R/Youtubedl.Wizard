using System.Collections.Generic;

namespace Youtubedl.Wizzard.Models {
    public class VideoData {
        public VideoData() {
            this.formats = new List<string>();
            this.subtitles = new List<string>();
            this.videoQuality = new List<string>();
            this.audioQuality = new List<string>();
            this.availableSubtitles = new List<string>();
            this.autoCaptionSubtitles = new List<string>();
        }

        public List<string> formats { get; set; }
        public List<string> subtitles { get; set; }
        public List<string> videoQuality { get; set; }
        public List<string> audioQuality { get; set; }
        public List<string> availableSubtitles { get; set; }
        public List<string> autoCaptionSubtitles { get; set; }
    }

}
