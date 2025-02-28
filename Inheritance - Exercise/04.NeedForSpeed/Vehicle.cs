﻿namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DEFAULT_FUEL_CONSUMPTION = 1.25;

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }

        public virtual double FuelConsumption => DEFAULT_FUEL_CONSUMPTION;

        public double Fuel { get; set; }

        public int HorsePower { get; set; }

        public virtual void Drive(double kilometers)
        {
            if (Fuel - FuelConsumption * kilometers >= 0)
            {
                Fuel -= FuelConsumption * kilometers;
            }
        }
    }
}