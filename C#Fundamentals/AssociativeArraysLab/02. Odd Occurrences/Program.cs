using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine()
                .Split(' ')
                .Select(word => word.ToLower())
                .ToArray();

            Dictionary<string, int> ocurranciesDictionary = new Dictionary<string, int>();

            foreach (var word in inputWords)
            {
                if (!ocurranciesDictionary.ContainsKey(word))
                {
                    ocurranciesDictionary.Add(word, 0);
                }

                ocurranciesDictionary[word]++;
                    
            }

        


            foreach (var item in ocurranciesDictionary)
            {
                if (item.Value%2!=0)
                {
                    Console.Write(item.Key+ " ");
                }
            }

        }
    }
}
