using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\%(?<costumer>[A-Z][a-z]+)\%[^|$%.]*?<(?<product>\w+)>[^|$%.]*?\|(?<quantity>\d+)\|[^|$%.]*?(?<price>\d+\.?\d+)\$";

            Regex productArgs = new Regex(pattern);

            decimal totalIncome = 0m;

            string input;

            while ((input = Console.ReadLine()) != "end of shift")
            {

                Match match = productArgs.Match(input);
                if (match.Success)
                {

                    string customer = match.Groups["costumer"].Value;
                    string product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);

                    decimal totalPrice = quantity * price;

                    totalIncome += totalPrice;

                    Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");

                }

            }

            Console.WriteLine($"Total income: {totalIncome:f2}");




        }
    }
}