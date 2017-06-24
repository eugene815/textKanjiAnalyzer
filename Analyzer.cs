using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcessingTemplate
{
    class Analyzer
    {
        private Dictionary<char, int> kanjiFreq = new Dictionary<char, int>();
        private int totalChars = 0;
        private int totalKanji = 0;
        private int totalUniqueKanji = 0;
        private double totalUniqueKanjiPercent = 0;

        public void printResults() {

            Console.WriteLine("Total chars: {0} ", totalChars);
            Console.WriteLine("Total kanji: {0} ", totalKanji);
            Console.WriteLine("Total unique kanji: {0} ", totalUniqueKanji);
            Console.WriteLine("Percent of kanji used in text: {0}%", totalUniqueKanjiPercent);

            foreach (KeyValuePair<char, int> item in kanjiFreq)
            {
                Console.WriteLine("{0}: {1} times", item.Key, item.Value);
            }
        }

        public void analyze(string text)
        {
            // time of calc

            foreach (char c in text)
            {
                // if symbol is kanji 
                if (Kanji.isInList(c))
                {
                    // if already in kanjiFreq
                    if (kanjiFreq.ContainsKey(c))
                    {
                        kanjiFreq[c]++;
                    }
                    else
                    {
                        kanjiFreq.Add(c, 1);
                        totalUniqueKanji++;
                    }

                    totalKanji++;
                }
                totalChars++;
            }

            // sort by freq

            // various

            totalUniqueKanjiPercent = (totalUniqueKanji / 2200.0) * 100;
        }
    }
}
