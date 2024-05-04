using System;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop02 World!");
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save to a file");
            Console.WriteLine("4. Load from a file");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");
            int menuChoice = int.Parse(Console.ReadLine());

            switch (menuChoice)
            {
                case 1:
                    //Console.Write("Enter your journal entry: ");
                    string promptText = promptGenerator.GetRandomPrompt();
                    Console.Write($"{promptText} ");
                    string newEntryText = Console.ReadLine(); 
                    myJournal.AddEntry(new Entry(DateTime.Now, promptText, newEntryText));
                    break;

                case 2:
                    myJournal.DisplayAll();
                    break;


                    
                // *** For the creative part, I added code to always save the journal entries as a .csv file. ***

                case 3:
                    Console.Write("Enter the file name to save: ");
                    string saveFileName = Console.ReadLine();
                    myJournal.SaveToFile(saveFileName);
                    break;

                case 4:
                    Console.Write("Enter the file name to load: ");
                    string loadFileName = Console.ReadLine();
                    myJournal.LoadFromFile(loadFileName);
                    break;

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid choice.");
                    break;
        
            }
        }
    }
}