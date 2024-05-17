using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");
        while(true)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Exit");  
            Console.Write("Select a choice from the menu: ");
            int menuChoice = int.Parse(Console.ReadLine());

            Activity activity = null;

            switch (menuChoice)
            {
                case 1:
                    activity = new BreathingActivity("Breathing Activity", "A breathing exercise to help you relax", 1);
                    break;

                case 2:
                    activity = new ReflectingActivity("Reflecting", "Reflect on positive things that happened today", 1);
                    break;

                case 3:
                    activity = new ListingActivity("Listing", "List things you are grateful for", 1);
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid choice.");
                    break;
            } 

            activity?.Run(); 
        }
    }
}