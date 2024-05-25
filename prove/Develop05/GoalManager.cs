using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private LevelManager _levelManager;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _levelManager = new LevelManager();
    }

    public int GetScore()
    {
        return _score;
    }

    public int GetCurrentLevel() // Added for leveling 
    {
        return _levelManager.GetCurrentLevel();
    }

    public int GetCurrentXP() // Added for leveling
    {
        return _levelManager.GetCurrentXP();
    }

    public int GetXPToNextLevel() // Added for leveling
    {
        return _levelManager.GetXPToNextLevel();
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Goals: ");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are: ");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid choice. Goal not created.");
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Choose a goal to record: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        Console.Write("Choice: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice > 0 && choice <= _goals.Count) // Changed to accomodate leveling component
        {
            int points = _goals[choice - 1].RecordEvent();
            _score += points;
            _levelManager.AddXP(points);
            Console.WriteLine("Event recorded!");
        }
        else
        {
            Console.WriteLine("Invalid Choice.");
        }
    }

    public void SaveGoals() // Changed for leveling component
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            writer.WriteLine(_levelManager.GetCurrentLevel()); 
            writer.WriteLine(_levelManager.GetCurrentXP());
            foreach (var goal in _goals)
            {
                string goalType = goal.GetType().Name;
                writer.WriteLine(goalType);
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals() // Changed for leveling component
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                _score = int.Parse(reader.ReadLine());
                _levelManager = new LevelManager();
                _levelManager.AddXP(int.Parse(reader.ReadLine()) * (_levelManager.GetCurrentLevel() -1) * 1000);
                _levelManager.AddXP(int.Parse(reader.ReadLine()));
                _goals.Clear();

                while (!reader.EndOfStream)
                {
                    string goalType = reader.ReadLine();
                    string[] goalData = reader.ReadLine().Split('|');

                    Goal goal = goalType switch
                    {
                        "SimpleGoal" => new SimpleGoal(goalData[0], goalData[1], int.Parse(goalData[2])),
                        "EternalGoal" => new EternalGoal(goalData[0], goalData[1], int.Parse(goalData[2])),
                        "ChecklistGoal" => new ChecklistGoal(goalData[0], goalData[1], int.Parse(goalData[2]), int.Parse(goalData[3]), int.Parse(goalData[4])),
                        _=> throw new InvalidOperationException("Unknown goal type.")
                    };

                    goal.LoadDetails(goalData);
                    _goals.Add(goal);
                }
            }
            Console.WriteLine("Goals loaded.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }


}