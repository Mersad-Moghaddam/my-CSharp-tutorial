using System;

class Program
{
    static void Main()
    {
        // Replacing
        string sayHello = "Hello World";
        Console.WriteLine(sayHello);

        sayHello = sayHello.Replace("Hello", "Greeting");
        Console.WriteLine(sayHello);

        Console.WriteLine(sayHello.ToUpper());
        Console.WriteLine(sayHello.ToLower());
        Console.WriteLine(sayHello.Contains("Greeting"));
        Console.WriteLine(sayHello.StartsWith("Greeting"));
        Console.WriteLine(sayHello.EndsWith("World"));
        Console.WriteLine(sayHello.IndexOf("Greeting"));
        Console.WriteLine(sayHello.LastIndexOf("World"));
        Console.WriteLine(sayHello.Length);
        Console.WriteLine(sayHello.Substring(0, 8));
        Console.WriteLine(sayHello.Substring(8, 5));
        Console.WriteLine(sayHello.Substring(8)); // From index 8 to the end
        Console.WriteLine(sayHello.Split(' ')); // Split by space
        
        



        //---------------------------------------------------------//
        Console.WriteLine($"----------------------------------------------------------\n");
        
        //  Trim
        string greeting = "         Hello World                     ";
        Console.WriteLine($"[{greeting}]");
        string trimGreeting_end = greeting.TrimEnd();
        string trimGreeting_start = greeting.TrimStart();
        string trimGreeting_mid = greeting.Trim();
        Console.WriteLine($"Trim End = [{trimGreeting_end}]\nTrim Start = [{trimGreeting_start}]\nTrim = [{trimGreeting_mid}]\n");
        
        
    }
 }