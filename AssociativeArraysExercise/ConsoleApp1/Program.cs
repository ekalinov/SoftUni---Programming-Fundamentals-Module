using System;
using System.Linq;
using System.Collections.Generic;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            char[] inputText = Console.ReadLine().ToCharArray();
            
            Dictionary<char, int> dict = new Dictionary<char, int>();



            foreach (var item in inputText)
            {
                if (item == ' ')
                {
                    continue;
                }
                if (!dict.ContainsKey(item) && item !=' ')
                {
                    dict.Add(item, 0);
                }
           
                dict[item]++;
            }


            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }


              
            
            //Console.WriteLine(String.Join(", \n", chars));
           


             
        }
         
    }
}
