
public class ListingActivity : Activity
{
    public override void Start()
    {
        base.Start();
        Console.WriteLine("Welcome to the Listing Activity.");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random random = new Random();

        int itemsListed = 0;

        for (int i = _Duration; i > 0; i--)
        {
            int index = random.Next(prompts.Length);
            Console.WriteLine(prompts[index]);

            Console.Write("keep going...");
            Thread.Sleep(7000);
            Console.Write("\b  \b");
            Console.Write(i);
        }

        Console.WriteLine($"You listed {itemsListed} items.");

        End("listing");
    }
}
