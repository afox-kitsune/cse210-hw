using System;
using System.Runtime.CompilerServices;
// exceeding requirement added random encouragement feedback after journal entry
class Program
{
    static readonly string [] Encouragement = new string []
    {
        "Write down... a few lines every day. ... You will find that as you write, you will remember what God had done for you - Henry B. Eyring",
        "And now, it has hitherto been widsom in God that these things should be preserved; they have enlarged the memory of this people, yea and convinced many of the error of their ways, and brought them to the knowledge of their God unto the salvation of their souls. - Alma 37:8",
        "Documenting little details of your everyday life becomes a celebration of who you are. - Carolyn V. Hamilton",
        "Journaling is like whispering to one's self and listening at the same time. - Mina Murray",
        "You are doing an excellent job keep it up!",
        "Be gentle with yourself. You're doing your best!",
        "You are on a writing roll keep rocking it!"


    };
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        string choice = "";

        Console.WriteLine("Hello World! This is the Journal Project. Welcome!");

        while (choice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");    
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write(">");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry(date, prompt, response);
                myJournal.AddEntry(newEntry);

                Console.WriteLine("\n-----------------");
                Random random = new Random();
                int randomIndex = random.Next(Encouragement.Length);
                Console.WriteLine(Encouragement[randomIndex]);
                Console.WriteLine("----------------\n");
            }
            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                myJournal.LoadFromFile(fileName);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                myJournal.SaveToFile(fileName);
            }                
        }


    }
}