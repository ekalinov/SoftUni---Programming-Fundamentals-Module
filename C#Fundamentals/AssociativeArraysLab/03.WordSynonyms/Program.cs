﻿using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonims = new Dictionary<string, List<string>>();

            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine  ();
                string synonim = Console.ReadLine();
                if (!synonims.ContainsKey(word))
                {
                    synonims.Add(word, new List<string>());
                }
                synonims [word].Add (synonim);
            }

            foreach (var word in synonims)
            {
                List<string> synonymsList = word.Value;
                Console.WriteLine($"{word.Key} - {string.Join(", ", synonymsList)}");

            }
        }

        
    }
}
