using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Find Minimum and Max in Array:
        int[] myNumbers = new int[6];
        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Enter Number {i + 1} : ");
            myNumbers[i] = int.Parse(Console.ReadLine());
        }
        int max = myNumbers[0];
        int min = myNumbers[0];
        foreach (int n in myNumbers)
        {
            if (n >= max)
            {
                max = n;
            }
            if (n <= min)
            {
                min = n;
            }
        }
        Console.WriteLine($"Max = {max}\nMin = {min}\n\n\n ");
        // Reverse Array
        int end = myNumbers.Length - 1;
        int start = 0;
        while (start < end)
        {
            (myNumbers[end], myNumbers[start]) = (myNumbers[start], myNumbers[end]);
            start++;
            end--;
        }
        foreach (int s in myNumbers)
        {
            Console.Write($"{s}\t");

        }

        Console.WriteLine("\n\n");

        // Title: Array Demonstration in C#
        // This program demonstrates various types of arrays in C#.
        Console.WriteLine("Array Demonstration in C#\n");
        // single-dimensional array
        int[] singleArray = [1, 2, 3, 4, 5];
        Console.WriteLine("Single-dimensional Array:");
        foreach (int item in singleArray)
        {
            Console.Write($"{item}\t");
        }
        Console.WriteLine("\n");

        // multi-dimensional array
        int[,] multiArray = new int[3, 3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        Console.WriteLine("Multi-dimensional Array:");
        for (int i = 0; i < multiArray.GetLength(0); i++)
        {
            for (int j = 0; j < multiArray.GetLength(1); j++)
            {
                Console.Write($"{multiArray[i, j]}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n");
        // Jagged Array
        int[][] jaggedArray = [[1, 2, 3], [4, 5], [6, 7, 8, 9]];
        Console.WriteLine("Jagged Array:");
        foreach (var row in jaggedArray)
        {
            foreach (var item in row)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n");

        // 3 dimensional array
        int[,,] threeDArray = new int[2, 2, 2]
        {
            { { 1, 2 }, { 3, 4 } },
            { { 5, 6 }, { 7, 8 } }
        };
        Console.WriteLine("3-dimensional Array:");
        for (int i = 0; i < threeDArray.GetLength(0); i++)
        {
            for (int j = 0; j < threeDArray.GetLength(1); j++)
            {
                for (int k = 0; k < threeDArray.GetLength(2); k++)
                {
                    Console.Write($"{threeDArray[i, j, k]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n");

        // Int Array
        int[] number = new int[5];
        for (int i = 0; i < number.Length; i++)
        {
            number[i] = i + 1;
        }
        Console.WriteLine("integer Array:");
        foreach (var num in number)
        {
            Console.Write($"{num}\t ");
        }

        // String Array
        Console.WriteLine("\n");
        string[] names = new string[5];
        for (int i = 0; i < names.Length; i++)
        {
            Console.Write($"Enter name {i + 1}: ");
            names[i] = Console.ReadLine();
        }
        Console.WriteLine("\nString Array:");
        foreach (var name in names)
        {
            Console.Write($"{name}\t ");
        }

        // Double Array
        Console.WriteLine("\n");
        double[] prices = new double[5];
        for (int i = 0; i < prices.Length; i++)
        {
            Console.Write($"Enter price {i + 1}: ");
            while (!double.TryParse(Console.ReadLine(), out prices[i]))
            {
                Console.Write("Invalid input. Please enter a valid price: ");
            }
        }
        Console.WriteLine("\nDouble Array:");
        foreach (var price in prices)
        {
            Console.Write($"{price}\t ");
        }
        // weekdays Array
        Console.WriteLine("\n");
        string[] weekdays = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];
        Console.WriteLine("\nWeekdays Array:");
        foreach (var day in weekdays)
        {
            Console.Write($"{day}\t ");
        }
        Console.WriteLine("\n");

        // Array of Objects
        Person[] people = new Person[3];
        for (int i = 0; i < people.Length; i++)
        {
            Console.Write($"Enter name for person {i + 1}: ");
            string personName = Console.ReadLine();
            Console.Write($"Enter age for person {i + 1}: ");
            int personAge;
            while (!int.TryParse(Console.ReadLine(), out personAge))
            {
                Console.Write("Invalid input. Please enter a valid age: ");
            }
            people[i] = new Person { Name = personName, Age = personAge };
        }
        Console.WriteLine("\nArray of Objects:");
        foreach (var person in people)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }

        // Array of split string to Characters
        Console.WriteLine("\n");
        Console.Write("Enter a string to split into characters: ");
        string inputString = Console.ReadLine();
        char[] characters = inputString.ToCharArray();
        Console.WriteLine("\nCharacter Array:");
        foreach (var character in characters)
        {
            Console.Write($"{character}\t ");
        }
        Console.WriteLine("\n");
        // Array of split string to Words
        Console.Write("Enter a string to split into words: ");
        string inputWords = Console.ReadLine();
        string[] words = inputWords.Split(' ');
        Console.WriteLine("\nWords Array:");
        foreach (var word in words)
        {
            Console.Write($"{word}\t ");
        }
        Console.WriteLine("\n");

    }


    public void ReverseArray(int[] arr)
    {
        int count = arr.Count();
        
        for (int i = 0; i < count; i++)
        {
            for (int j = count; j > 0; j--)
            {
                (arr[j], arr[i]) = (arr[i], arr[j]);
            }
        }
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

}