using System;
using System.Collections.Generic;
using System.Linq;

namespace DataProcessingTemplate
{
    class Parser
    {
        public static Dictionary<string, string> parseKore(string kore)
        {

            Dictionary<string, string> words = new Dictionary<string, string>();

            string[] wordsRaw = kore.Split(new string[] { "Core" }, StringSplitOptions.None);

            int count = 0;
            foreach (string wordString in wordsRaw)
            {
                // borderlane cases
                if (count == 0 || count >= 5999)
                {
                    count++;
                    continue;
                }

                string[] wordData = wordString.Split('\t');

                string japaneseWord = wordData[3].Split('\n')[1];

                if (!words.ContainsKey(japaneseWord))
                    words.Add(japaneseWord, wordData[6]);

                count++;
            }

            return words;
        }

        public static Dictionary<string, string> parseKore10k(string kore)
        {

            Dictionary<string, string> words = new Dictionary<string, string>();

            string[] wordsRaw = kore.Split('\t');

            for (int i = 1; i < wordsRaw.Length / 14; i++)
            {

                string japWord = wordsRaw[3 + i * 14];
                string translation = wordsRaw[5 + i * 14];

                if (!words.ContainsKey(japWord))
                    words.Add(japWord, translation);
            }

            return words;
        }

        public static Dictionary<string, int> parseFreqList(string freqList)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            string[] wordsFreqRaw = freqList.Split('\n');

            foreach (string wordRaw in wordsFreqRaw)
            {
                string[] word = wordRaw.Split('\t');
                if (!words.ContainsKey(word[2]))
                    words.Add(word[2], Convert.ToInt32(word[0]));
            }

            return words;
        }
    }
}
