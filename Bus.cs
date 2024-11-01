using System;

namespace Vehicles
{
    class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
         : base(fuelQuantity, fuelConsumption, tankCapacity) { }

        public override void Drive(double distance)
        {
            double neededFuel = distance * (FuelConsumption + 1.4);
            if (neededFuel <= FuelQuantity)
            {
                FuelQuantity -= neededFuel;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            if (this.TankCapacity < liters + this.FuelQuantity)
            {
                Console.WriteLine("Cannot fit fuel in tank");
            }
            else
            {
                FuelQuantity += liters;
            }
        }
        public void DriveEmpty(double distance)
        {
            double neededFuel = distance * FuelConsumption;
            if (neededFuel <= FuelQuantity)
            {
                FuelQuantity -= neededFuel;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }
    }
}
