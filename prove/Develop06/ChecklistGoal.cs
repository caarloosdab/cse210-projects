public class ChecklistGoal : Goal
{
    private int _target;
    private int _amountCompleted;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _target = target;
        _amountCompleted = 0;
        _bonus = bonus;
    }

    // Property to access the bonus
    public int Bonus
    {
        get { return _bonus; }
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {GetDetailsString()} - Completed {_amountCompleted}/{_target} times";
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $", Bonus: {_bonus}";
    }
}