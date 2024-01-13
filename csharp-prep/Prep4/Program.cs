using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter a number. Type 0 to quit: ");

            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
        
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        //Sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        
        //Average
        float average = (float)sum / numbers.Count;

        //Max
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max is: {max}");

    }
}