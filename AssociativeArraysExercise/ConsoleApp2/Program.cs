using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Dictionary<string, int> dictionory = new Dictionary<string, int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                string resourse = input;
                int quantity = int.Parse(Console.ReadLine());


                if (!dictionory.ContainsKey(resourse))
                {
                    dictionory.Add(resourse, quantity);

                }
                else
                {
                    dictionory[resourse] += quantity;
                }

               
            }

            foreach (var kvp in dictionory)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }


        }
    }
}
