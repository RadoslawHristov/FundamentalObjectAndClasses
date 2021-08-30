using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Raw_Data
{
    class Program
    {
        public class StartUp
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                var cars = new List<Car>();

                for (int i = 0; i < n; i++)
                {
                    var input = Console.ReadLine()
                        .Split(' ', 6)
                        .ToArray();
                    var engine = new Engine();
                    var cargo = new Cargo();
                    string model = input[0];
                    engine.Speed = int.Parse(input[1]);
                    engine.Power = int.Parse(input[2]);
                    cargo.Weight = int.Parse(input[3]);
                    cargo.Type = input[4];


                    var car = new Car(model, engine, cargo);
                    cars.Add(car);
                }

                string command = Console.ReadLine();

                switch (command)
                {
                    case "fragile":
                        DisplayFragile(cars);
                        break;
                    case "flamable":
                        DisplayFlamable(cars);
                        break;
                }
            }

           static void DisplayFragile(List<Car> cars)
           {
               foreach (Car car in cars)
               {
                   string model = string.Empty;
                   foreach (var item in cars)
                   {
           
                       if ( item.Model != model)
                       {
                           model = car.Model;
                           Console.WriteLine($"{car.Model}");
                       }
                   }
           
               }
           }

            static void DisplayFlamable(List<Car> cars)
            {
                foreach (var car in cars)
                {
                    if (car.Engine.Power > 250)
                        Console.WriteLine($"{car.Model}");
                }
            }
        }

        public class Car
        {
            public string Model { get; set; }

            public Engine Engine { get; set; }

            public Cargo Cargo { get; set; }

            

            public Car(string model, Engine engine, Cargo cargo)
            {
                this.Model = model;
                this.Engine = engine;
                this.Cargo = cargo;
            }
        }

        public class Cargo
        {
            public string Type { get; set; }

            public int Weight { get; set; }
        }

        public class Engine
        {
            public int Speed { get; set; }

            public int Power { get; set; }
        }
    }
}
