using System;
using System.Formats.Asn1;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        string answer = Console.ReadLine();
        int response = int.Parse(answer);
        Console.WriteLine("What is the guess? ");
        string answer2 = Console.ReadLine();
        int response2 = int.Parse(answer2);

        if (response < response2)
        {
            Console.WriteLine("higher");
        }
        else if (response2 > response)
        {
            Console.WriteLine("lower");
        }
        else if (response == response2)
        {
            Console.WriteLine("you guessed it");
        }



         
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        // For Parts 1 and 2, where the user specified the number...
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        
        // For Part 3, where we use a random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        // We could also use a do-while loop here...
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}