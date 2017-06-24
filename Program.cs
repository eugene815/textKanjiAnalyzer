using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataProcessingTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Path to file txt file:");
            string filePath = Console.ReadLine();

            string text = Utils.getTextFileContent(filePath);

            // switch your font to one with japanese support in console (e.g. MS Gothic)
            Analyzer analyzer = new Analyzer();
            analyzer.analyze(text);
            analyzer.printResults();

            Console.ReadKey();
        }
    }
}
