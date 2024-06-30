using System;

public abstract class Goal {
    protected string name;
    protected string description;
    protected int value;
    protected bool completed;

    public Goal(string name, string description, int value) {
        this.name = name;
        this.description = description;
        this.value = value;
        this.completed = false;
    }

    public string GetName() {
        return name;
    }

    public virtual void DisplayGoal() {
            string checkedOff = completed ? "X" : " ";
            Console.WriteLine($"[{checkedOff}] {name} ({description})");
    }

    public override abstract string ToString();

    public static Goal LoadGoal(string goalString) {
        string[] parts = goalString.Split(',');
        string type = parts[0];
        string name = parts[1];
        string description = parts[2];
        int value = int.Parse(parts[3]);
        bool completed = bool.Parse(parts[4]);

        switch (type)
        {
            case "SimpleGoal":
                return new SimpleGoal(name, description, value) { completed = completed };
            case "ChecklistGoal":
                int timesNeeded = int.Parse(parts[5]);
                int timesCompleted = int.Parse(parts[6]);
                return new ChecklistGoal(name, description, value, timesNeeded, timesCompleted) { completed = completed};
            case "EternalGoal":
                return new EternalGoal(name, description, value) { completed = completed};
            default:
                throw new Exception("Unknown goal type");
        }
    }

    public virtual int CompleteGoal() {
        completed = true;
        Console.WriteLine("Good Job! You have completed this goal.");
        return value;
    }
}