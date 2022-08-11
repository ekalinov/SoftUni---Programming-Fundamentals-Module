using System;

namespace _001.ExtractPersonInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numLines; i++)
            {
                string[] inputString = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);



                string name = string.Empty;
                string age = string.Empty;



                foreach (var item in inputString)
                {
                    if (item[0] == '@' && item[item.Length - 1] == '|')
                    {
                        name = item.Substring(1, item.Length - 2);
                    }

                    if (item[0] == '#' && item[item.Length - 1] == '*')
                    {
                        age = item.Substring(1, item.Length - 2);
                    }
                }

                if (name!=string.Empty && age!=string.Empty)
                {

                Console.WriteLine($"{name} is {age} years old.");
                }

            }
        }
    }
}
