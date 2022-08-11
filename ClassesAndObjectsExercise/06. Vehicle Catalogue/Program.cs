using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {

        class Vehicle
        {
            public Vehicle(string typeVehicle, string model, string color, double horsePower)
            {
                TypeVehicle = typeVehicle;
                Model = model;
                Color = color;
                HorsePower = horsePower;
            }

            public string TypeVehicle { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double HorsePower { get; set; }
        }
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            List<Vehicle> catalog = new List<Vehicle>();

            while (input != "End")
            {
                string[] vehicleProps = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (vehicleProps[0] == "car")
                {
                    vehicleProps[0] = "Car";
                }
                else if (vehicleProps[0] == "truck")
                {
                    vehicleProps[0] = "Truck";
                }
                string typeOfvehicle = vehicleProps[0];

                string model = vehicleProps[1];
                string color = vehicleProps[2];
                double horsePower = double.Parse(vehicleProps[3]);

                Vehicle newVechicle = new Vehicle
                    (typeOfvehicle,
                    model,
                    color,
                    horsePower
                    );


                catalog.Add(newVechicle);


                input = Console.ReadLine();
            }

            string searchedVehicle = Console.ReadLine();
            
            while (searchedVehicle != "Close the Catalogue")
            {
                Vehicle vehicleToPrint = catalog.FirstOrDefault(x => x.Model== searchedVehicle);

                PrintVehicle(vehicleToPrint);

                searchedVehicle = Console.ReadLine();
            }

            PrintAverageHP(catalog);

        }

        private static void PrintAverageHP(List<Vehicle> catalog)
        {
            double sumCarHP = 0;
            int CarCounter = 0;
            double sumTruckHP = 0;
            int TruckCounter = 0;
            foreach (Vehicle vehicle in catalog)
            {
                if (vehicle.TypeVehicle=="Car")
                {
                sumCarHP += vehicle.HorsePower;
                CarCounter++;
                }
                else if (vehicle.TypeVehicle == "Truck")
                {
                    sumTruckHP += vehicle.HorsePower;
                    TruckCounter++;
                }
            }

            double averageCarHP = sumCarHP / CarCounter;
            double averageTruckHP = sumTruckHP / TruckCounter;
            if (CarCounter>0)
            {
            Console.WriteLine($"Cars have average horsepower of: {averageCarHP:f2}.");

            }
            else
            {
            Console.WriteLine($"Cars have average horsepower of: {0:f2}.");

            }

            if (TruckCounter>0)
            {
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHP:f2}.");

            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");

            }

        }

        private static void PrintVehicle(Vehicle vehicleToPrint)
        {
            Console.WriteLine($"Type: {vehicleToPrint.TypeVehicle}");
            Console.WriteLine($"Model: {vehicleToPrint.Model}");
            Console.WriteLine($"Color: {vehicleToPrint.Color}");
            Console.WriteLine($"Horsepower: {vehicleToPrint.HorsePower}");
            
        }
    }
}
