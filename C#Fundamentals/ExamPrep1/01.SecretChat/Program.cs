using System;
using System.Linq;
using System.Text;


namespace _01.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            string input = Console.ReadLine();


            string commandOrEnd;
            string destination= input;

            while ((commandOrEnd=Console.ReadLine()) != "Travel")
            {
                string[] commandArgs = commandOrEnd.Split(":", StringSplitOptions.RemoveEmptyEntries);

                string command = commandArgs[0];
                if (command== "Add Stop")
                {
                   destination = AddStopMetod(destination, commandArgs);
                }
                else if (command == "Remove Stop")
                {
                     destination = RemoveStopMetod(destination, commandArgs);
                }
                else if (command == "Switch")
                {
                    destination = SwitchStopMetod(destination, commandArgs);
                }

                //•	"Add Stop:{index}:{string}":
                //o Insert the given string at that index only, if the index is valid,
                //•	"Remove Stop:{start_index}:{end_index}":
                //o Remove the elements of the string from the starting index to the end index(inclusive), if both indices are valid.
                //•	"Switch:{old_string}:{new_string}":
                // If the old string is in the initial string, replace it with the new one(all occurrences).

                Console.WriteLine(destination);
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {destination}");



        }

        private static string SwitchStopMetod(string input, string[] commandArgs)
        {
            string oldString = commandArgs[1];
            string newString = commandArgs[2];

            return input.Replace(oldString,newString);
        }

        static string AddStopMetod(string input, string[] commandArgs)
        {
            int index = int.Parse(commandArgs[1]);
            string stringForInsertaition = commandArgs[2];
            if (index>=0
                &&index<=input.Length)
            {
            return input.Insert(index, stringForInsertaition);
            }
            else return input;

        }
        static string RemoveStopMetod(string input, string[] commandArgs)
        {
            int index = int.Parse(commandArgs[1]);
            int endIndex = int.Parse(commandArgs[2]);
            int lenght = endIndex - index + 1;

            if (index >= 0 
                && index <= input.Length 
                && endIndex >= 0 
                && endIndex <= input.Length
                && lenght !=1)
            {  
            return input.Remove(index, lenght);
            }
            else return input;
        }
    }
}
