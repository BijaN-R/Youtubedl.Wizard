using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Youtubedl.Wizard.Services {
    class Utility {
        public static string JustifyString(string text, int len) {
            for (int i = text.Length; i < len; i++) {
                text += " ";
            }
            return text;
        }

        public static string ExecuteFile(string fileName, string arguments, bool hasOutput, string directory = "") {
            Process process = new Process();
            process.StartInfo.UseShellExecute = !hasOutput;
            process.StartInfo.RedirectStandardOutput = hasOutput;
            process.StartInfo.WorkingDirectory = directory;
            process.StartInfo.FileName = fileName;
            process.StartInfo.Arguments = arguments;
            process.Start();
            if (!hasOutput) {
                return "";
            }
            return process.StandardOutput.ReadToEnd();
        }


        public static void FileWriter(string boddy, string fileName, string extension, string address) {
            extension = extension.IndexOf(".") == 0 ? extension : "." + extension;
            using (StreamWriter wr = new StreamWriter(address + "\\" + fileName + extension, false, Encoding.UTF8)) {
                wr.Write(boddy);
                wr.Flush();
            }
        }

        public static string FileReader(string fileName) {
            string outString = string.Empty;
            using (StreamReader reader = new StreamReader(fileName)) {
                outString = reader.ReadToEnd();
            }
            return outString;
        }

        public static bool ContainsIgnoreCase(string text, string value) {
            return text.ToLower().Contains(value.ToLower());
        }
    }

}
