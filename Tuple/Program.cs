using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        
        // Tuple
        Console.Write($"Enter Name :");
        string name = Console.ReadLine();
        Console.Write($"Enter Age :");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Enter Occupation :");
        string occupation = Console.ReadLine();
        var personData = Tuple.Create(name, age, occupation);
        Console.WriteLine($"\nPerson Data : ");
        Console.WriteLine($"Name : {personData.Item1}");
        Console.WriteLine($"Age : {personData.Item2}");
        Console.WriteLine($"Occupation : {personData.Item3}");

        // Array of Tuples

        object[] person = {
            personData.Item1,
            personData.Item2,
            personData.Item3
        };
        Console.WriteLine($"\nPerson Data : ");
        foreach (var item in person)
        {
            Console.WriteLine(item);
        }
        
    }
}
