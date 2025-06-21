using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    public class LibraryApp
    {
        private Library library;
        private User currentUser;

        public LibraryApp()
        {
            library = new Library();
        }

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Advanced Library Management System!\n");
            AuthenticateUser();
            MainMenu();
        }

        private void AuthenticateUser()
        {
            // Simulate authentication for demo (expand with real logic)
            Console.WriteLine("Login as: 1. Admin 2. Librarian 3. Member");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": currentUser = new Admin("admin", "Admin"); break;
                case "2": currentUser = new Librarian("librarian", "Librarian"); break;
                case "3": currentUser = new Member("member", "Member"); break;
                default: Console.WriteLine("Invalid. Try again."); AuthenticateUser(); break;
            }
        }

        private void MainMenu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nMain Menu:");
                Console.WriteLine("1. Book Management");
                Console.WriteLine("2. Member Management");
                Console.WriteLine("3. Borrow/Return Books");
                Console.WriteLine("4. Reservations");
                Console.WriteLine("5. Reports");
                Console.WriteLine("6. Notifications");
                Console.WriteLine("0. Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1": BookManagementMenu(); break;
                    case "2": MemberManagementMenu(); break;
                    case "3": BorrowReturnMenu(); break;
                    case "4": ReservationMenu(); break;
                    case "5": ReportsMenu(); break;
                    case "6": NotificationsMenu(); break;
                    case "0": running = false; break;
                    default: Console.WriteLine("Invalid option."); break;
                }
            }
        }

        private void BookManagementMenu() { /* To be implemented */ }
        private void MemberManagementMenu() { /* To be implemented */ }
        private void BorrowReturnMenu() { /* To be implemented */ }
        private void ReservationMenu() { /* To be implemented */ }
        private void ReportsMenu() { /* To be implemented */ }
        private void NotificationsMenu() { /* To be implemented */ }
    }
}