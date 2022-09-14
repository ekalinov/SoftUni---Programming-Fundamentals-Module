using System;

namespace _002.AsciiSumator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char fisrtChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            string input= Console.ReadLine();

            int biggerASCIIvalue = Math.Max(fisrtChar, secondChar);

            int low = 0;
            int high = 0;

            int sum = 0; 

            if (biggerASCIIvalue== fisrtChar)
            {
                high = biggerASCIIvalue;
                low = secondChar;
            }
            else
            {
                high = secondChar;
                low = fisrtChar;
            }

             
            foreach (var inputChar in input)
            {
                if (inputChar >low && inputChar < high)
                {
                    sum+= inputChar;
                }
            }

            Console.WriteLine(sum);





        }
    }
}
