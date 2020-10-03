using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Youtubedl.Wizzard.Services {
    class Utility {
        public static string JustifyString(string text, int len) {
            for (int i = text.Length; i < len; i++) {
                text += " ";
            }
            return text;
        }

        public static string ExecuteFile(string fileName, string arguments, bool useShell, string directory = "") {
            Process process = new Process();
            process.StartInfo.UseShellExecute = useShell;
            process.StartInfo.RedirectStandardOutput = !useShell;
            process.StartInfo.WorkingDirectory = directory;
            process.StartInfo.FileName = fileName;
            process.StartInfo.Arguments = arguments;
            process.Start();
            if (useShell) {
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

        public static void ShowAlert(string alrt) {
            //Console.Clear();
            for (int i = 0; i < 10; i++) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(alrt);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(alrt);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPress any key to continue ...");
            Console.ReadKey();
        }
    }

    public static class Extensions {
        public static int ToInt(this string str) {
            return Convert.ToInt32(str);
        }
        public static string AddNewLine(this string str) {
            return str + "\n";
        }
    }
}
