using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();

        int numberGrade = int.Parse(grade);

        string letterGrade = "";
        string gradeModifier = "";

        // determine the letter grade
        if (numberGrade >= 90)
        {
            letterGrade = "A";
        }
        else if (numberGrade >= 80)
        {
            letterGrade = "B";
        }
        else if (numberGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (numberGrade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        // determine the grade modifier (ie +,-)
        // preserve cases of A+, F+, and F-
        if (numberGrade >= 97 || numberGrade < 60)
        {
            gradeModifier = "";
        }
        else if (numberGrade % 10 >= 7)
        {
            gradeModifier = "+";
        }
        else if (numberGrade % 10 < 3)
        {
            gradeModifier = "-";
        }
        else
        {
            gradeModifier = "";
        }
        

        Console.WriteLine($"Your current grade is: {letterGrade}{gradeModifier}");

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