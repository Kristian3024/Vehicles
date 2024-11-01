using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split(' ');
            string[] truckInfo = Console.ReadLine().Split(' ');
            string[] busInfo = Console.ReadLine().Split(' ');

            Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            Truck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            Bus bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] commandParts = Console.ReadLine().Split();
                string command = commandParts[0];
                string vehicleType = commandParts[1];
                double value = double.Parse(commandParts[2]);

                if (command == "Drive")
                {
                    if (vehicleType == "Car")
                    {
                        car.Drive(value);
                    }
                    else if (vehicleType == "Truck")
                    {
                        truck.Drive(value);
                    }
                    else if (vehicleType == "Bus")
                    {
                        bus.Drive(value);
                    }
                }
                else if (command == "Refuel")
                {
                    if (vehicleType == "Car")
                    {
                        car.Refuel(value);
                    }
                    else if (vehicleType == "Truck")
                    {
                        truck.Refuel(value);
                    }
                    else if (vehicleType == "Bus")
                    {
                        bus.Refuel(value);
                    }
                }
                else if (command == "DriveEmpty")
                {
                    bus.DriveEmpty(value);
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");

        }
    }
}
