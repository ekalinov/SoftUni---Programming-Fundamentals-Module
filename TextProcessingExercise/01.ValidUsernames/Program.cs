using System;

namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(", ");

            foreach (var item in input)
            {
                if (item.Length>=3 && item.Length<=16)
                {

                char[] itemchars = item.ToCharArray();

                bool isValid = true;
                foreach (var charInIput in itemchars)
                {
                    if (!(char.IsLetterOrDigit(charInIput) || charInIput == '_' || charInIput == '-'))
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                {
                    Console.WriteLine(item);
                }
                }
            }
        }
    }
}
