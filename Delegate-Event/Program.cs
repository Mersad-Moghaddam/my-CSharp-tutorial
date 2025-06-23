using System;
namespace Delegate_Event
{
    class Program
{
    // Delegate-Based Math Operation ( Calculator ) 
    public delegate int MathOperation(int a, int b);
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
    public static int Divide(int a, int b) {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return 0; // or throw an exception
        }
    }
    public static int Modulus(int a, int b) => a % b;
    public static int Power(int a, int b) => (int)Math.Pow(a, b);

    static int PerformOperation(MathOperation operation, int a, int b)
    {
        return operation(a, b);
    }



    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Delegate-Based Calculator!");
        Console.Write($"Enter first Number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Enter second Number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        MathOperation operation = null;
       

        do
        {
            Console.WriteLine($"---------------------------------------------------");
            
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Modulus");
            Console.WriteLine("6. Power");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice (1-7): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    operation = Add;
                    break;
                case "2":
                    operation = Subtract;
                    break;
                case "3":
                    operation = Multiply;
                    break;
                case "4":
                    operation = Divide;
                    break;
                case "5":
                    operation = Modulus;
                    break;
                case "6":
                    operation = Power;
                    break;
                case "7":
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue; // Skip to the next iteration of the loop
            }

            int result = PerformOperation(operation, firstNumber, secondNumber);
            Console.WriteLine($"Result: {result}");
        } while (true);
        
      


    }


}
}
