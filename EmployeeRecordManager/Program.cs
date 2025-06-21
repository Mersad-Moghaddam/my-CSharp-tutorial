using System;

namespace EmployeeRecordManager
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            Dictionary<string, string> employeeRecords = new();
            Console.WriteLine($"Enter Employee Records.\t Enter 'exit' to stop");
            while (true)
            {
                Console.Write($"Enter Employee ID: ");
                string employeeID = Console.ReadLine();

                if (employeeID.ToLower() == "exit") break;

                Console.Write($"Enter Employee name: ");
                string employeeName = Console.ReadLine();

                employeeRecords[employeeID] = employeeName;

            }
            Console.WriteLine($"Enter an Employee name to check the Records : ");
            string employeeNameToCheck = Console.ReadLine();

            bool employeeExists = false;

            foreach (var record in employeeRecords)
            {
                if (record.Value == employeeNameToCheck)
                {
                    employeeExists = true;
                    break;
                }

            }

            if (employeeExists)
            {
                Console.WriteLine($"The Employee {employeeNameToCheck} exist in Records");
            }
            else
            {
                Console.WriteLine($"The Employee {employeeNameToCheck} does not Exist in Records !!");
                
            }
        }
    }
}