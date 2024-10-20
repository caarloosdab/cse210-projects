class ReflectionActivity : MindfulnessActivity
{
    private static string[] reflectionPrompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static string[] reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?"
    };

    public ReflectionActivity()
    {
        _activityName = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        string prompt = reflectionPrompts[random.Next(reflectionPrompts.Length)];
        Console.WriteLine(prompt);
        PauseWithSpinner(3); // Give time to think about the prompt

        int totalTime = 0;
        while (totalTime < _duration)
        {
            string question = reflectionQuestions[random.Next(reflectionQuestions.Length)];
            Console.WriteLine(question);
            PauseWithSpinner(5); // Give time to reflect on each question
            totalTime += 5;
        }
    }
}