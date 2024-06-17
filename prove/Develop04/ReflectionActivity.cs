using System;
class ReflectionActivity : Activity {
    private List<string> prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };

    private List<string> subprompts = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public ReflectionActivity(string activityName, string activityDescription) : base (activityName, activityDescription) {
        this.activityName = activityName;
        this.activityDescription = activityDescription;
    }

    public override void RunActivity() {
        int duration = ActivityIntro();

        int primaryDuration = duration / 2000;
        int secondaryDuration = duration / 4000;

        Random random = new Random();

        int firstRandomIndex = random.Next(0, 4);

        Console.WriteLine(prompts[firstRandomIndex]);
        Spinner(primaryDuration);
        
        int secondRandomIndex = random.Next(0, 9);
        Console.WriteLine(subprompts[secondRandomIndex]);
        Spinner(secondaryDuration);

        int thirdRandomIndex;
        do {
            thirdRandomIndex = random.Next(0, 9);
        } while (thirdRandomIndex == secondRandomIndex);

        Console.WriteLine(subprompts[thirdRandomIndex]);
        Spinner(secondaryDuration);

        ActivityOutro();
    }
}