using System;
using System.Numerics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int InputNumber = int.Parse(Console.ReadLine());    

            BigInteger factorial = 1;


            for (int i = 2; i <= InputNumber; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);

        }
    }
}
