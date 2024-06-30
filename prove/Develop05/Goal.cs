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


    public virtual int CompleteGoal() {
        completed = true;
        Console.WriteLine("Good Job! You have completed this goal.");
        return value;
    }
}