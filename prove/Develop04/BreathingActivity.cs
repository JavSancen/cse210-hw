using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 5)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("How many seconds do you want to do the breathing exercise?");
        int totalSeconds = GetUserInput();
        int laps = totalSeconds / 10; // Each lap includes 5 seconds for breathing in and 5 seconds for breathing out

        Console.WriteLine($"We will do {laps} laps of 5 seconds each for breathing in and out.");
        ShowCountDown(5);

        for (int i = 0; i < laps; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(5);

            Console.WriteLine("Breathe out...");
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }

    private int GetUserInput()
    {
        int seconds;
        while (true)
        {
            Console.Write("Enter the number of seconds (multiple of 10): ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out seconds) && seconds > 0 && seconds % 10 == 0)
            {
                break;
            }
            Console.WriteLine("Invalid input. Please enter a positive number that is a multiple of 10.");
        }
        return seconds;
    }
}