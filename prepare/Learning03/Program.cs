using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning03 World!");
        //Fraction with default values
        Fraction f1 = new Fraction();
        //print fraction
        Console.WriteLine(f1.GetFractionString());
        //print do the math
        Console.WriteLine(f1.GetDecimalValue());

        //fraction with 5
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        //fraction with 3,4
        Fraction f3 = new Fraction(3,4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        //fraction with 1,3
        Fraction f4 = new Fraction(1,3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}