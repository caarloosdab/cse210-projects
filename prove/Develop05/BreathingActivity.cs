class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity()
    {
        _activityName = "Breathing";
        _description = "This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void PerformActivity()
    {
        for (int i = 0; i < _duration / 6; i++) // 6 seconds per breathing cycle (3 in, 3 out)
        {
            Console.WriteLine("Breathe in...");
            PauseWithCountdown(3, true);
            Console.WriteLine("Breathe out...");
            PauseWithCountdown(3, false);
        }
    }

    private void PauseWithCountdown(int seconds, bool expandingText)
    {
        for (int i = 0; i < seconds; i++)
        {
            if (expandingText)
            {
                Console.Write("Inhaling ");
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(".");
                }
            }
            else
            {
                Console.Write("Exhaling ");
                for (int j = seconds - i; j > 0; j--)
                {
                    Console.Write(".");
                }
            }
            Thread.Sleep(1000);
            Console.Write("\r");
        }
    }
}