using System;
class SimpleGoal : Goal {
    public SimpleGoal(string name, string description, int value)
        : base(name, description, value) {
    }

    public SimpleGoal(string name, string description, int value, bool completed)
        : base(name, description, value) {
            this.completed = completed;
    }

    public override int CompleteGoal()
    {
        completed = true;
        Console.WriteLine($"Your score has increased by {value} points!");
        return value;
    }

    public override string ToString() {
        return $"SimpleGoal,{name},{description},{value},{completed}";
    }
}