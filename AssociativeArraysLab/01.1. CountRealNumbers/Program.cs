using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._1._CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> sortedOccurances = new SortedDictionary<int, int>();

            int[] inputNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            foreach (var number in inputNumbers)
            {
                if (!sortedOccurances.ContainsKey(number))
                {
                    sortedOccurances.Add(number,0);
                }

                sortedOccurances[number]++;
            }

            foreach (var item in sortedOccurances)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");

            }

        }
    }
}
