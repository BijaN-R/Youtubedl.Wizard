﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Youtubedl.Wizard.Models;

namespace Youtubedl.Wizard.Services {
    public class YoutubedlWizard {
        readonly string[] SPLIT_ARRAY = new string[] { "\r\n", "\n", "\r" };
        internal VideoData videoData;

        public void RetriveData(string youtubeUrl) {
            videoData = new VideoData();
            string formats = Utility.ExecuteFile("youtube-dl.exe", $" -F {youtubeUrl}", true);
            string subtitles = Utility.ExecuteFile("youtube-dl.exe", $" --list-subs {youtubeUrl}", true);

            videoData.formats.AddRange(formats.Split(SPLIT_ARRAY, StringSplitOptions.RemoveEmptyEntries));
            videoData.subtitles.AddRange(subtitles.Split(SPLIT_ARRAY, StringSplitOptions.RemoveEmptyEntries));
        }

        internal object[] GetVideoAudioComboList(List<string> list, int firstColLen) {
            List<ComboboxItem> comboboxItems = new List<ComboboxItem>();
            comboboxItems.Add(new ComboboxItem() { Text = "", Value = -1 });
            foreach (var item in list) {
                List<string> itemParts = new List<string>(item.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries));

                ComboboxItem cmbItem = new ComboboxItem();
                cmbItem.Value = itemParts[0];
                itemParts.RemoveAt(0);
                itemParts[0] = Utility.JustifyString(itemParts[0].ToUpper(), firstColLen);
                cmbItem.Text = String.Join(" ", itemParts).Replace(" ,", " -").Replace(",", " -");

                comboboxItems.Add(cmbItem);
            }

            return comboboxItems.ToArray();
        }

        internal object[] GetSubtitleComboList(List<string> list, int firstColLen) {
            List<ComboboxItem> comboboxItems = new List<ComboboxItem>();
            comboboxItems.Add(new ComboboxItem() { Text = "", Value = new SubtitleValues() { LanguageCode = "", SubtitleFormat = "-1" } });
            foreach (var item in list) {
                List<string> itemParts = new List<string>(item.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries));

                ComboboxItem cmbItem = new ComboboxItem();
                cmbItem.Value = new SubtitleValues() { LanguageCode = itemParts[0], SubtitleFormat = itemParts[1] };
                itemParts[0] = Utility.JustifyString(itemParts[0].ToUpper(), firstColLen);
                cmbItem.Text = String.Join(" ", itemParts);

                comboboxItems.Add(cmbItem);
            }

            return comboboxItems.ToArray();
        }

        public void FillVideoQualityList() {
            bool startFlag = false;
            foreach (var item in videoData.formats) {
                if (startFlag) {
                    if (Utility.ContainsIgnoreCase(item, "audio only")) {
                        videoData.audioQuality.Add(item);
                    }
                    else {
                        videoData.videoQuality.Add(item);
                    }
                }

                if (Utility.ContainsIgnoreCase(item, "format code  extension")) {
                    startFlag = true;
                }
            }
        }

        public void FillSubtitleList() {
            int flag = 0;
            foreach (var item in videoData.subtitles) {
                if (Utility.ContainsIgnoreCase(item, "Available automatic captions")) {
                    flag = 1;
                    continue;
                }
                else if (Utility.ContainsIgnoreCase(item, "Available subtitles")) {
                    flag = 2;
                    continue;
                }

                if (!Utility.ContainsIgnoreCase(item, "Language formats")) {
                    if (flag == 1) {
                        videoData.autoCaptionSubtitles.Add(item);
                    }
                    else if (flag == 2) {
                        videoData.availableSubtitles.Add(item);
                    }
                }
            }
        }

        public void Download(DownloadItems downloadItems, string directory) {
            string arguments = OptionsBuilder(downloadItems);
            Utility.ExecuteFile("youtube-dl.exe", arguments, false, directory);
        }

        private string OptionsBuilder(DownloadItems downloadItems) {
            int subValue = -1;
            string subtitleFormat = downloadItems.subtitleValue.SubtitleFormat;
            string languageCode = downloadItems.subtitleValue.LanguageCode;
            bool hasVideo = downloadItems.videoValue != "-1";
            bool hasAudio = downloadItems.audioValue != "-1";
            bool hasSubtitle = !Int32.TryParse(subtitleFormat, out subValue) || subValue > -1;

            StringBuilder arguments = new StringBuilder();
            if (hasVideo) {
                arguments.Append($" -f {downloadItems.videoValue}");
                if (hasAudio) {
                    arguments.Append($"+{downloadItems.audioValue}");
                }
                if (hasSubtitle) {
                    if (downloadItems.autoCaption) {
                        arguments.Append($" --write-auto-sub --sub-format {subtitleFormat} --sub-lang {languageCode}");
                    }
                    else {
                        arguments.Append($" --write-sub --sub-format {subtitleFormat} --sub-lang {languageCode}");
                    }
                }
            }
            else if (hasAudio) {
                arguments.Append($" -f {downloadItems.audioValue}");
                if (hasSubtitle) {
                    if (downloadItems.autoCaption) {
                        arguments.Append($" --write-auto-sub --sub-format {subtitleFormat} --sub-lang {languageCode}");
                    }
                    else {
                        arguments.Append($" --write-sub --sub-format {subtitleFormat} --sub-lang {languageCode}");
                    }
                }
            }
            else if (hasSubtitle) {
                if (downloadItems.autoCaption) {
                    arguments.Append($" --write-auto-sub --sub-format {subtitleFormat} --sub-lang {languageCode} --skip-download");
                }
                else {
                    arguments.Append($" --write-sub --sub-format {subtitleFormat} --sub-lang {languageCode} --skip-download");
                }
            }
            arguments.Append($" {downloadItems.url}");

            return arguments.ToString();
        }
    }
}
