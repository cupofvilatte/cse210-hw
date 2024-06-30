using System;
class ChecklistGoal : Goal {
    private int timesCompleted;
    private int totalTimesNeeded;

    public ChecklistGoal(string name, string description, int value, int totalTimesNeeded) : base(name, description, value) {
        this.totalTimesNeeded = totalTimesNeeded;
        this.timesCompleted = 0;
    }

    public ChecklistGoal(string name, string description, int value, int totalTimesNeeded, int timesCompleted) : base(name, description, value) {
        this.totalTimesNeeded = totalTimesNeeded;
        this.timesCompleted = timesCompleted;
    }

    public override void DisplayGoal() {
            string checkedOff = completed ? "X" : " ";
            Console.WriteLine($"[{checkedOff}] {name} ({description}) - {timesCompleted}/{totalTimesNeeded}");
    }

    public override int CompleteGoal()
    {
        timesCompleted++;
        Console.WriteLine($"{timesCompleted}/{totalTimesNeeded} completions!");

        if (timesCompleted == totalTimesNeeded) {
            completed = true;
            return value;
        } else {
            return value / totalTimesNeeded;
        }
    }

    public override string ToString() {
        return $"ChecklistGoal,{name},{description},{value},{completed},{totalTimesNeeded},{timesCompleted}";
    }

}