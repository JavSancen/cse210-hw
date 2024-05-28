using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _sessionScore; // Session score to store temporarily

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _sessionScore = 0;
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Display Player Information");
            Console.WriteLine("7. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    DisplayPlayerInfo();
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }


    public void DisplayPlayerInfo()
    {
        int totalScore = _score + _sessionScore; // Include session score in total score

        Console.WriteLine($"Session Score: {_sessionScore}");
        Console.WriteLine($"Total Score: {totalScore}");
    }
    public void ListGoalNames()
    {
        Console.WriteLine("Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            string details = goal.GetDetailsString();
            if (goal is SimpleGoal simpleGoal)
            {
                details += $", IsComplete: {simpleGoal.IsComplete()}";
            }
            else if (goal is ChecklistGoal checklistGoal)
            {
                details += $", Completed: {checklistGoal.GetDetailsString()}";
            }
            Console.WriteLine(details);
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Enter the goal type (SimpleGoal, EternalGoal, ChecklistGoal):");
        string type = Console.ReadLine();

        Console.WriteLine("Enter name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter description:");
        string description = Console.ReadLine();

        Console.WriteLine("Enter points:");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;

        switch (type)
        {
            case "SimpleGoal":
                goal = new SimpleGoal(name, description, points);
                break;
            case "EternalGoal":
                goal = new EternalGoal(name, description, points);
                break;
            case "ChecklistGoal":
                Console.WriteLine("Enter target (number of times to complete):");
                int target = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter bonus points for completing all targets:");
                int bonus = int.Parse(Console.ReadLine());

                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        _goals.Add(goal);
        Console.WriteLine("Goal created successfully.");
    }
    public void RecordEvent()
    {
        Console.WriteLine("Enter goal name:");
        string goalName = Console.ReadLine();

        Goal goal = _goals.Find(g => g.GetDetailsString().Contains(goalName));

        if (goal != null)
        {
            goal.RecordEvent();
            if (goal.IsComplete())
            {
                int pointsEarned = goal.Points;
                _sessionScore += pointsEarned; // Add points to session score

                if (goal is ChecklistGoal checklistGoal)
                {
                    _sessionScore += checklistGoal.Bonus; // Add bonus points to session score
                }
            }
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    // SaveScore method is no longer needed as session score is now handled within RecordEvent

    public void SaveGoals()
    {
        string fileName = "goals.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void SaveScore(int pointsEarned)
    {
        string fileName = "score.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            outputFile.WriteLine(pointsEarned);
        }
    }

    public void LoadGoals()
    {
        string fileName = "goals.txt";

        if (!File.Exists(fileName))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        _goals.Clear();

        using (StreamReader inputFile = new StreamReader(fileName))
        {
            string line;
            while ((line = inputFile.ReadLine()) != null)
            {
                string[] parts = line.Split(',');

                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                Goal goal = null;

                switch (type)
                {
                    case "SimpleGoal":
                        bool isComplete = bool.Parse(parts[4]);
                        goal = new SimpleGoal(name, description, points);
                        if (isComplete)
                        {
                            goal.RecordEvent();  // Mark it as complete
                        }
                        break;
                    case "EternalGoal":
                        goal = new EternalGoal(name, description, points);
                        break;
                    case "ChecklistGoal":
                        int amountCompleted = int.Parse(parts[4]);
                        int target = int.Parse(parts[5]);
                        int bonus = int.Parse(parts[6]);
                        goal = new ChecklistGoal(name, description, points, target, bonus);
                        for (int i = 0; i < amountCompleted; i++)
                        {
                            goal.RecordEvent();  // Set the completion status
                        }
                        break;
                    default:
                        Console.WriteLine("Unknown goal type.");
                        continue;
                }

                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
}