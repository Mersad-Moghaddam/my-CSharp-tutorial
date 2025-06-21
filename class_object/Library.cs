using System;
namespace LibraryManagementSystem
{
    internal class Library
{
    private string libraryName;
    private int bookEntered;
    private int bookCount = 0;

        private List<string> books = new();

    private int libraryCapacity = 0;

    public Library(string name, int maxBooks, int capacity)
        {
            libraryName = name;
            bookEntered = maxBooks;
            libraryCapacity = capacity;
            Console.WriteLine($"Library Name : {libraryName} is Created");
            Console.WriteLine($"The Number of books in {libraryName} = {bookCount}");
        }

    public string Library_name
    {
        get { return libraryName; }
        set { libraryName = value; }
    }
    public void AddBook(string bookTitle)
    {
        if (bookEntered > 0)
        {
            bookCount++;
            Console.WriteLine($"Book {bookTitle} added to the library");
                books.Add(bookTitle);
            bookEntered--;

        }
        else
        {
            Console.WriteLine($"Library is full");

        }
    }

        public void DisplayBooks()
        {
            Console.WriteLine($"The Capacity of {libraryName} = {libraryCapacity}");

            Console.WriteLine($"Book available in the {libraryName} are : {bookCount}");
            
            Console.Write($"Library Books : ");
            
            foreach (string book in books)
            {
                Console.Write($"{book}\t");

            }        

    }

    ~Library()
    {
        Console.WriteLine($"Library{libraryName} is Destroyed");
        
    }
}
}
