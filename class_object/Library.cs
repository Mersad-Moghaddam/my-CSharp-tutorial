using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    internal class Library
    {
        private string libraryName;
        private int libraryCapacity;
        private List<string> books = new();
        private Dictionary<string, string> borrowedBooks = new(); // Tracks borrowed books and their borrowers

        public Library(string name, int capacity)
        {
            libraryName = name;
            libraryCapacity = capacity;
            Console.WriteLine($"Library '{libraryName}' created with a capacity of {libraryCapacity} books.");
        }

        public void AddBook(string bookTitle)
        {
            if (books.Count < libraryCapacity)
            {
                books.Add(bookTitle);
                Console.WriteLine($"Book '{bookTitle}' added to the library.");
            }
            else
            {
                Console.WriteLine("Library is at full capacity. Cannot add more books.");
            }
        }

        public void BorrowBook(string bookTitle, string borrowerName)
        {
            if (books.Contains(bookTitle))
            {
                books.Remove(bookTitle);
                borrowedBooks[bookTitle] = borrowerName;
                Console.WriteLine($"Book '{bookTitle}' borrowed by {borrowerName}.");
            }
            else if (borrowedBooks.ContainsKey(bookTitle))
            {
                Console.WriteLine($"Book '{bookTitle}' is already borrowed by {borrowedBooks[bookTitle]}.");
            }
            else
            {
                Console.WriteLine($"Book '{bookTitle}' is not available in the library.");
            }
        }

        public void ReturnBook(string bookTitle)
        {
            if (borrowedBooks.ContainsKey(bookTitle))
            {
                borrowedBooks.Remove(bookTitle);
                books.Add(bookTitle);
                Console.WriteLine($"Book '{bookTitle}' returned to the library.");
            }
            else
            {
                Console.WriteLine($"Book '{bookTitle}' was not borrowed from this library.");
            }
        }

        public void DisplayBooks()
        {
            Console.WriteLine($"Books available in '{libraryName}':");
            foreach (var book in books)
            {
                Console.WriteLine($"- {book}");
            }

            Console.WriteLine("\nBorrowed Books:");
            foreach (var entry in borrowedBooks)
            {
                Console.WriteLine($"- {entry.Key} (Borrowed by: {entry.Value})");
            }
        }
    }
}
