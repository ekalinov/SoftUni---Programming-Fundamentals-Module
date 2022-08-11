using System;
using System.Linq;
using System.Collections.Generic;
namespace _001.SecretChart
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string startingString = Console.ReadLine();

            string commandInput;

            while ((commandInput = Console.ReadLine()) != "Reveal")
            {
                string[] commandArgs = commandInput.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string command = commandArgs[0];

                switch (command)
                {
                    case "InsertSpace":
                        //•	"InsertSpace:|:{index}":
                        //o Inserts a single space at the given index.The given index will always be valid.
                        int index = int.Parse(commandArgs[1]);
                        startingString = startingString.Insert(index, " ");
                        Console.WriteLine($"{startingString}");
                        break;

                    case "Reverse":
                        //•	"Reverse:|:{substring}":
                        //o If the message contains the given substring, cut it out, reverse it and add it at the end of the message.
                        //o If not, print "error".
                        //o This operation should replace only the first occurrence of the given substring if there are two or more occurrences.
                        string substring = commandArgs[1];
                        char[] substringChars = substring.ToCharArray();
                        Array.Reverse(substringChars);

                        if (startingString.Contains(substring))
                        {
                            int startingIndex = startingString.IndexOf(substring);
                            startingString = startingString.Remove(startingIndex, substring.Length);

                            string reversedString = new string(substringChars);
                            startingString = startingString.Insert(startingString.Length, reversedString);
                            Console.WriteLine($"{startingString}");
                        }
                        else Console.WriteLine("error");
                        break;

                    case "ChangeAll":
                        //•	"ChangeAll:|:{substring}:|:{replacement}":
                        //o Changes all occurrences of the given substring with the replacement text.
                        substring = commandArgs[1];
                        string replacement = commandArgs[2];

                        if (startingString.Contains(substring))
                        {
                            int startingIndex = startingString.IndexOfAny(substring.ToCharArray());
                            startingString = startingString.Replace(substring, replacement);
                            Console.WriteLine($"{startingString}");
                        }

                        break;
                }


            }

            Console.WriteLine($"You have a new text message: {startingString}");




        }
    }
}
