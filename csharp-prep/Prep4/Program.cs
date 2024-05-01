using System;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        int numberCount = 0;
        int sum = 0;
        int max = 0;
        int min = 1000000;
        float avg = 0;

        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Please enter an integer (use 0 to stop): ");
            number = int.Parse(Console.ReadLine());
            if (number != 0) 
            {
                numbers.Add(number);
                sum += number;
                numberCount ++;
            }

            if (number > max)
            {
                max = number;
            }

            if (number < min && number > 0)
            {
                min = number;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        avg = (float)sum/numberCount;
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest number greater than 0 is: {min}");
    }
}