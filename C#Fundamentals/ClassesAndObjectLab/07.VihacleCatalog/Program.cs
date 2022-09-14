using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VihacleCatalog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Catalog catalogObject = new Catalog();

            while (command != "end")
            {
                string[] splitVehiclesProps = command.Split('/', StringSplitOptions.RemoveEmptyEntries);

                string type = splitVehiclesProps[0];
                string brand = splitVehiclesProps[1];
                string model = splitVehiclesProps[2];
                int weightOrPower = int.Parse(splitVehiclesProps[3]);

                if (type == "Car")
                {
                    Car newCar = new Car(brand, model, weightOrPower);
                    catalogObject.Cars.Add(newCar);
                }
                else
                {
                    Truck newTruck = new Truck(brand, model, weightOrPower);
                    catalogObject.Trucks.Add(newTruck);

                }

                command = Console.ReadLine();
            }

            if (catalogObject.Cars.Count>0)
            {
                List<Car> orderedCars = catalogObject.Cars.OrderBy(car=> car.Brand).ToList();
                Console.WriteLine("Cars:");

                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{ car.Brand}: { car.Model} - { car.HorsePower}hp");
                }

            }
            if (catalogObject.Trucks.Count > 0)
            {
                List<Truck> orderedTrucks = catalogObject.Trucks.OrderBy(truck => truck.Brand).ToList();
                Console.WriteLine("Trucks:");

                foreach (Truck truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }

            }


        }



    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }

        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
    }
    class Catalog
    {
        

        public Catalog()
        {
            this.Trucks = new List<Truck>();
            this.Cars = new List<Car>();
        }

        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }

}
