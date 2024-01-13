using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        
        //Console.WriteLine("Hello Prep3 World!");

        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        //Part 3
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
    
        int guess = -1;
        //Part 2
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Correct. You Guessed. Great Job!");
            }


        }
    }
}