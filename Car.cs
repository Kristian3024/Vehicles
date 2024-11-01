using System;

namespace Vehicles
{
    class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption + 0.9, tankCapacity) { }

        public override void Drive(double distance)
        {
            double neededFuel = distance * FuelConsumption;
            if (neededFuel <= FuelQuantity)
            {
                FuelQuantity -= neededFuel;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
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
    }
}
