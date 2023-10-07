using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        Prompts promptGenerator = new Prompts();

        Console.WriteLine("Welcome to the journal program!");

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetPrompt();
                    Console.WriteLine(prompt);
                    string content = Console.ReadLine();
                    journal.AddEntry(DateTime.Now, prompt, content);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    if (File.Exists("journal.txt"))
                    {
                        journal.ReadFromFile("journal.txt");
                        Console.WriteLine("File loaded successfully.");
                        journal.DisplayEntries();
                    }
                    else
                    {
                        Console.WriteLine("The journal file does not exist.");
                    }
                    break;
                case "4":
                    journal.SaveToFile("journal.txt");
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
