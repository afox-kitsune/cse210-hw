using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine("This is in C#.");

        Console.Write("What is your first name? ");
        string first = Console.ReadLine();
        
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your Name is {last}, {first} {last}.");
    }
}
