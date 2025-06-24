using System;
using System.IO;
// using Newtonsoft.Json;
class Program
{
    static void Main()
    {
        // Console.WriteLine($"Enter The text you want to Save : ");

        // string text = Console.ReadLine();
        // ;
        // File.WriteAllText("ex.txt", text);
        // Console.WriteLine("File Write");
        // string readText = File.ReadAllText("ex.txt");
        // Console.WriteLine($"{readText}");
        // Json

        var person = { Name = "Mersad", Age = 23, Address = "Mashhad" };
        File.WriteAllText("person_data.json", JsonConvert.SerializeObject(person));
        Console.WriteLine($"Person Object Serialize into File");

        var deserializePerson = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText("person_data.json"));

        Console.WriteLine($"Deserialize Person : {deserializePerson.Name}, {deserializePerson.Age}, {deserializePerson.Address}");
        
        
        
        
        
    }
}