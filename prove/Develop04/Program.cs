using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Activity Program!");

        BreathingActivity breathing = new BreathingActivity();
        ReflectingActivity reflecting = new ReflectingActivity();
        ListingActivity listing = new ListingActivity();

        while (true)
        {
            Console.WriteLine("\nChoose an activity to start:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    breathing.Run();
                    break;
                case "2":
                    reflecting.Run();
                    break;
                case "3":
                    listing.Run();
                    break;
                case "4":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    break;
            }
        }
    }
}