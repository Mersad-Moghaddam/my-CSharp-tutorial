using System;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            Car regularCar = new Car("Sedan", 2022);
            SportCar sportCar = new SportCar("Super car", 2024);
            ElectricCar electricCar = new ElectricCar("Tesla", 2020);
            regularCar.DisplayInfo();
            sportCar.DisplayInfo();
            electricCar.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine($"------------------------------------");
            Console.WriteLine($"\nRegular Car :");
            regularCar.OperatedVehicle(60);
            Console.WriteLine($"\nSport Car :");
            sportCar.OperatedVehicle(160); 
            Console.WriteLine($"\nElectric Car :");
            electricCar.OperatedVehicle(90);
        }
    }
}