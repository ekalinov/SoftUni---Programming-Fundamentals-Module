using System;
using System.Text;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            StringBuilder sb = new StringBuilder();

            foreach ( char currChar in input)
            {
                char criptedCharindex = (char)(currChar + 3);
                
                sb.Append(criptedCharindex);
            }
            Console.WriteLine(sb);
        }
    }
}
