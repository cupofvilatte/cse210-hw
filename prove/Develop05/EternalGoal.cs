using System;

class EternalGoal : Goal {
    // private int streak;
    // private bool completedYesterday;

    public EternalGoal(string name, string description, int value) : base(name, description, value) {
    }

    public override string ToString() {
        return $"EternalGoal,{name},{description},{value},{completed}";
    }

    public override int CompleteGoal()
    {

        return value;

        //if (completedYesterday) {
        //streak++;
        //} else {
        //streak = 0;
        //}
        // completedYesterday = true;
    }

    // public void CheckToResetStreak() {}
}