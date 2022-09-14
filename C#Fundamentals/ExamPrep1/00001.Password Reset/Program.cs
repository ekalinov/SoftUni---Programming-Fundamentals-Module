using System;
using System.Text;

namespace _00001.Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {


           string inputPassword = Console.ReadLine();

            string input;

            string currPassword= inputPassword;

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] commandArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = commandArgs[0];
                


                switch (command)
                {
                    case "TakeOdd":
                        StringBuilder sb = new StringBuilder();

                        for (int i = 1; i < currPassword.Length; i+=2)
                        {   
                            sb.Append(currPassword[i]);
                        }
                        currPassword = sb.ToString();
                        Console.WriteLine(currPassword);
                        break;
                    case "Cut":

                        int startingIndex = int.Parse(commandArgs[1]);
                        int lenght = int.Parse(commandArgs[2]);

                        currPassword = currPassword.Remove(startingIndex, lenght);

                        Console.WriteLine(currPassword);

                        break;
                    case "Substitute":

                        string substring    = commandArgs[1];
                        string substitute  = commandArgs[2];

                        if (currPassword.Contains(substring))
                        {
                            currPassword = currPassword.Replace(substring, substitute);

                        }
                        else 
                        { 
                            Console.WriteLine("Nothing to replace!");
                            break;
                        }

                        Console.WriteLine(currPassword);
                        break;
                }
            }
            Console.WriteLine($"Your password is: {currPassword}");





        }
    }
}
