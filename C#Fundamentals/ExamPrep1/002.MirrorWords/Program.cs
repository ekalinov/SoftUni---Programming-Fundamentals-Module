using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _002.MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string wordsPattern = @"(\#{1}|\@{1})(?<wordOne>[A-Za-z]{3,})\1{2}(?<wordTwo>[A-Za-z]{3,})\1{1}";


            MatchCollection wordPairs = Regex.Matches(input, wordsPattern);

            List<string> mirrorWords = new List<string>();
            if (wordPairs.Count != 0)
            {
                Console.WriteLine($"{wordPairs.Count} word pairs found!");
               

            }
            else Console.WriteLine("No word pairs found!");


            MirrorWordsMethod(wordPairs, mirrorWords);

            if (mirrorWords.Count != 0)
            {
                Console.WriteLine("The mirror words are:");
                Console.Write(String.Join(", ", mirrorWords));
                return;
            }


            Console.WriteLine("No mirror words!");
        }

        private static void MirrorWordsMethod(MatchCollection wordPairs, List<string> mirrorWords)
        {

            foreach (Match wordMatch in wordPairs)
            {
                char[] wordOne = wordMatch.Groups["wordOne"].Value.ToCharArray();
                char[] wordTwo = wordMatch.Groups["wordTwo"].Value.ToCharArray();
                Array.Reverse(wordTwo);


                if (wordOne.Length == wordTwo.Length)
                {
                    bool isMirrorWord = true;
                    for (int i = 0; i < wordTwo.Length; i++)
                    {
                        if (wordOne[i] != wordTwo[i])
                        {
                            isMirrorWord = false;
                            break;
                        }

                    }
                    if (isMirrorWord)
                    {

                        mirrorWords.Add($"{wordMatch.Groups["wordOne"]} <=> {wordMatch.Groups["wordTwo"]}");
                    }
                }

            }
        }


    }
}
