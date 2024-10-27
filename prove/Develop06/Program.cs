//Achievements: Introduce badges for certain accomplishments, like completing multiple goals or checklist goals in succession.

using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();

        // Create some example goals (optional, but for testing)
        manager.AddGoal(new SimpleGoal("Run Marathon", "Run a marathon to win points", 1000));
        manager.AddGoal(new EternalGoal("Read Scriptures", "Read scriptures every day", 100));
        manager.AddGoal(new ChecklistGoal("Temple Visits", "Visit the temple 10 times", 50, 10, 500));

        // Main loop for user interaction
        while (true)
        {
            Console.WriteLine("\n1. List Goals");
            Console.WriteLine("2. Record Goal Event");
            Console.WriteLine("3. Display Player Info (Score & Achievements)");
            Console.WriteLine("4. Add a New Goal");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.ListGoalNames();
                    break;
                case "2":
                    Console.Write("Enter the goal number to record: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(index);
                    break;
                case "3":
                    manager.DisplayPlayerInfo();
                    break;
                case "4":
                    manager.CreateGoal();  // Allow user to add a new goal
                    break;
                case "5":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    manager.SaveGoals(saveFile);
                    break;
                case "6":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    manager.LoadGoals(loadFile);
                    break;
                case "7":
                    return;
            }
        }
    }
}
