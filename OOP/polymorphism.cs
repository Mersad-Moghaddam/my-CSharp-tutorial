using System;

namespace OOP
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Generic Animal Sound");

        }
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"Woof Woof!");

        }
        public void Fetch()
        {
            Console.WriteLine($"Fetching the ball");
            
        }
    }
}