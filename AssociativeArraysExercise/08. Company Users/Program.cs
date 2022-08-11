using System;
using System.Collections.Generic;

namespace _08._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> Companies = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] userInfo = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string companyName = userInfo[0];
                string userID = userInfo[1];


                if (!Companies.ContainsKey(companyName))
                {
                    Companies.Add(companyName, new List<string>());
                    Companies[companyName].Add(userID);
                }
                else
                {
                    if (Companies[companyName].Contains(userID))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    Companies[companyName].Add(userID);
                }
                input = Console.ReadLine();

            }



            foreach (var company in Companies)
            {
                Console.WriteLine($"{company.Key}");
                foreach (var idNum in company.Value)
                {
                    Console.WriteLine($"-- {idNum}");
                }
            }





        }
    }
}
