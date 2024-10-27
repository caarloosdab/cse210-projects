using System;

public class Achievement
{
    private string _name;
    private string _description;
    private bool _isUnlocked;

    public Achievement(string name, string description)
    {
        _name = name;
        _description = description;
        _isUnlocked = false;
    }

    public bool IsUnlocked()
    {
        return _isUnlocked;
    }

    public void Unlock()
    {
        _isUnlocked = true;
        Console.WriteLine($"Achievement Unlocked: {_name} - {_description}");
    }

    public string GetAchievementInfo()
    {
        return _isUnlocked ? $"[Unlocked] {_name}: {_description}" : $"[Locked] {_name}: {_description}";
    }
}