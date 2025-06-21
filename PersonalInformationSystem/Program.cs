using System;
namespace PersonalInformationManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new();
            Console.Clear();

            Console.Write($"Enter Name : ");
            person.Name = Console.ReadLine();
            Console.Write($"Enter Age : ");
            person.Age = int.Parse(Console.ReadLine());
            Console.Write($"Enter Address : ");
            person.Address = Console.ReadLine();
            Console.Write($"Enter Position : ");
            person.Position = Console.ReadLine();
            Console.Write($"Enter Department : ");
            person.Department = Console.ReadLine();
            
            person.DisplayPersonInfo();
            
            
            
        }
    }
}