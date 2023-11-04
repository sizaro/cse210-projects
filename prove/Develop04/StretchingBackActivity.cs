
public class StretchingBackActivity : Activity
{
    public override void Start()
    {
        base.Start();
        Console.WriteLine("Welcome to the Stretching Back Activity.");
        Console.WriteLine("This activity will help you relieve tension by stretching your back. Stand up, stretch your arms above your head, and arch your back gently.");

        for (int i = _Duration; i > 0; i--)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Stretch up...");
            }
            else
            {
                Console.WriteLine("Arch your back...");
            }
            Console.Write("keep going...");
            Thread.Sleep(7000);
            Console.Write("\b  \b");
            Console.Write(i);
        }

        End("stretching back");
    }
}