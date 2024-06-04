using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Julie Teeger", "Abstraction");

        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        MathAssignment mathAssignment1 = new MathAssignment("Marcus Aurelius", "Geometry", "8.1", "12-44");

        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writingAssignment1 = new WritingAssignment("Chandler Bing", "Business Analytics", "The Importance of Persuasion in Numbers");

        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}