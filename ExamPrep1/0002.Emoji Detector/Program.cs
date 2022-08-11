using System;
using System.Text.RegularExpressions;

namespace _0002.Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            string inputString = Console.ReadLine();

            string emojiPattern = @"(\:{2}|\*{2})(?<emoji>[A-Z]{1}[a-z]{2,})\1";
            string tresholdPattern = @"\d";

            long coolThreshold = 1;

            var thresholdMathes = Regex.Matches(inputString, tresholdPattern);

            foreach (Match match in thresholdMathes)
            {
                int currNum = int.Parse(match.Value);
                coolThreshold*= currNum;
            }

           Console.WriteLine($"Cool threshold: {coolThreshold}");

            var emojiMathes = Regex.Matches(inputString, emojiPattern);

            Console.WriteLine($"{emojiMathes.Count} emojis found in the text. The cool ones are:");

            foreach (Match match in emojiMathes)
            {
                string emoji = match.Groups["emoji"].ToString();
                long coolness = 0;


                foreach (char item in emoji)
                {
                    coolness += item; 
                }

                if (coolness> coolThreshold)
                {
                    Console.WriteLine(match.Value);
                }
            }

        }
    }
}
