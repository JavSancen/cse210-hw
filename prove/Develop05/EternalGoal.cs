public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        // Eternal goals don't really complete, but we can increment points or something similar
    }

    public override bool IsComplete()
    {
        return false;  // Eternal goals are never "complete"
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{_shortName},{_description},{_points}";
    }
}

