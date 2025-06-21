using System;
namespace OOP
{
    class Car(string model, int year)
    {
        public string Model { get; set; } = model;
        public int Year { get; set; } = year;

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Model : {Model}, Year : {Year}");
        }

        protected virtual void StartEngine()
        {
            Console.WriteLine("Engine Start!");
        }
        protected virtual void Accelerate(int speed)
        {
            Console.WriteLine($"Accelerating at {speed} mph");
        }

        public void OperatedVehicle(int speed)
        {
            StartEngine();
            Accelerate(speed);
        }
    }
}