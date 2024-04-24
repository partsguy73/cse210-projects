using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine();  

        // Ask the user for their grade percentage
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        float number = float.Parse(percentage);
        Console.WriteLine();

        Console.WriteLine($"Your grade percentage is {number}%");
        Console.WriteLine();

        // Convert Percentage to a letter grade

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Add signs + or -
        string sign = "";

        if (number % 10 >= 7)
        {
            sign = "+";
        }
        else if (number % 10 <= 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");
      
        // Pass/Fail 
        if (number >= 70)
        {
            Console.WriteLine("Congratulation!! You passed!!");
            Console.WriteLine();
        }
        else 
        {
            Console.WriteLine("If at first you don't succeed, pack your bags.");
            Console.WriteLine();
        }
    }
}