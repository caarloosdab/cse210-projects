using System;

public class GoalManager
{
    private List<Goal> _goals;
    private List<Achievement> _achievements;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        InitializeAchievements();
    }

    // Add a method to create a new goal based on user input
    public void CreateGoal()
    {
        Console.WriteLine("\nChoose the type of goal you want to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string goalType = Console.ReadLine();
        
        // Get the common attributes of any goal
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.Write("Enter the description of the goal: ");
        string description = Console.ReadLine();

        Console.Write("Enter the points to be awarded for this goal: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        // Based on user input, create the specific goal type
        switch (goalType)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("Enter the target number of completions: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Enter the bonus points for completing the checklist: ");
                int bonus = int.Parse(Console.ReadLine());

                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                return;
        }

        // Add the new goal to the list of goals
        _goals.Add(newGoal);
        Console.WriteLine("Goal added successfully!\n");
    }


    // Initialize the achievement list
    private void InitializeAchievements()
    {
        _achievements = new List<Achievement>
        {
            new Achievement("Goal Master", "Complete 5 goals"),
            new Achievement("Score Champ", "Earn 5000 points"),
            new Achievement("Checklist Conqueror", "Complete a checklist goal"),
        };
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int index)
    {
        Goal goal = _goals[index];
        goal.RecordEvent();

        if (goal is ChecklistGoal checklistGoal)
        {
            if (checklistGoal.IsComplete())
            {
                _score += checklistGoal.Bonus; // Use the Bonus property
            }
            _score += checklistGoal.Points; // Use the Points property from Goal class
        }
        else if (goal is SimpleGoal simpleGoal && simpleGoal.IsComplete())
        {
            _score += simpleGoal.Points; // Use the Points property
        }
        else if (goal is EternalGoal eternalGoal)
        {
            _score += eternalGoal.Points; // Use the Points property
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Total Score: {_score}");
        DisplayAchievements();
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
    }

    // Check if any achievements are unlocked based on current progress
    private void CheckAchievements(string specificAchievement = "")
    {
        if (specificAchievement == "Checklist Conqueror")
        {
            foreach (var achievement in _achievements)
            {
                if (achievement.GetAchievementInfo().Contains("Checklist Conqueror") && !achievement.IsUnlocked())
                {
                    achievement.Unlock();
                }
            }
        }

        if (_goals.Count >= 5)
        {
            foreach (var achievement in _achievements)
            {
                if (achievement.GetAchievementInfo().Contains("Goal Master") && !achievement.IsUnlocked())
                {
                    achievement.Unlock();
                }
            }
        }

        if (_score >= 5000)
        {
            foreach (var achievement in _achievements)
            {
                if (achievement.GetAchievementInfo().Contains("Score Champ") && !achievement.IsUnlocked())
                {
                    achievement.Unlock();
                }
            }
        }
    }

    private void DisplayAchievements()
    {
        Console.WriteLine("\nAchievements:");
        foreach (var achievement in _achievements)
        {
            Console.WriteLine(achievement.GetAchievementInfo());
        }
    }

    public void SaveGoals(string filename)
    {
        using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                file.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        // Placeholder: reading goals from a file would go here
    }
}
