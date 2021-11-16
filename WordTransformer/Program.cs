using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

namespace WordTransformer
{
    class Program
    {
        static string path = "c:\\Natalie\\MyProjects\\C#\\Additional tasks\\WordTransformer\\";
        static void Main(string[] args)
        {
            List<string> dictioary = new List<string>();
            List<string> words = new List<string>();
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>(); ;


            // read file to list of base words
            dictioary = ReadDictioanry();
            // read file to list of words for transformation
            words = ReadWords();

            //transform -> ist of transformed words
            result = TransformWords(words, dictioary);

            //write  result to file 
            // _ = WriteToFileAsync(result, "tranformed words.txt");
            WriteToFile(result, "tranformed words.txt");

            Console.WriteLine("Finished!!");
            Console.ReadKey();
        }

        static List<string> ReadDictioanry()
        {
            
            return ReadFileToList(path + "de-dictionary.tsv"); ;
        }
        
        static List<string> ReadWords()
        {
            return ReadFileToList(path + "Words to transform.txt"); ;
        }
        
        static List<string> ReadFileToList(string fileName)
        {
            List<string> dictioary = new List<string>();

            using (var sr = new StreamReader(fileName))
            {
                while (sr.Peek() >= 0)
                {
                    dictioary.Add(sr.ReadLine().ToLower());
                }
            }
            return dictioary;
        }

        public static async Task WriteToFileAsync(Dictionary<string, List<string>> result, string fileName)
        {
            string line;
            using (var file = new StreamWriter(path + fileName))
            {
                foreach (var item in result)
                {
                    line = $"(in) {item.Key} -> (out)";
                    foreach (string word in item.Value)
                    {
                        line += $"{word}, ";
                    }

                    /////////////////////////////////
                    await file.WriteLineAsync(line);
                }
            }

        }
        
        public static void WriteToFile(Dictionary<string, List<string>> result, string fileName)
        {
            string line;
            using (StreamWriter file = new StreamWriter(path + fileName))
            {
                foreach (KeyValuePair<string, List<string>> item in result)
                {
                    line = $"(in) {item.Key} -> (out)";
                    foreach (string word in item.Value)
                    {
                        line += $"{word}, ";
                    }
                    /////////////////////////////////
                    file.WriteLine(line);
                }
            }

        }
        
        static Dictionary<string, List<string>> TransformWords(List<string> words, List<string> dictionaty)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            foreach (string word in words)
            {
                int count = 0;
                List<string> parsedWord = new List<string>();

                parsedWord.AddRange(ParseWord(word, dictionaty, true));




                dict.Add(word, parsedWord);
            }

            return dict;
        }

        static List<string> ParseWord(string word, List<string> dictionaty, bool first = false)
        {
            List<string> parsedWord = new List<string>();

            List<string> tempWords = new List<string>();

            foreach (string item in dictionaty)
            {
                //find if all words in dictionary which are start of our word

                if (word.ToLower().StartsWith(item.ToLower()) /*&& word.ToLower() != item.ToLower()*/)
                {
                    tempWords.Add(item);
                }

            }
            if (tempWords.Count == 0)
            {
                if (first)
                {
                    parsedWord.Add(word);
                }
                return parsedWord;
            }
            else if (tempWords.Count == 1 && word.ToLower() == tempWords[0].ToLower())
            {
                parsedWord.Add(word);
                return parsedWord;
            }
            else if (tempWords.Count > 1)
            {
                //if therea are more than 1 sort by lenth desc
                tempWords.Sort((x, y) => y.Length.CompareTo(x.Length));
            }
            //parsedWord.Add(tempWords[0]);
            //save a word
            string foudWord = tempWords[0];
            string wordTail = word.Substring(foudWord.Length);
            //if (wordTail.Length != 0)
            //{ 
                tempWords = ParseWord(wordTail, dictionaty);
            //}
            if (tempWords.Count == 0)
            {
                parsedWord.Add(word);
            }
            else
            {
                parsedWord.Add(foudWord);
                parsedWord.AddRange(tempWords);
            
            }

            return parsedWord;
        }

    }
}
