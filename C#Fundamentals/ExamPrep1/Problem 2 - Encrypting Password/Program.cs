using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_2___Encrypting_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"(?<splitters>.+)\>(?<gr1>\d{3})\|(?<gr2>[a-z]{3})\|(?<gr3>[A-Z]{3})\|(?<gr4>[^\<\>.]{3})\<\1";

            for (int i = 0; i < n; i++)
            {


                Match regex = Regex.Match(Console.ReadLine(), pattern);

                if (!regex.Success)
                {
                    Console.WriteLine("Try another password!");
                    continue;
                }
               
                StringBuilder sb  = new StringBuilder();

                sb.Append(regex.Groups["gr1"]);
                sb.Append(regex.Groups["gr2"]);
                sb.Append(regex.Groups["gr3"]);
                sb.Append(regex.Groups["gr4"]);

                string password = sb.ToString();

                Console.WriteLine($"Password: {password}");


            }


        }
    }
}