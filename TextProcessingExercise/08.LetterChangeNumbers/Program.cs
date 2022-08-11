using System;
using System.Collections.Generic;

namespace _08.LetterChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (string item in sequence)
            {
                char firstAction = item[0];
                char secondAction = item[item.Length - 1];  //a123b


                double num = int.Parse(item.Substring(1, (item.Length - 2)));


                //•	If it's uppercase you divide the number by the letter's position in the alphabet. 
                //•	If it's lowercase you multiply the number with the letter's position in the alphabet. 

                if (firstAction >= 'A' && firstAction <= 'Z')
                {
                    double numberToDivide = firstAction + 1 - 'A';
                    num = num / numberToDivide;
                }
                else if (firstAction >= 'a' && firstAction <= 'z')
                {
                    double numberToMultiply = firstAction + 1 - 'a';
                    num = num * numberToMultiply;
                }
                //•	If it's uppercase you subtract its position from the resulted number.
                //•	If it's lowercase you add its position to the resulted number.
                if (secondAction >= 'A' && secondAction <= 'Z')
                {
                    double numForSubstract = secondAction + 1 - 'A';
                    num = num - numForSubstract;
                }
                else if (secondAction >= 'a' && secondAction <= 'z')
                {
                    double numToAdd = secondAction + 1 - 'a';
                    num = num + numToAdd;
                }

                sum += num;

            }

            Console.WriteLine($"{sum:f2}");






        }
    }
}
