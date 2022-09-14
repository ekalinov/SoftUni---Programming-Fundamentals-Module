using System;
using System.Collections.Generic;

namespace _0003.NeedForSpeedIII
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string input;
            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();
           

            for (int i = 0; i < n; i++)
            {
                string[] carArgs = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

                string carName = carArgs[0];
                int carMiliage = int.Parse(carArgs[1]);
                int carfuel = int.Parse(carArgs[2]);

                if (!cars.ContainsKey(carName))
                {
                    cars.Add(carName, new List<int>());
                    cars[carName].Add(carMiliage);
                    cars[carName].Add(carfuel);
                }
            }

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] commandArgs = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string command = commandArgs[0];
                string name;


                switch (command)
                {
                    case "Drive":
                        Drive(commandArgs, cars);
                        break;
                    case "Refuel":
                        Refuel(commandArgs, cars);
                        break;
                       case "Revert":
                        Revert(commandArgs, cars);
                        break;
                }
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }







        }
        private static void Drive(string[] commandArgs, Dictionary<string, List<int>> cars)
        {
            //•	"Drive : {car} : {distance} : {fuel}":
            //  o You need to drive the given distance, and you will need the given fuel to do that.If the car doesn't have enough fuel,
            //  print: "Not enough fuel to make that ride"
            //  o If the car has the required fuel available in the tank, increase its mileage with the given distance,
            //  decrease its fuel with the given fuel, and print:
            //            "{car} driven for {distance} kilometers. {fuel} liters of fuel consumed."
            //o You like driving new cars only, so if a car's mileage reaches 100 000 km,
            //remove it from the collection(s) and print: "Time to sell the {car}!"

            string car  = commandArgs[1];
            int distance = int.Parse(commandArgs[2]);
            int fuel = int.Parse(commandArgs[3]);

            if (cars[car][1]<fuel)
            {
                Console.WriteLine("Not enough fuel to make that ride");
                return;
            }

            cars[car][1]-=fuel;
            cars[car][0]+=distance;

            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

            if (cars[car][0]>100000)
            {
                cars.Remove(car);
                Console.WriteLine($"Time to sell the {car}!");
            }

        }


        private static void Refuel(string[] commandArgs, Dictionary<string, List<int>> cars)
        {
            string car = commandArgs[1];
            int fuel = int.Parse(commandArgs[2]);
            
            int originalFuel = cars[car][1];

            cars[car][1] += fuel;
            if (cars[car][1]>75)
            {
                cars[car][1] = 75;
            }

            Console.WriteLine($"{car} refueled with {cars[car][1]-originalFuel} liters");


        }

        private static void Revert(string[] commandArgs, Dictionary<string, List<int>> cars)
        {
            string car = commandArgs[1];
            int kilometers = int.Parse(commandArgs[2]);

            int origina = cars[car][1];
            cars[car][0] -= kilometers;

            if (cars[car][0]<10000)
            {
                cars[car][0] = 10000;
                return;
            }
            Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
        }

       
    }
}
