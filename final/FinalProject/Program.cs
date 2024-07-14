using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");

        LibraryManager manager = new LibraryManager();
        
        // Adding different types of library items to the inventory for demonstration
        manager.AddItem(new HardCopy("Title1", 1, "Author1", 300, "2021", "Fiction", 9.02));
        manager.AddItem(new Movie("Movie1", 2, 2019, "Producer1", "PG-13"));
        manager.AddItem(new Magazine("Magazine1", 3, "Sprint 2021"));

        // Show the menu
        manager.Menu();
    }
}