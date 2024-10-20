abstract class MindfulnessActivity
{
    protected string _activityName;
    protected string _description;
    protected int _duration; // in seconds

    public void RunActivity()
    {
        Console.Clear();
        StartActivity();
        PerformActivity();
        EndActivity();
    }

    protected virtual void StartActivity()
    {
        Console.WriteLine($"Starting {_activityName} Activity");
        Console.WriteLine(_description);
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        PauseWithSpinner(3); // Short delay before starting
    }

    protected virtual void EndActivity()
    {
        Console.WriteLine("Great job! You've completed the activity.");
        Console.WriteLine($"You completed the {_activityName} activity for {_duration} seconds.");
        PauseWithSpinner(3); // Delay before finishing
    }

    protected abstract void PerformActivity(); // To be implemented by derived classes

    protected void PauseWithSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b|");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }
}