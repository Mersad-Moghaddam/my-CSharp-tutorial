using System;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.Write("Enter Library Name: ");
            string libraryName = Console.ReadLine();

            Console.Write($"Enter the capacity of {libraryName}: ");
            int capacity = int.Parse(Console.ReadLine());

            Library library = new(libraryName, capacity);

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Borrow Book");
                Console.WriteLine("3. Return Book");
                Console.WriteLine("4. Display Books");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter book title to add: ");
                        string bookTitle = Console.ReadLine();
                        library.AddBook(bookTitle);
                        break;
                    case 2:
                        Console.Write("Enter book title to borrow: ");
                        string borrowTitle = Console.ReadLine();
                        Console.Write("Enter your name: ");
                        string borrowerName = Console.ReadLine();
                        library.BorrowBook(borrowTitle, borrowerName);
                        break;
                    case 3:
                        Console.Write("Enter book title to return: ");
                        string returnTitle = Console.ReadLine();
                        library.ReturnBook(returnTitle);
                        break;
                    case 4:
                        library.DisplayBooks();
                        break;
                    case 5:
                        Console.WriteLine("Exiting program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
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