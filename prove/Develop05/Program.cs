using System;

class Program
{
    static void Main(string[] args)

    {

        int totalScore = 0;
        List<Goal> GoalsList = new List<Goal>();

        static Goal LoadGoal(string goalString) {
            string[] parts = goalString.Split(',');
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int value = int.Parse(parts[3]);
            bool completed = bool.Parse(parts[4]);

            switch (type)
            {
                case "SimpleGoal":
                    return new SimpleGoal(name, description, value, completed);
                case "ChecklistGoal":
                    int timesNeeded = int.Parse(parts[5]);
                    int timesCompleted = int.Parse(parts[6]);
                    return new ChecklistGoal(name, description, value, timesNeeded, timesCompleted);
                case "EternalGoal":
                    return new EternalGoal(name, description, value);
                default:
                    throw new Exception("Unknown goal type");
        }
    }


        bool quit = false;
        while (!quit) {
            Console.WriteLine("Menu:\n[1] Create New Goal\n[2] List Goals\n[3] Save Goals\n[4] Load Goals\n[5] Record Goal Completion\n[6] Quit");
            Console.WriteLine();
            Console.Write("Where would you go... ");
            string choice = Console.ReadLine();

            switch (choice) {
                case "1":
                    Console.WriteLine("What kind of goal is this?\n[A] Simple Goal\n[B] Checklist Goal\n[C] Eternal Goal");
                    string secondaryChoice = Console.ReadLine();
                    if (secondaryChoice == "A") {
                        // simple goal
                        Console.Write("What is the name of your goal? ");
                        string name = Console.ReadLine();
                        Console.Write("What is a description of your goal? ");
                        string description = Console.ReadLine();
                        Console.Write("How many points is this goal worth? ");
                        int value = int.Parse(Console.ReadLine());
                        SimpleGoal goal = new SimpleGoal(name, description, value);
                        GoalsList.Add(goal);
                    } else if (secondaryChoice == "B") {
                        // checklist goal
                        Console.Write("What is the name of your goal? ");
                        string name = Console.ReadLine();
                        Console.Write("What is a description of your goal? ");
                        string description = Console.ReadLine();
                        Console.Write("How many points is this goal worth? ");
                        int value = int.Parse(Console.ReadLine());
                        Console.Write("How many times do you want to accomplish this? ");
                        int timesNeeded = int.Parse(Console.ReadLine());
                        ChecklistGoal goal = new ChecklistGoal(name, description, value, timesNeeded);
                        GoalsList.Add(goal);
                    } else if (secondaryChoice == "C") {
                        // eternal goal
                        Console.Write("What is the name of your goal? ");
                        string name = Console.ReadLine();
                        Console.Write("What is a description of your goal? ");
                        string description = Console.ReadLine();
                        Console.Write("How many points is this goal worth each time you complete it? ");
                        int value = int.Parse(Console.ReadLine());
                        EternalGoal goal = new EternalGoal(name, description, value);
                        GoalsList.Add(goal);
                    }
                    break;
                case "2":
                    // calculate and display total score
                    Console.WriteLine($"Your score is {totalScore}!");
                    // display goals
                    foreach (Goal goal in GoalsList) {
                        goal.DisplayGoal();
                    }
                    break;
                case "3":
                    // save goals
                    Console.Write("Enter a filename to save to: ");
                    string filename = Console.ReadLine();

                    using (StreamWriter writer = new StreamWriter(filename))
                    {
                        foreach (var goal in GoalsList)
                        {
                            writer.WriteLine(goal.ToString());
                        }
                    }
                    break;
                case "4":
                    // load goals
                    LoadGoal();
                    
                    break;
                case "5":
                    // which goal do you want to complete
                    Console.WriteLine("Which goal do you want to complete? ");

                    for (int i = 0; i < GoalsList.Count; i++) {
                        Console.WriteLine($"{i + 1}. {GoalsList[i].GetName()}");
                    }

                    int selectedNum = int.Parse(Console.ReadLine());
                    Goal selectedGoal = GoalsList[selectedNum - 1];

                    totalScore += selectedGoal.CompleteGoal();
                    break;
                case "6":
                    // do you want to quit without saving
                    // if yes, quit

                    // if no, ask to save
                    // if yes save, save and quit (print messages)
                    // if no, don't quit
                    quit = true;
                    break;
            }
        }

    }
}