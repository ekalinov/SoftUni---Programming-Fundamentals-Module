using System;

namespace _05._Hair_Salon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int profit = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int target = 0;

            while (input != "closed")
            {

                string haircutOrColor = input;
                string colorOrType = Console.ReadLine();
                if (haircutOrColor == "haircut")
                {

                    switch (colorOrType)
                    {
                        case "mens":
                            target += 15;
                            break;
                        case "ladies":
                            target += 20;
                            break;
                        case "kids":
                            target += 10;
                            break;
                    }
                }
                else if (haircutOrColor == "color")
                {

                    switch (colorOrType)
                    {
                        case "touch up":
                            target += 20;
                            break;
                        case "full color":
                            target += 30;
                            break;
                    }
                }
                if (target >= profit)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            if (target >= profit)
            {
                Console.WriteLine($"You have reached your target for the day!");
                Console.WriteLine($"Earned money: {target}lv.");
            }

            else if (input == "closed")
            {
                Console.WriteLine($"Target not reached! You need {profit - target}lv. more.");
                Console.WriteLine($"Earned money: {target}lv.");
            }
        }
    }
}