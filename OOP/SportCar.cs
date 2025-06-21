using System;
namespace OOP
{
    class SportCar(string model, int year) : Car(model, year)
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"Sport Car - Model : {Model}, Year : {Year}");
        }

        protected override void Accelerate(int speed)
        {
            base.Accelerate(speed);
            Console.WriteLine("Performing a high-speed acceleration!");
            
        }
    }
}