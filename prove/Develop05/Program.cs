using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop05 World!");

        //First line prints a total of current points
        Console.WriteLine("You have 0 points");

        //First set of menu options
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Quit");
        Console.Write("Select a choice from the menu: ");
        int menuChoice = int.Parse(Console.ReadLine());

        if (menuChoice == 4)
            {
                Console.WriteLine("");
                Environment.Exit(0);
            }

    }

}