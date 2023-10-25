//hello instructor, have had a hard time accomplishing this task, and if possible you may write
//for me ways in which i could better write this code, because it wasnot easy. so i warmly welcome
//your suggestions and corrections.
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();
        Random random = new Random();
        Reference reference = new Reference("");

        while (true)
        {
            Scripture scripture = scriptureLibrary.GetRandomScripture(random);
            reference.SetText(scripture.Reference);

            while (scripture.HasVisibleWords())
            {
                Console.Clear();
                Console.WriteLine($"{reference.GetText()}: {scripture.GetVisibleText()}");
                Console.WriteLine("Press enter to continue or type 'quit' to exit.");
                string userInput = Console.ReadLine();

                if (userInput != null && userInput.ToLower() == "quit")
                {
                    Environment.Exit(0);
                }

                if (string.IsNullOrEmpty(userInput))
                {
                    int wordIndex = scripture.HideRandomWord(random);
                    if (wordIndex == -1)
                    {
                        Console.Clear();
                        Console.WriteLine($"{reference.GetText()}: {scripture.GetVisibleText()}");
                        Console.WriteLine("All words are hidden. Do you want to continue? (yes/no)");
                        string continueInput = Console.ReadLine();

                        if (string.IsNullOrEmpty(continueInput) && continueInput.ToLower() != "yes")
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }
    }




}
