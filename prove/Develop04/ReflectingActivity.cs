
public class ReflectingActivity : Activity
{
    public override void Start()
    {
        base.Start();
        Console.WriteLine("Welcome to the Reflecting Activity.");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        Random random = new Random();

        for (int i = _Duration; i > 0; i--)
        {
            int index = random.Next(prompts.Length);
            Console.WriteLine(prompts[index]);

            Console.Write("keep going...");
            Thread.Sleep(7000);
            Console.Write("\b  \b");
            Console.Write(i);
        }

        End("reflecting");
    }
}
