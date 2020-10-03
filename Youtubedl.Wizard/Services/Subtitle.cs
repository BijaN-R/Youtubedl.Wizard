using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Youtubedl.Wizard.Services {
    public class Subtitle {
        public void FixSubtitle(string file) {
            string subtitle = string.Empty;
            string path = Path.GetDirectoryName(file);
            string fileName = Path.GetFileNameWithoutExtension(file);
            string fileExt = Path.GetExtension(file);
            if (fileExt.ToLower() != ".vtt") {
                Utility.ShowAlert("File extension should be '.vtt' !!!");
                return;
            }
            List<SubTimes> subTimesList = new List<SubTimes>();
            List<string> subtitlesList = new List<string>();

            subtitle = Utility.FileReader(file);
            subtitle = subtitle.Replace("\r\n", "\n").Replace("\r", "\n");

            List<String> subtitleParts = new List<string>(Regex.Split(subtitle, @"^.*(\d+):(\d{2}):(\d{2})\.(\d{3}) --> (\d+):(\d{2}):(\d{2})\.(\d{3})", RegexOptions.Multiline));
            subtitleParts.RemoveAt(0);

            subTimesList = ExtractTimesToList(subtitleParts);
            subtitlesList = ExtractSubsToList(subtitleParts);
            JustifyTimes(subTimesList);
            string outSubtitle = GenerateSubtitle(subTimesList, subtitlesList);
            Utility.FileWriter(outSubtitle, fileName + "_OUT", "srt", path);
        }

        public string GenerateSubtitle(List<SubTimes> subTimesList, List<string> subtitlesList) {
            string body = string.Empty;
            int counter = 1;
            for (int i = 0; i < subtitlesList.Count; i++) {
                if (string.IsNullOrWhiteSpace(subtitlesList[i])) { continue; }
                body += counter.ToString().AddNewLine();
                body += PrintTimeStamp(subTimesList[i]).AddNewLine();
                body += subtitlesList[i].AddNewLine().AddNewLine();
                counter++;
            }
            return body;
        }

        public string PrintTimeStamp(SubTimes subTimes) {
            string timestamp = string.Empty;
            timestamp = subTimes.startTime.Hours.ToString("00") + ":"
                        + subTimes.startTime.Minutes.ToString("00") + ":"
                        + subTimes.startTime.Seconds.ToString("00") + ","
                        + subTimes.startTime.Milliseconds.ToString("000").Substring(0, 3)
                        + " --> "
                        + subTimes.endTime.Hours.ToString("00") + ":"
                        + subTimes.endTime.Minutes.ToString("00") + ":"
                        + subTimes.endTime.Seconds.ToString("00") + ","
                        + subTimes.endTime.Milliseconds.ToString("000").Substring(0, 3);

            return timestamp;
        }

        public string TrimSubtitle(string subtitle) {
            if (subtitle.IndexOf("\n") < 0) { return subtitle; }
            string[] subParts = subtitle.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            //subParts[subParts.Length - 1] = string.Empty;
            return string.Join("\n", subParts);
        }

        public void JustifyTimes(List<SubTimes> subTimesList) {
            for (int i = 0; i < subTimesList.Count; i++) {
                if (i >= subTimesList.Count - 1) { break; }
                if (subTimesList[i].endTime >= subTimesList[i + 1].startTime) {
                    subTimesList[i].endTime = subTimesList[i + 1].startTime.Add(new TimeSpan(-20000));  //MINUS 2 MILLISECONDS
                }
            }
        }

        public List<string> ExtractSubsToList(List<string> arrSub) {
            List<string> subtitleList = new List<string>();
            for (int i = 0; i < arrSub.Count; i += 9) {
                string subtitle = i + 9 < arrSub.Count ? TrimSubtitle(arrSub[i + 8]) : arrSub[i + 8];
                subtitleList.Add(subtitle.Trim('\n'));
            }

            return subtitleList;
        }

        public List<SubTimes> ExtractTimesToList(List<string> subtitleParts) {
            List<SubTimes> subTimesList = new List<SubTimes>();
            for (int i = 0; i < subtitleParts.Count; i += 9) {
                SubTimes subTimes = new SubTimes();
                subTimes.startTime = new TimeSpan(0, subtitleParts[i].ToInt(), subtitleParts[i + 1].ToInt(), subtitleParts[i + 2].ToInt(), subtitleParts[i + 3].ToInt());
                subTimes.endTime = new TimeSpan(0, subtitleParts[i + 4].ToInt(), subtitleParts[i + 5].ToInt(), subtitleParts[i + 6].ToInt(), subtitleParts[i + 7].ToInt());
                subTimesList.Add(subTimes);
            }
            return subTimesList;
        }

    }
    public class SubTimes {
        public TimeSpan startTime { get; set; }
        public TimeSpan endTime { get; set; }
    }

}
