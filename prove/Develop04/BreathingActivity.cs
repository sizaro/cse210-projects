
public class BreathingActivity : Activity
{
    public override void Start()
    {
        base.Start();
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        for (int i = _Duration; i > 0; i--)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Breathe in...");
            }
            else
            {
                Console.WriteLine("Breathe out...");
            }

            Console.Write("keep going...");
            Thread.Sleep(7000);
            Console.Write("\b  \b"); // Clear the previous text
            Console.Write(i);
        }

        End("breathing");
    }
}
