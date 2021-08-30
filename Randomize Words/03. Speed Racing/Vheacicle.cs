using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Speed_Racing
{
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
