using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)";



            List<string> furnitures =   new List<string>();

            decimal sum = 0;

            while (input != "Purchase")
            {
            MatchCollection matches = Regex.Matches(input,pattern);
                if (Regex.IsMatch(input,pattern))
                {

                    foreach (Match match in matches)
                    {

                        string name = match.Groups["name"].Value;
                        decimal value =decimal.Parse( match.Groups["price"].Value);
                        int qty = int.Parse(match.Groups["quantity"].Value);


                        furnitures.Add(name);
                        sum += value*qty;
                    }

                }

                input = Console.ReadLine();
            }

            PrintResult(furnitures, sum);


        }

        private static void PrintResult(List<string> list, decimal v)
        {
            Console.WriteLine(@"Bought furniture:");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {v:f2}");
        }
    }
}
