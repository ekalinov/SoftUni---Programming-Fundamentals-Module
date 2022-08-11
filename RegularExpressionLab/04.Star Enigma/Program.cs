using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int inputCount = int.Parse(Console.ReadLine());

            string pattern = @"@(?<planetName>[A-Za-z]+)[^\@\-\!\:\>\.]*?:(?<population>\d+)[^\@\-\!\:\>\.]*?!(?<attackType>[AD]{1})![^\@\-\!\:\>\.]*?\-\>(?<soldiersCount>\d+)[^\@\-\!\:\>\.]*?";

            Regex regex = new Regex(pattern);


        List<string> attackedPlanets = new List<string>();
        List<string> destroiedPlanets = new List<string>();

            for (int i = 0; i < inputCount; i++)
            {
                string originalMessege = Console.ReadLine();

                int keyForDecription = 0;

                string toLowerString = originalMessege.ToLower();
                foreach (char item in toLowerString)
                {
                    if (item=='s'|| item == 't' || item == 'a' || item == 'r')
                    {
                        keyForDecription++;
                    }

                }

                StringBuilder sb =new StringBuilder();

                foreach (char item in originalMessege)
                {
                    int currCharAscii = item- keyForDecription;

                    char newChar = (char)currCharAscii;
                    sb.Append(newChar);
                }

                string decriptedMessage = sb.ToString();

                Match match = regex.Match(decriptedMessage);


                if (!match.Success)
                {
                    continue;
                }

                string planetName = match.Groups["planetName"].Value; 
                int population =int.Parse( match.Groups["population"].Value); 
                char attackType = char.Parse(match.Groups["attackType"].Value) ;
                int soldiers = int.Parse(match.Groups["soldiersCount"].Value);

                if (attackType=='A')
                {
                    attackedPlanets.Add(planetName);
                }
                else
                {
                    destroiedPlanets.Add(planetName);
                }

            }
             attackedPlanets.Sort();
            destroiedPlanets.Sort();

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");

            foreach (string planet in attackedPlanets) 
            {
                Console.WriteLine($"-> {planet}");
            }
           

            Console.WriteLine($"Destroyed planets: {destroiedPlanets.Count}");
            foreach (string planet in destroiedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
