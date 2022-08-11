﻿using System;
using System.Linq;

namespace _04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine()
                .Split(' ')
                .Where(word => word.Length%2==0)
                .ToArray();


            Console.WriteLine(string.Join("\n", inputWords));
        }
    }
}