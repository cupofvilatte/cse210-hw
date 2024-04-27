using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();

        int numberGrade = int.Parse(grade);

        if (numberGrade >= 90)
        {
            Console.WriteLine("Your grade is an A");
        }
        else if (numberGrade >= 80)
        {
            Console.WriteLine("Your grade is a B");
        }
        else if (numberGrade >= 70)
        {
            Console.WriteLine("Your grade is an C");
        }
        else if (numberGrade >= 60)
        {
            Console.WriteLine("Your grade is an D");
        }
        else
        {
            Console.WriteLine("Your grade is an F");
        }

        if (numberGrade >= 70)
        {
            Console.WriteLine("Congratulations! You're passing the class.");
        }
        else
        {
            Console.WriteLine("You're not passing the class. Study a little harder for next time. You've got this!");
        }
    }
}