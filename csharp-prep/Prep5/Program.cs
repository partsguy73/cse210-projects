using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        // Call each function and save the return values
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }

        //Displays the welcome message
        static void DisplayWelcome()
        {
        Console.WriteLine("Hello Prep5 World!");
        Console.WriteLine("");

        Console.WriteLine("Welcome to the Program!");
        Console.WriteLine();
        }

        // Asks for and returns the user's name
        static string PromptUserName()
        {
            Console.Write("Enter your name: ");
            return Console.ReadLine();
        }

        // Asks for and returns the user's favorite number
        static int PromptUserNumber()
        {
            Console.Write("Enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        // Accepts an integer as a parameter and returns that number squared
        static int SquareNumber (int num)
        {
            return num * num;
        }

        // Accepts the user's name and the squared number and displays them
        static void DisplayResult (string name, int squaredNum)
        {
            Console.WriteLine($"Hello, {name}! Your favorite number squared is: {squaredNum}");
            Console.WriteLine();
        } 
}