using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the University Student Management System");
            while (true)
            {
                //User Menu
                Console.WriteLine($"------------------------------------------------------------------");
                Console.WriteLine($"1. Add Student");
                Console.WriteLine($"2. Display All Students");
                Console.WriteLine($"3. Delete Student");
                Console.WriteLine($"4. Search Student");
                Console.WriteLine($"5. Exit");
                Console.WriteLine($"------------------------------------------------------------------");
                Console.Write($"Enter your choice: ");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddStudent();
                            break;
                        case 2:
                            DisplayAllStudent();
                            break;
                        case 3:
                            DeleteStudent();
                            break;
                        case 4:
                            SearchStudent();
                            break;
                        case 5:
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

        static void AddStudent()
        {
            Console.WriteLine($"------------------------------------------------------------------");
            Console.WriteLine($"Enter Student Details:");

            Console.Write($"Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write($"Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write($"Enter Student Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write($"Enter Student Department: ");
            string department = Console.ReadLine();
            Student newStudent = new Student(id, name, age, department);

            students.Add(newStudent);
            Console.WriteLine("Student added successfully!");



        }
        static void DisplayAllStudent()
        {
            Console.WriteLine($"------------------------------------------------------------------");

            if (students.Any())
            {
                Console.WriteLine("List of Students:");
                var allStudents = from student in students
                                  select student;
                foreach (var student in allStudents)
                {
                    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, Department: {student.Department}");
                }
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("No students found.");
            }
        }
        static void DeleteStudent()
        {
            Console.WriteLine($"------------------------------------------------------------------");
            Console.Write("Enter Student ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            var studentToRemove = students.FirstOrDefault(s => s.Id == id);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                Console.WriteLine("Student deleted successfully!");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
        static void SearchStudent()
        {
            Console.WriteLine($"------------------------------------------------------------------");
            Console.Write("Enter Student ID to search: ");
            int id = int.Parse(Console.ReadLine());
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                Console.WriteLine($"Found Student: {student}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
    }
}