using System;
// Importing the List class from System.Collections.Generic
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Dictionary Example in C#
        Console.WriteLine("Dictionary Example in C#");
        // This example demonstrates the use of a Dictionary in C#
        // A Dictionary is a collection that maps keys to values
        // It is part of the System.Collections.Generic namespace
        // A Dictionary can hold key-value pairs of any type
        // Here we will create a Dictionary of strings and integers and perform some basic operations on it
        // Creating a new Dictionary of strings and integers
        // The Dictionary class provides methods to add, remove, and search for elements
        // It also provides properties to get the count of elements and check if the dictionary is empty
        // Using the Dictionary class from System.Collections.Generic
        // The Dictionary class is a generic collection, meaning it can hold key-value pairs of any type
        // A Dictionary is similar to a dictionary in other programming languages
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        // Adding key-value pairs to the dictionary
        dictionary.Add("apple", 1);
        dictionary.Add("banana", 2);
        dictionary.Add("cherry", 3);
        // Displaying the key-value pairs in the dictionary
        Console.WriteLine("Key-Value pairs in the dictionary:");
        foreach (KeyValuePair<string, int> pair in dictionary)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
        // Removing a key-value pair from the dictionary
        dictionary.Remove("banana");
        // Displaying the updated key-value pairs in the dictionary
        Console.WriteLine("Updated key-value pairs in the dictionary:");
        foreach (KeyValuePair<string, int> pair in dictionary)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }

        Console.WriteLine("----------------------------------------------------------\n");
        
        Console.WriteLine("List Example in C#");
        // This example demonstrates the use of a List in C#
        // A List is a collection that can dynamically grow and shrink in size
        // It is part of the System.Collections.Generic namespace
        // A List can hold elements of a specific type, such as int, string, etc.
        // Here we will create a List of integers and perform some basic operations on it
        // Creating a new List of integers
        // The List class provides methods to add, remove, and search for elements
        // It also provides properties to get the count of elements and check if the list is empty
        // Using the List class from System.Collections.Generic
        // The List class is a generic collection, meaning it can hold any type of object
        // A List is similar to an array, but it can grow and shrink dynamically
        
        // List in C# 
        List<int> numbers = new List<int>();
        // Adding elements to the list
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        // Displaying the elements in the list
        Console.WriteLine("Numbers in the list:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        // Removing an element from the list
        numbers.Remove(2);
        // Displaying the elements after removal
        Console.WriteLine("Numbers in the list after removal:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        // Checking if an element exists in the list
        if (numbers.Contains(3))
        {
            Console.WriteLine("The number 3 exists in the list.");
        }
        else
        {
            Console.WriteLine("The number 3 does not exist in the list.");
        }
        // Getting the count of elements in the list
        Console.WriteLine($"The list contains {numbers.Count} elements.");
        // Clearing the list
        numbers.Clear();
        // Displaying the count after clearing
        Console.WriteLine($"The list contains {numbers.Count} elements after clearing.");
        // Demonstrating the use of a generic list with strings
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
        // Displaying the elements in the string list
        Console.WriteLine("Fruits in the list:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        // Adding more fruits
        fruits.Add("Date");
        fruits.Add("Elderberry");
        // Displaying the updated list of fruits
        Console.WriteLine("Updated fruits in the list:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}