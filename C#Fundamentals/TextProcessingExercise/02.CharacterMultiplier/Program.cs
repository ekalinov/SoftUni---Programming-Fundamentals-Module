using System;
using System.Linq;

namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);


            string firstString = input[0];
            string secondString = input[1];

            MultiplyCharacters(firstString, secondString);



        }

        private static void MultiplyCharacters(string firstString, string secondString)
        {
            firstString = firstString.Trim();
            secondString = secondString.Trim();

            int sum = 0;

            
                int firstLenght = firstString.Length;
                int secondLenght = secondString.Length;

                string longerString = string.Empty;

                Math.Max(firstLenght, secondLenght);

                if (Math.Max(firstLenght, secondLenght) == firstString.Length)
                {
                    longerString = firstString;

                }
                else
                {
                    longerString = secondString;
                }

                for (int i = 0; i < Math.Min(firstLenght, secondLenght); i++)
                {
                    int miltiplayedCHars = firstString[i] * secondString[i];
                    sum += miltiplayedCHars;
                }
                for (int i = Math.Min(firstLenght, secondLenght); i < Math.Max(firstLenght, secondLenght); i++)
                {
                    sum += longerString[i];
                }


                Console.WriteLine(sum);
        }
    }
}
