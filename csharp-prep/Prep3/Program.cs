using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string magic = Console.ReadLine();

        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 101);

        int guessNumber = 0;
        int guessCount = 0;

        while (guessNumber != magicNumber)
        {
            guessCount ++;

            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You got it right!");
                Console.WriteLine($"It took you {guessCount} guesses.");
            }
        }
    }
}