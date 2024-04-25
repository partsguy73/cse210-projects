using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //Create a new list for numbers
        List<double> numbers = new List<double>();

        //Add a loop to ask user to enter numbers or enter 0 to quit
        while (true)
        {
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double num))
            {
                if (num == 0)
                    break;

                numbers.Add(num);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        //Adding code to test that numbers were being added to the list
        //Console.WriteLine("List of numbers:");
        //foreach (var num in numbers)
        //{
            //Console.WriteLine(num + ", ");
        //}
        //Console.WriteLine();

        double sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }
        double average = sum / numbers.Count;
        double maximum = double.MinValue;
        double minimum = double.MaxValue;

        foreach (var num in numbers)
        {
            maximum = Math.Max(maximum, num);
            minimum = Math.Min(minimum, num);
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maximum}");
        //Console.WriteLine($"Minimum: {minimum}");
    }
}