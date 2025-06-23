using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        // // Using LINQ to filter even numbers and square them
        // var evenNumber = from num in numbers
        //                  where num % 2 == 0
        //                  select num;
        // Console.WriteLine($"Even numbers: {string.Join(", ", evenNumber)}");
        // Flight Information System using LINQ
        Console.Clear();
        
        List<Flight> flights = new List<Flight>
        {
            new() { FlightNumber = "AA101", DepartureCity = "New York", ArrivalCity = "Los Angeles", DepartureTime = new DateTime(2023, 10, 1, 8, 0, 0), ArrivalTime = new DateTime(2023, 10, 1, 11, 0, 0) },
            new() { FlightNumber = "BA202", DepartureCity = "Chicago", ArrivalCity = "Miami", DepartureTime = new DateTime(2023, 10, 1, 9, 30, 0), ArrivalTime = new DateTime(2023, 10, 1, 12, 30, 0) },
            new() { FlightNumber = "CA303", DepartureCity = "Los Angeles", ArrivalCity = "New York", DepartureTime = new DateTime(2023, 10, 1, 14, 0, 0), ArrivalTime = new DateTime(2023, 10, 1, 20, 0, 0) },
            new() { FlightNumber = "DA404", DepartureCity = "Miami", ArrivalCity = "Chicago", DepartureTime = new DateTime(2023, 10, 1, 15, 15, 0), ArrivalTime = new DateTime(2023, 10, 1, 18, 15, 0) },
            new() { FlightNumber = "EA505", DepartureCity = "New York", ArrivalCity = "Miami", DepartureTime = new DateTime(2023, 10, 1, 10, 0, 0), ArrivalTime = new DateTime(2023, 10, 1, 13, 0, 0) },
            new() { FlightNumber = "FA606", DepartureCity = "Chicago", ArrivalCity = "Los Angeles", DepartureTime = new DateTime(2023, 10, 1, 11, 45, 0), ArrivalTime = new DateTime(2023, 10, 1, 14, 45, 0) },
            new() { FlightNumber = "GA707", DepartureCity = "Los Angeles", ArrivalCity = "Miami", DepartureTime = new DateTime(2023, 10, 1, 16, 30, 0), ArrivalTime = new DateTime(2023, 10, 1, 22, 30, 0) },
            new() { FlightNumber = "HA808", DepartureCity = "Miami", ArrivalCity = "New York", DepartureTime = new DateTime(2023, 10, 1, 17, 0, 0), ArrivalTime = new DateTime(2023, 10, 1, 20, 0, 0) },
            new() { FlightNumber = "IA909", DepartureCity = "New York", ArrivalCity = "Chicago", DepartureTime = new DateTime(2023, 10, 1, 12, 30, 0), ArrivalTime = new DateTime(2023, 10, 1, 15, 30, 0) },
            new() { FlightNumber = "JA010", DepartureCity = "Chicago", ArrivalCity = "Los Angeles", DepartureTime = new DateTime(2023, 10, 1, 13, 15, 0), ArrivalTime = new DateTime(2023, 10, 1, 16, 15, 0) }

        };
        Console.WriteLine("Welcome to the Flight Information System!");
    
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. List all flights");
            Console.WriteLine("2. Search for flights");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            if(int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        ListAllFlight(flights);
                        break;
                    case 2:
                        SearchFlights(flights);
                        break;
                    case 3:
                        Console.WriteLine("Exiting the system. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            
        }
    }


    internal class Flight
    {
        public string FlightNumber { get; set; }
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }

        public override string ToString() =>
            $"{FlightNumber} from {DepartureCity} to {ArrivalCity}, departs at {DepartureTime}, arrives at {ArrivalTime}\n";

    }

    static void ListAllFlight(List<Flight> flights)
    {
        Console.WriteLine($"---------------------------------------------");
        
        Console.WriteLine($"All Flights: \n");
        flights.ForEach(Console.WriteLine);

    }
    static void SearchFlights(List<Flight> flights)
    {
        Console.WriteLine($"---------------------------------------------");
        Console.Write($"Enter Departure City : ");
        string departureCity = Console.ReadLine();
        Console.Write($"Enter Arrival City : ");
        string arrivalCity = Console.ReadLine();

        var matchingFlights = flights.Where(
        f => f.DepartureCity.Equals(departureCity, StringComparison.OrdinalIgnoreCase) &&
             f.ArrivalCity.Equals(arrivalCity, StringComparison.OrdinalIgnoreCase)).ToList();
        Console.WriteLine(matchingFlights.Any() 
            ? $"Flights from {departureCity} to {arrivalCity}:\n{string.Join("\n", matchingFlights)}"
            : $"No flights found from {departureCity} to {arrivalCity}.");
    }
}