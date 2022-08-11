using System;
using System.Linq;


namespace Problem_1___Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string originPassword = Console.ReadLine();

            string currPassword = originPassword;
            string input;

            //•	The possible commands are:
            //o   "Complete"
            //o   "Make Upper {index}"
            //o   "Make Lower {index}"
            //o   "Insert {index} {char}"
            //o   "Replace {char} {value}"
            //o   "Validation"

            while ((input = Console.ReadLine()) != "Complete")
            {
                string[] commandArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = commandArgs[0];
                string Name;
                int index;
                string lowerOrUpperCase;
                char charToInsert;
                int value;

                switch (command)
                {
                    case "Make":
                        lowerOrUpperCase = commandArgs[1];
                        index = int.Parse(commandArgs[2]);

                        currPassword = Make(lowerOrUpperCase, index, currPassword);
                        break;

                    case "Insert":
                        index = int.Parse(commandArgs[1]);
                        charToInsert = char.Parse(commandArgs[2]);

                        if (index < 0 || index >= currPassword.Length)
                        {
                            break;
                        }

                        currPassword = Insert(index, charToInsert, currPassword);
                        break;

                    case "Replace":
                        charToInsert = char.Parse(commandArgs[1]);
                        value = int.Parse(commandArgs[2]);

                        if (!currPassword.Contains(charToInsert))
                        {
                            break;
                        }

                        currPassword = Replace(charToInsert, value, currPassword);

                        break;

                    case "Validation":

                        Validation(currPassword);

                        break;
                }
            }
        }



        private static string Make(string lowerOrUpperCase, int index, string currPassword)
        {
            string currChar;
            if (lowerOrUpperCase == "Upper")
            {
                currChar = currPassword[index].ToString().ToUpper();
            }
            else
            {
                currChar = currPassword[index].ToString().ToLower();
            }
            currPassword = currPassword.Remove(index, 1);

            currPassword = currPassword.Insert(index, currChar);

            Console.WriteLine(currPassword);

            return currPassword;
        }

        private static string Insert(int index, char charToInsert, string currPassword)
        {

            currPassword = currPassword.Insert(index, charToInsert.ToString());

            Console.WriteLine(currPassword);
            return currPassword;
        }

        private static string Replace(char charToInsert, int value, string currPassword)
        {
            char newChar = (char)(charToInsert + value);


            currPassword = currPassword.Replace(charToInsert, newChar);


            Console.WriteLine(currPassword);
            return currPassword;
        }

        private static void Validation(string currPassword)
        {
            //o   "Password must be at least 8 characters long!"
            //o   "Password must consist only of letters, digits and _!"
            //o   "Password must consist at least one uppercase letter!"
            //o   "Password must consist at least one lowercase letter!"
            //o   "Password must consist at least one digit!"
            bool isSymbolValid = true;


            int lowerCounter = 0;
            int upperCounter = 0;
            int digitCounter = 0;

            foreach (char item in currPassword)
            {
                if (!(Char.IsLetterOrDigit(item) || item == '_'))
                {
                    isSymbolValid = false;

                }

                if (item >= 'A' && item <= 'Z')
                {
                    upperCounter++;

                }

                if (item >= 'a' && item <= 'z')
                {
                    lowerCounter++;
                }


                if (Char.IsDigit(item))
                {
                    digitCounter++;
                }
            }




            if (currPassword.Length < 8)
            {
                Console.WriteLine("Password must be at least 8 characters long!");
            }
            if (!isSymbolValid)
            {
                Console.WriteLine("Password must consist only of letters, digits and _!");
            }
            if (upperCounter == 0)
            {
                Console.WriteLine("Password must consist at least one uppercase letter!");
            }

            if (lowerCounter == 0)
            {
                Console.WriteLine("Password must consist at least one lowercase letter!");
            }
            if (digitCounter == 0)
            {
                Console.WriteLine("Password must consist at least one digit!");

            }
        }
    }
}
