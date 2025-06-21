using System;
namespace Gym
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            Console.WriteLine("Welcome to the Gym Membership System!");
            Console.WriteLine("This program demonstrates the use of an abstract class and an interface for gym membership management.");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Gym Membership Management System");
            // Create a new premium member
            // and demonstrate the functionality
            // of the PremiumMember class.
            // This is a simple console application that simulates a gym membership system.
            // get the member details from user input
            Console.Write("Enter member name: ");
            string name = Console.ReadLine();
            Console.Write("Enter member age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter member ID: ");
            int memberId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter member email: ");
            string email = Console.ReadLine();
            Console.Write("Enter membership plan: ");
            string membershipPlan = Console.ReadLine();
            // create a new premium member
            PremiumMember premiumMember = new PremiumMember(name, age, memberId, email, membershipPlan);
            Console.Clear();
            
            Console.WriteLine($"-----------------------------------------------------------");
            Console.WriteLine("Registering a new premium member...");
            premiumMember.RegisterMember();
            // Add Menu to manage the membership - its up unto the user to choose exit
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("1. Cancel Membership");
                Console.WriteLine("2. Update Membership");
                Console.WriteLine("3. Display Membership Details");
                Console.WriteLine("4. Exit");
                Console.WriteLine("-----------------------------------------------------------");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        premiumMember.CancelMembership();
                        break;
                    case 2:
                        Console.Write("Enter new membership plan: ");
                        string newPlan = Console.ReadLine();
                        premiumMember.UpdateMembership(newPlan);
                        break;
                    case 3:
                        premiumMember.DisplayMembershipDetails();
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            Console.WriteLine("Thank you for using the Gym Membership System. Goodbye!");
            
            
        }
    }
}