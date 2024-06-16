using System;
using System.Diagnostics;
public abstract class Activity {
    protected string activityName;
    protected string activityDescription;

    public Activity() {
        this.activityName = "Default Activity";
        this.activityDescription = "Default Description";
    }

    public Activity(string activityName, string activityDescription) {
        this.activityName = activityName;
        this.activityDescription = activityDescription;
    }

    public abstract void RunActivity();

    protected int ActivityIntro() {
        Console.WriteLine($"Welcome to the {activityName}!");
        Console.WriteLine(activityDescription);
        Console.WriteLine("Please enter a time (in seconds) of how long you want to do this activity: ");
        int seconds = int.Parse(Console.ReadLine());
        int time = seconds * 1000;
        Console.WriteLine("Prepare to Begin:");
        Spinner();

        return time;
    }

    protected void ActivityOutro() {
        Console.WriteLine("Great job!");
        Spinner();
        Console.WriteLine($"You have completed the {activityName}");
        Spinner();
    }

    protected void Spinner(int timer = 3) {
        string[] spinnerFrames = {"/", "-", "\\", "|" };
        int runFor = timer * 1000;

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds < runFor) {
            foreach (string spinnerFrame in spinnerFrames) {
                Console.Write(spinnerFrame);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
        stopwatch.Stop();
    }
}