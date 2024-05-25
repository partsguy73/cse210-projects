using System;

class Program
{
    static GoalManager goalManager = new GoalManager();
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            // Display current points  **** adding leveling component
            Console.WriteLine($"You have {goalManager.GetScore()} points");
            Console.WriteLine($"You are at level {goalManager.GetCurrentLevel()} with {goalManager.GetCurrentXP()} XP to next level: {goalManager.GetXPToNextLevel()}");

            // Display menu options
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            int menuChoice = int.Parse(Console.ReadLine());

            // Handle menu options
            switch (menuChoice)
            {
                case 1:
                    goalManager.CreateGoal();
                    break;
                case 2:
                    goalManager.ListGoalDetails();
                    break;
                case 3:
                    goalManager.SaveGoals();
                    break;
                case 4:
                    goalManager.LoadGoals();
                    break;
                case 5:
                    goalManager.RecordEvent();
                    break;
                case 6:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}