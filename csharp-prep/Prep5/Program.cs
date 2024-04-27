using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the methods defined within Main. Or it will not being working.
        DisplayMessage();
        string userName = GetUserName();
        AddNumber(userName);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string GetUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static void AddNumber(string userName)
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        int squareNumber = favoriteNumber * favoriteNumber;
        Console.WriteLine($"Hello {userName}, the square of your number is {squareNumber}");
    }
}