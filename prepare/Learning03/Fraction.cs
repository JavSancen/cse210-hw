using System;

public class Fraction
{
    private int numerator;   // Top number
    private int denominator; // Bottom number

    // Default constructor initializing the fraction to 1/1
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constructor that takes a single parameter for the numerator, defaulting the denominator to 1
    public Fraction(int numerator)
    {
        this.numerator = numerator;
        this.denominator = 1;
    }

    // Constructor to create a fraction with given numerator and denominator
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
        }

        this.numerator = numerator;
        this.denominator = denominator;
    }

    // Properties to expose numerator and denominator safely
    public int Numerator
    {
        get { return numerator; }
        set { numerator = value; }
    }

    public int Denominator
    {
        get { return denominator; }
        set
        {
            if (value == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.", nameof(value));
            }
            denominator = value;
        }
    }

    // Method to get the fraction as a string
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    // Method to get the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }

    // Override ToString method to represent the fraction as a string
    public override string ToString()
    {
        return GetFractionString();
    }
}