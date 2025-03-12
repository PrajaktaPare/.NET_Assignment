using System;

namespace Assignment_2
{
    class Program
    {
        static void menu()
        {
            Console.WriteLine("1 - Add");
            Console.WriteLine("2 - Sub");
            Console.WriteLine("3 - Mul");
            Console.WriteLine("4 - Div");
            Console.WriteLine("5 - Per");
            Console.WriteLine("6 - Exit");
        }

        static void Add(double a, double b) => Console.WriteLine($"Addition: {a + b}");
        static void Sub(double a, double b) => Console.WriteLine($"Subtraction: {a - b}");
        static void Mul(double a, double b) => Console.WriteLine($"Multiplication: {a * b}");
        static void Div(double a, double b) => Console.WriteLine(b != 0 ? $"Division: {a / b}" : "Cannot divide by zero");
        static void Per(double total, double obtained) => Console.WriteLine(total != 0 ? $"Percentage: {(obtained / total) * 100}%" : "Total cannot be zero");

        static void Main(string[] args)
        {
            double n1, n2;

            Console.Write("Enter First Number (int or double): ");
            while (!double.TryParse(Console.ReadLine(), out n1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write("Enter First Number (int or double): ");
            }

            Console.Write("Enter Second Number (int or double): ");
            while (!double.TryParse(Console.ReadLine(), out n2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write("Enter Second Number (int or double): ");
            }

            int opt;
            do
            {
                menu();
                if (!int.TryParse(Console.ReadLine(), out opt) || opt < 1 || opt > 6)
                {
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 6.");
                    continue;
                }

                switch (opt)
                {
                    case 1: Add(n1, n2); break;
                    case 2: Sub(n1, n2); break;
                    case 3: Mul(n1, n2); break;
                    case 4: Div(n1, n2); break;
                    case 5: Per(n1, n2); break;
                    case 6: return;
                }
            } while (true);
        }
    }
}
