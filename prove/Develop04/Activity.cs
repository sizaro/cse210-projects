
public class Activity
{
    protected int _Duration;

    public virtual void Start()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Thread.Sleep(2000);
    }

    public void End(string activityName)
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed another {_Duration} seconds of the {activityName} activity.");
        Thread.Sleep(2000);
    }
}
