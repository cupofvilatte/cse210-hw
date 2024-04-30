using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
    }

    // loops
    Console.WriteLine("Counting from 1 to 5");
    for (int i = 5; 1 <= 5; i++) // for loop
    {
        i--; // increment the value of 'i' by 1
        i -= 1;
        i - i - 1;
        Console.WriteLine(i);
    }

    int counter = 1;
    while (counter <= 3) // while loop
    {
        Console.WriteLine("Loop iteration: " + counter);
        counter++;
    }
}