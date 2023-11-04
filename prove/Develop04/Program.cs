using System;
using System.Threading;

public class Program
{
    public static void Main(string[] args)
    {
        Activity activity = new Activity();
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();
        StretchingBackActivity stretchingBackActivity = new StretchingBackActivity();
        string choice;

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Start Stretching Back Activity");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    breathingActivity.Start();
                    break;
                case "2":
                    reflectingActivity.Start();
                    break;
                case "3":
                    listingActivity.Start();
                    break;
                case "4":
                    stretchingBackActivity.Start();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        } while (choice != "5");
    }
}

