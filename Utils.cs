using System;
using System.IO;
using System.Text;

namespace DataProcessingTemplate
{
    static class Utils
    {
        public static string getTextFileContent (string filePath) {
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
    }
}
