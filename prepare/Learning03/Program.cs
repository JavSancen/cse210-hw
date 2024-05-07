using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the numerator:");
        int numerator;
        while (!int.TryParse(Console.ReadLine(), out numerator))
        {
            Console.WriteLine("Invalid input. Please enter an integer for the numerator:");
        }

        Console.WriteLine("Enter the denominator (cannot be zero):");
        int denominator;
        while (!int.TryParse(Console.ReadLine(), out denominator) || denominator == 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-zero integer for the denominator:");
        }

        // Create a new Fraction object with user-provided values
        Fraction fraction = new Fraction(numerator, denominator);

        // Print the string representation of the fraction
        Console.WriteLine($"Fraction: {fraction.GetFractionString()}");

        // Print the decimal representation of the fraction
        Console.WriteLine($"Decimal: {fraction.GetDecimalValue()}");
    }
}