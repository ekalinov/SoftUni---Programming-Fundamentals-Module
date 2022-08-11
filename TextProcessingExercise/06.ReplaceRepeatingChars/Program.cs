using System;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] inputString  = Console.ReadLine().ToCharArray();

            StringBuilder sb = new StringBuilder();
            sb.Append(inputString[0]);

            for (int i = 1; i < inputString.Length; i++)
            {
                if (inputString[i - 1] == inputString[i])
                {
                    continue;

                }

                sb.Append(inputString[i]);

            }


            Console.Write(sb.ToString());   
        }
    }
}
