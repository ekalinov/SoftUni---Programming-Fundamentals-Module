using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string inputArgs = Console.ReadLine();

            string splitPattern = @"[,\s]+";
            string healthPattern = @"[^\.\+\-\*\/,0-9]";
            string damagePattern = @"\-?\d+\.?\d*";
            string multiplicationDivision = @"[\*\/]";

            string[] deamons = Regex.Split(inputArgs, splitPattern).OrderBy(x => x ).ToArray();

            for (int i = 0; i < deamons.Length; i++)
            {
                string curDeamon = deamons[i];

                var healthMatched = Regex.Matches(curDeamon, healthPattern);
                int health = 0; 

                foreach  (Match currChar in healthMatched)
                { 
                    health+=char.Parse(currChar.ToString()); 
                }
                
                double damage = 0;  
                var damageMatched = Regex.Matches(curDeamon, damagePattern);

                foreach (var match in damageMatched)
                {
                    damage += double.Parse(match.ToString());
                }

                var multOrDivMatched = Regex.Matches(curDeamon, multiplicationDivision);
              
                foreach (var item in multOrDivMatched)
                {
                    if (item.ToString()=="*")
                    {
                        damage *=  2;
                    }
                    else damage /= 2;
                }

                Console.WriteLine($"{curDeamon} - {health} health, {damage:f2} damage");


            }


        }
    }
}
