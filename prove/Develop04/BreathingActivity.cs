using System;
class BreathingActivity : Activity {
    public BreathingActivity(string activityName, string activityDescription) : base (activityName, activityDescription) {
        this.activityName = activityName;
        this.activityDescription = activityDescription;
    }

    public override void RunActivity() {
        //
        int totalCountdown = ActivityIntro();
        int countdownNumbers = totalCountdown / 1000;

        int repeats = countdownNumbers / 10;


        for (int rep = 1; rep <= repeats; rep++) {

            for (int i = 5; i > 0; i--) {
                Console.Write($"\rBreathe in...{i}");
                Thread.Sleep(1000);
            }
            Console.Write($"\rBreathe in...0");
            Console.WriteLine();

            for (int i = 5; i > 0; i--) {
                Console.Write($"\rBreath out...{i}");
                Thread.Sleep(1000);
            }
            Console.Write($"\rBreathe in...0");
            Console.WriteLine("\n");
        }

        ActivityOutro();
    }
}