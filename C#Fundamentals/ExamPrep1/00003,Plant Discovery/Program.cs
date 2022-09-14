using System;
using System.Collections.Generic;
using System.Linq;

namespace _00003_Plant_Discovery
{
    internal class Program
    {


        public class Plant
        {
            public Plant(string name)
            {
                Name = name;
                Rating = new List<double>();
            }
            

            public string Name { get; set; }
             public string Rarity { get; set; }
             public List<double> Rating { get; set; }
        }


        public static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());

            string input;
            Dictionary<string, Plant> plants = new Dictionary<string,Plant>();
         

            for (int i = 0; i < n; i++)
            {

                string[] inputArgs = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string plantName = inputArgs[0];


                if (!plants.ContainsKey(plantName))
                {

                plants.Add(plantName, new Plant (plantName) );
                }


                plants[plantName].Rarity = inputArgs[1];
              



            }

            while ((input = Console.ReadLine()) != "Exhibition")
            {
                string[] commandArgs = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string[] commandAndPlant = commandArgs[0].Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string action = commandAndPlant[0];
                string plant = commandAndPlant[1];

                if (!plants.ContainsKey(plant))
                {
                    Console.WriteLine("error");
                    continue;
                }

                switch (action)
                {
                    case "Rate:":
                        Rate(plant, double.Parse(commandArgs[1]), plants);
                        break;
                    case "Update:":
                        Update(plant, commandArgs[1], plants);
                        break;
                    case "Reset:":
                        Reset(plant, plants);
                        break;
                }
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plants)
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {plant.Value.Rating.Average():f2}");
            }



        }

        private static void Rate(string plant, double rating, Dictionary<string, Plant> plants)
        {
           
            plants[plant].Rating.Add(rating);
        }

        private static void Update(string plant, string rarity, Dictionary<string, Plant> plants)
        {
            plants[plant].Rarity=rarity;
        }

        private static void Reset(string plant, Dictionary<string, Plant> plants)
        {
            plants[plant].Rating.Clear();
            plants[plant].Rating.Add(0);
        }
    }
}
