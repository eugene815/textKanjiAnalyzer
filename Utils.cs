using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace DataProcessingTemplate
{
    static class Utils
    {
        public static string getTextFileContent(string filePath)
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath, Encoding.Unicode);
            }
            else
            {
                Console.WriteLine("File not found...");
                return "";
            }
        }

        public static void writeStringToFile(string data)
        {
            StreamWriter file = new System.IO.StreamWriter("result.txt");
            file.WriteLine(data);
            file.Close();
        }

        public static string formatKanjiFile()
        {
            string result = "";
            string filePath = "kanjiRaw.txt";

            result = Utils.getTextFileContent(filePath).Replace(" ", "', '");

            return result;
        }
    }
}
