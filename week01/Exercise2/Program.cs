using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade percentage? ");
        string feedback = Console.ReadLine();
        int percent = int.Parse(feedback);
        
        string letter = "";

        if (percent >=90)
        {
            letter = "A";
        }
        else if (percent >=80)
        {
            letter = "B";
        }
        else if (percent >=70)
        {
            letter = "C";
        }
        else if (percent >=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("You have passed the course! You really made the grade!");
        }
        else
        {
            Console.WriteLine("As Gandulf says You shall not pass Shire-ly you'll do better next time!");
        }

    }

}


