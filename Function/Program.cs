using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-----------------------------------§");
        // List filtering with KeyValuePair in C#
        Console.WriteLine("List Filtering with KeyValuePair in C#\n");
        // Create a list of KeyValuePairs
        var pairs = new List<KeyValuePair<string, int>>
        {
            new KeyValuePair<string, int>("apple", 1),
            new KeyValuePair<string, int>("banana", 2),
            new KeyValuePair<string, int>("cherry", 3),
            new KeyValuePair<string, int>("date", 4)
        };
        Console.WriteLine($"Original List:");
        // Print the original list
        foreach (var pair in pairs)
        {
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
        }
        
        // Filter the list by value
        var filteredList = pairs.Where(pair => pair.Value > 2).ToList();
        Console.WriteLine($"Filtered List (Value > 2):");
        
        // Print the filtered list
        foreach (var pair in filteredList)
        {
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
        }

        
        Console.WriteLine("----------------------------------§");
        // key-value-pairs in C#
        var list = new List<KeyValuePair<string, int>>
        {
            new KeyValuePair<string, int>("apple", 1),
            new KeyValuePair<string, int>("banana", 2),
            new KeyValuePair<string, int>("cherry", 3)
        };
       list.ForEach(kvp => 
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        });
        Console.WriteLine("----------------------------------§");
        
        // null check in C#
        string? name = null;
        if (name == null)
        {
            Console.WriteLine("name is null");
        }
        else
        {
            Console.WriteLine("name is not null");
        }
        // using null-conditional operator in C#
        string? nullableName = null;
        Console.WriteLine($"The length of the nullable name is: {nullableName?.Length ?? 0}");
        
        int cond = name?.Count() ?? 0;
        Console.WriteLine($"The length of the name is: {cond}");
        object test = "Hello C#";
        if (test is string str)
        {
            Console.WriteLine($"the object is a string: {str}");
        }
        else if (test is int i)
        {
            Console.WriteLine($"the object is an int: {i}");
        }
        else
        {
            Console.WriteLine("Unknown type");
        }
        // Call the function to print the message
        PrintMessage();
        // Varies function in C#
        Console.WriteLine("The sum of 5 and 10 is: " + Sum(5, 10));
        Console.WriteLine("The sum of 5, 10, and 15 is: " + Sum(5, 10, 15));

        // Function with string return type
        Console.WriteLine("The concatenation of 'Hello' and 'World' is: " + Concatenate("Hello", "World"));
        // Function to calculate Fibonacci series
        Console.WriteLine("The 10th Fibonacci number is: " + Fibonacci(10));
        // Function to calculate discount
        Console.WriteLine("The price after a 20% discount on $100 is: " + CalculateDiscount(100, 20));
        // Function with optional parameters
        Console.WriteLine("The sum of 5 and 10 is: " + Calculate(5, 10));
        Console.WriteLine("The result of 5 minus 10 is: " + Calculate(5, 10, operation: "minus"));
        Console.WriteLine("The result of 5 multiplied by 10 is: " + Calculate(5, 10, operation: "multiply"));
        Console.WriteLine("The result of 15 divided by 10 is: " + Calculate(200, 10, operation: "divide"));
        

    }
    // Complete Functions tutorial in C#
    // a simple function that returns the sum of two integers
    static int Sum(int a, int b) => a + b;

    // a function that returns the sum of three integers
    static int Sum(int a, int b, int c) => a + b + c;

    // a function with string return type
    static string Concatenate(string a, string b) => a + b;

    // a function that calculate fibonacci series
    static int Fibonacci(int n)
    {
        if (n <= 1) return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    // a function that receive a price of an item and a discount percentage
    static double CalculateDiscount(double price, double discountPercentage) => price * (1 - discountPercentage / 100);

    
    // a complete calculation function with optional parameters
    static int Calculate(int a, int b, int c = 0, string operation = "sum")
    {
        switch (operation.ToLower())
        {
            case "sum":
                return a + b + c;
            case "minus":
                return a - b - c;
            case "multiply":
                return a * b * c;
            case "divide":
                if (b == 0 || a == 0) throw new DivideByZeroException("Cannot divide by zero");
                return a / b ;
            default:
                throw new ArgumentException("Invalid operation");
        }
    }

    // Function to print a message
    static void PrintMessage()
    {
        Console.WriteLine("i am a function!");
    }
}