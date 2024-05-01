using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Store Manager";
        job1._company = "O'Reilly Auto Parts";
        job1._startYear = 2009;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Senior Parts Specialist";
        job2._company = "Stephen Wade Wholesale Parts";
        job2._startYear = 2021;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Timothy Scott";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}