using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            int numCmd = int.Parse(Console.ReadLine());


            for (int i = 0; i < numCmd; i++)
            {
                string[] userArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = userArgs[0];
                string username = userArgs[1];

                if (command == "register")
                {
                    string carPlate = userArgs[2];
                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, carPlate);
                        Console.WriteLine($"{username} registered {carPlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {carPlate}");
                    }
                }
                else
                {
                    if (!users.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        users.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }

        }
    }
}
