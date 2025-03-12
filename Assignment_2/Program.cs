using System;

namespace Assignment_2
{
    // Interface defining calculator operations
    interface ICalculator
    {
        double Sum(double a, double b);
        double Sum(double a, double b, double c); // Overloaded Sum method
        double Subtract(double a, double b);
        double Subtract(double a, double b, double c); // Overloaded Subtract method
        double Multiply(double a, double b);
        double Divide(double a, double b);
        double Percentage(double total, double obtained);
    }

    // Class implementing the calculator operations
    class Calculator : ICalculator
    {
        public double Sum(double a, double b) => a + b;
        public double Sum(double a, double b, double c) => a + b + c; // Overloaded method

        public double Subtract(double a, double b) => a - b;
        public double Subtract(double a, double b, double c) => a - b - c; // Overloaded method

        public double Multiply(double a, double b) => a * b;

        public double Divide(double a, double b) => b != 0 ? a / b : throw new DivideByZeroException("Cannot divide by zero");

        public double Percentage(double total, double obtained) => total != 0 ? (obtained / total) * 100 : throw new ArgumentException("Total cannot be zero");
    }

    class Program
    {
        static void DisplayMenu()
        {
            Console.WriteLine("\nSelect an Operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Percentage");
            Console.WriteLine("6 - Exit");
        }

        static double GetValidNumber(string prompt)
        {
            double number;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out number))
                    return number;
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        static void Main()
        {
            Calculator calc = new Calculator();

            while (true)
            {
                DisplayMenu();

                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 6)
                {
                    if (choice == 6) break; // Exit the loop

                    double num1 = GetValidNumber("Enter First Number: ");
                    double num2 = GetValidNumber("Enter Second Number: ");

                    switch (choice)
                    {
                        case 1: // Addition
                            Console.Write("Do you want to add another number? (y/n): ");
                            if (Console.ReadLine().ToLower() == "y")
                            {
                                double num3 = GetValidNumber("Enter Third Number: ");
                                Console.WriteLine($"Su
