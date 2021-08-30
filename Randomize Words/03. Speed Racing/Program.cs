using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<CAR> colection = new List<CAR>();

            for (int i = 0; i < n; i++)
            {
                string[] cars = Console.ReadLine().Split();

                string model = cars[0];
                double fuel = double.Parse(cars[1]);
                double fuelfor01km = double.Parse(cars[2]);

                CAR car = new CAR(model,fuelamount:fuel,fuelfor01km,traveldistance:0);
                colection.Add(car);
            }

            string carsOfdistace = Console.ReadLine();

            while (carsOfdistace != "End")
            {
                string[] distance = carsOfdistace.Split();
                if (distance[0] == "Drive")
                {
                    string models = distance[1];
                    double distanceOfmodels = double.Parse(distance[2]);

                    colection.Where(c => c.model == models).ToList().ForEach(c => c.GetTottal(distance: distanceOfmodels));
                }

                carsOfdistace = Console.ReadLine();
            }

            foreach (CAR cars in colection)
            {
                Console.WriteLine($"{cars.model} {cars.fuelamount:f2} {cars.traveldistance}");
            }
        }
        class CAR
        {

            public string model;

            public double fuelamount;

            public double fuelper1km;

            public double traveldistance;

            public CAR(string model, double fuelamount, double fuelper1km, double traveldistance)
            {
                this.model = model;
                this.fuelamount = fuelamount;
                this.fuelper1km = fuelper1km;
                this.traveldistance = 0;

            }

            public void GetTottal(double distance)
            {
                if (this.fuelamount < distance * fuelper1km)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
                else
                {
                    this.fuelamount -= distance * fuelper1km;
                    this.traveldistance += distance;
                }
            }
        }
    }
}
