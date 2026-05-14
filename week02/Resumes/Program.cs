using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();

        job1._jobTitle = "Financial Coordinator";
        job1._company = "Wright Orthodontics";
        job1._startYear = 2015;
        job1._endYear = 2022;

        Job job2 = new Job();

        job2._jobTitle = "Data Analyst/Project Coordinator";
        job2._company = "Oneil";
        job2._startYear = 2022;   
        job2._endYear = 2026;

        Resume myResume = new Resume();
        myResume._name= "Alana Fox";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();                                          
    }
}