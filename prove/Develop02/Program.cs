using System;
using System.Text.Json.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        List<string> menu = ["Write", "Display", "Load", "Save", "Quit"];

        Console.WriteLine("Welcome to the Journal App! You will be able to respond to prompts, save, and view your entries.");

        while (true) {
        for (int i = 0; i < menu.Count; i++)
        {
            Console.WriteLine($"{i+1}. {menu[i]}");
        }
        
        int choice = int.Parse(Console.ReadLine());

        // Console.WriteLine($"{menu[choice - 1]}");

        switch (choice) {
            case 1:
                journal.NewEntry();
                break;
            case 2:
                journal.DisplayJournal();
                break;
            case 3:
                journal.LoadJournal();
                break;
            case 4:
                journal.SaveJournal();
                break;
            case 5:
                Console.WriteLine("x");
                break;
        }
        }
    }
}