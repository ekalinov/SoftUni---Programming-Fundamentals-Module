using System;

namespace _0001.Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string currString= inputString;

            string cmdArgs;

            while ((cmdArgs = Console.ReadLine()) != "Generate")
            {
                string[] commandsArr = cmdArgs.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                string command = commandsArr[0];
                int startingIndex;
                int endIndex;

                switch (command)
                {
                    case "Contains":

                        string substring = commandsArr[1];

                        if (currString.Contains(substring))
                        {
                            Console.WriteLine($"{currString} contains {substring}");
                        }
                        else Console.WriteLine("Substring not found!");
                        break;

                    case "Flip":

                        string whatCase = commandsArr[1];
                        startingIndex = int.Parse(commandsArr[2]);
                        endIndex = int.Parse(commandsArr[3]);

                        if (whatCase == "Upper")
                        {
                            string newCaseString = currString.Substring(startingIndex, endIndex - startingIndex).ToUpper();
                            string currStringRemoved= currString.Remove(startingIndex, endIndex - startingIndex);
                            currString= currStringRemoved.Insert(startingIndex, newCaseString);
                            Console.WriteLine(currString);


                        }
                        else
                        {
                            string newCaseString = currString.Substring(startingIndex, endIndex - startingIndex).ToLower();
                            string currStringRemoved = currString.Remove(startingIndex, endIndex - startingIndex);
                            currString= currStringRemoved.Insert(startingIndex, newCaseString);
                            Console.WriteLine(currString);


                        }
                        break;


                    case "Slice":


                        startingIndex = int.Parse(commandsArr[1]);
                        endIndex = int.Parse(commandsArr[2]);

                        currString= currString.Remove(startingIndex, endIndex - startingIndex);

                        Console.WriteLine(currString);

                        break;
                }

            }
            Console.WriteLine($"Your activation key is: {currString}");






        }


    }
}
