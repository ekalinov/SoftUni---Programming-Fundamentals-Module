using System;
using System.Text.RegularExpressions;

namespace _00000002.Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string pattern =@"(^|\s)[a-zA-Z0-9][\w*_\.\-]*[A-Za-z0-9]\@[a-z0-9]+[.-][a-z]+([.][a-z]+)*";


                        MatchCollection emails = Regex.Matches(input, pattern);

            foreach (Match email in emails)
            {
                Console.WriteLine(email);

            }



        }
    }

}
