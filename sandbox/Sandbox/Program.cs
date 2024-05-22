using System;

class Program
{
    static void Main(string[] args)
    {
        Account account = new Account();

        Console.WriteLine($"You have ${account.GetAccountBalance()}");

        account.Withdraw(); // use 5 for test

        Console.WriteLine($"You have ${account.GetAccountBalance()}");
    }

}