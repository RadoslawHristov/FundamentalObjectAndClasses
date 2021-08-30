using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.vehiciclecatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Cars> cars = new List<Cars>();
            List<Trucks> trucks = new List<Trucks>();

            while (input != "End")
            {
                string[] Line = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);

                if (Line[0] == "car")
                {
                    string model = Line[1];
                    string color = Line[2];
                    double horsepower = double.Parse(Line[3]);

                    Cars car = new Cars();
                    car.Model = model;
                    car.Color = color;
                    car.Horsepower = horsepower;

                    cars.Add(car);
                }

                if (Line[0] == "truck")
                {
                    string model = Line[1];
                    string color = Line[2];
                    double horsepower = double.Parse(Line[3]);

                    Trucks truck = new Trucks();

                    truck.Model = model;
                    truck.Color = color;
                    truck.Horsepower = horsepower;

                    trucks.Add(truck);
                }

                input = Console.ReadLine();
            }

            string input2models = Console.ReadLine();

            while (input2models != "Close the Catalogue")
            {

                foreach (Cars car in cars)
                {
                    if (car.Model.Contains(input2models))
                    {
                        Console.WriteLine($"Type: Car");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.Horsepower}");
                    }
                }

                foreach (Trucks truck in trucks)
                {
                    if (truck.Model.Contains(input2models))
                    {
                        Console.WriteLine("Type: Truck");
                        Console.WriteLine($"Model: {truck.Model}");
                        Console.WriteLine($"Color: {truck.Color}");
                        Console.WriteLine($"Horsepower: {truck.Horsepower}");
                    }
                }

                input2models = Console.ReadLine();
            }

            double averageCar = cars.Select(x=>x.Horsepower).Sum() / (double) cars.Count;
            double averageTruck = trucks.Select(x=>x.Horsepower).Sum() / (double) trucks.Count;

            if (averageCar > 0 && averageTruck > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCar:f2}.");
                Console.WriteLine($"Trucks have average horsepower of: {averageTruck:f2}.");
            }
            else if (averageTruck <=0 && averageCar > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCar:f2}.");
            }
            else if (averageCar <=0 && averageTruck > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTruck:f2}.");
            }
        }
        class Cars
        {
            public string Model { get; set; }

            public string Color { get; set; }

            public double Horsepower { get; set; }
        }
        class Trucks
        {
            public string Model { get; set; }

            public string Color { get; set; }

            public double Horsepower { get; set; }
        }
    }
}