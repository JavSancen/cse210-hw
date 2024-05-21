using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity()
        : base("Listing Activity", "An activity to list out tasks or thoughts.", 5)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowCountDown(3);
        Console.WriteLine(GetRandomPrompt());
        List<string> userResponses = GetListFromUser();
        int count = userResponses.Count;
        Console.WriteLine($"You listed {count} items.");
        ShowSpinner(5);
        DisplayEndingMessage();
        Console.WriteLine($"Congratulations on completing the Listing Activity! You listed a total of {count} items.");
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        string input;

        Console.WriteLine("Enter your items (type 'done' to finish):");
        while (true)
        {
            input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }
            responses.Add(input);
        }

        return responses;
    }
}
