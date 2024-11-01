using System;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public double TankCapacity { get; set; }

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            if (fuelQuantity <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                FuelQuantity = fuelQuantity;
                FuelConsumption = fuelConsumption;
                TankCapacity = tankCapacity;
            }
        }

        public abstract void Drive(double distance);
        public abstract void Refuel(double liters);
    }
}
