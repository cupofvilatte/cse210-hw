using System;
using System.Diagnostics;
using System.Text.Json.Serialization;
class ListingActivity : Activity {
    private List<string> prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public ListingActivity(string activityName, string activityDescription) : base (activityName, activityDescription) {
        this.activityName = activityName;
        this.activityDescription = activityDescription;
    }

    public override void RunActivity() {
        int duration = ActivityIntro();
        int responseCount = 0;

        Random random = new Random();
        int randomIndex = random.Next(0, 4);
        Console.WriteLine(prompts[randomIndex]);

        for (int i = 5; i > 0; i--) {
                Console.Write($"\rYour program will begin in...{i}");
                Thread.Sleep(1000);
            }
        Console.WriteLine();
        Console.WriteLine("Your activity has started! Press enter after each response.");

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds < duration) {
            string response = Console.ReadLine();
            responseCount += 1;
        }
        stopwatch.Stop();
        Console.WriteLine($"You entered {responseCount} responses.");


        ActivityOutro();
    }
}