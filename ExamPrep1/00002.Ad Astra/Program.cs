using System;
using System.Text.RegularExpressions;

namespace _00002.Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"(\#|\|{1})(?<product>[A-Za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d{1,4}|10000)\1";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);


            int totalCalories = 0;

            foreach (Match match in matches)
            {
                totalCalories+=int.Parse(match.Groups["calories"].ToString());

            }

            Console.WriteLine($"You have food to last you for: {totalCalories/2000} days!");

            foreach (Match match in matches)
            {
                string product = match.Groups["product"].ToString();
                string date = match.Groups["date"].ToString();
                string calories = match.Groups["calories"].ToString();

                Console.WriteLine($"Item: {product}, Best before: {date}, Nutrition: {calories}");
            }

        }
    }
}
