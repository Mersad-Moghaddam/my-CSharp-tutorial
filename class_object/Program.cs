using System;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.Write("Enter Library Name: ");
            string library_name = Console.ReadLine();

            Console.Write($"Enter the max Capacity of {library_name} : ");
            int max_books = int.Parse(Console.ReadLine());
            Console.WriteLine($"---------------------------------------------");



            Library myLib_1 = new(library_name, max_books, max_books);
            Console.WriteLine($"---------------------------------------------");
            Console.Write("How Many Books you want to add : ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine($"---------------------------------------------");
            while (max_books >= 0 && count > 0)
            {
                Console.Write("Enter book titles: ");
                string input = Console.ReadLine();
                myLib_1.AddBook(input);
                max_books--;
                count--;
            } 
            Console.WriteLine($"---------------------------------------------");
            myLib_1.DisplayBooks();
            Console.WriteLine($"\n\n\n\n\n");
            
        // // ... Setter And Getter
            // Console.Clear();
            // Person p1 = new()
            // {
            //     Name = "Mersad",
            //     Age = 22,
            //     Job = "Programmer",
            // };
            // p1.Info();

            // ...  Inheritance
            // Computer c1 = new();
            // Console.WriteLine("-------");
            // Mobile m1 = new();
            // Console.WriteLine("-------");
            // c1.digital_id = 2;
            // c1.type = "Computer";
            // m1.digital_id = 2;
            // m1.type = "Mobile";
            // Console.WriteLine(c1.type);
            // Console.WriteLine(c1.digital_id);
            // c1.Start();

            // Console.WriteLine(m1.type);
            // Console.WriteLine(m1.digital_id);
            // m1.Start();


        }
    internal class Person
    {
        // Setter And Getter
        private string _name;
        private int _age;

        public string Job { set; get; }

        public int Age
        {
            set
            {
                if (value < 0 || value > 120)
                {
                    Console.WriteLine($"the Age is invalid!");

                }
                else
                {
                    _age = value;
                }
            }
            get { return _age; }
        }
        public string Name
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine($"Name cannot be null or empty");

                }
            }
            get { return _name; }
            }

        public void Info()
            {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Job: {Job}");


            }


        }
    }
}

//-----------------------------------------------------//
class DigitalSystem
{
    public string type;
    public int digital_id;
    public DigitalSystem()
    {
        Console.WriteLine("This is an Digital System!");

    }
}

class Computer : DigitalSystem
{
    private readonly int computer_id;
    public Computer()
    {
        Console.WriteLine("This is a Computer!");

    }
    public void Start()
    {
        Console.WriteLine("Computer is Powering UP!");
        
    }
 }

class Mobile : DigitalSystem
{
    private readonly int mobile_id;
    public Mobile()
    {
        Console.WriteLine("This is a Mobile!");

    }
    public void Start()
    {
        Console.WriteLine("Mobile Turn on");
        
     }
     
 }