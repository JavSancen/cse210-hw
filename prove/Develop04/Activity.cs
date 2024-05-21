using System;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}: {_description}");
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine($"Ending {_name}. Duration: {_duration} minutes.");
    }

    protected void ShowCountDown(int seconds)
    {
        Console.WriteLine($"Starting in {seconds} seconds...");
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b"); // Clear the countdown number
            System.Threading.Thread.Sleep(500); // Pause before showing the next number
        }
        Console.WriteLine();
    }

    protected void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write("+");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
            System.Threading.Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the - character
        }
        Console.WriteLine(); // Move to the next line after the spinner finishes
    }
}