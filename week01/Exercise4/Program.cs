using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        int enterNumber = -1;
    
        while (enterNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            enterNumber = int.Parse(Console.ReadLine());

            if (enterNumber != 0)
            {
                numbers.Add(enterNumber);}
            
        } 

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;

        }   
        Console.WriteLine($"The sum is {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        int max = numbers[0];
        foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The maximum number is: {max}");   
    }
}
