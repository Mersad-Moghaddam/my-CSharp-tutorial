using System;
namespace OOP
{
    class ElectricCar(string model, int year) : Car(model, year)
    {

        public override void DisplayInfo()
        {
            Console.WriteLine($"Electric Car - Mode : {Model}, Year : {Year}");
        }

        protected override void StartEngine()
        {
            Console.WriteLine($"Start Electric Car");
        }

        protected override void Accelerate(int speed)
        {
            Console.WriteLine($"Accelerating silently at {speed} mph");
            
        }
    }
}