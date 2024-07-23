using System;

class Program
{
    static void Main(string[] args)
    {

        LibraryManager manager = new LibraryManager();
        
        // Adding different types of library items to the inventory for demonstration
        manager.AddItem(new HardCopy("Kindest Regards", 1, "Ted Kooser", 239, "2018", "Poetry", 9.02, true));
        manager.AddItem(new Movie("Song of the Sea", 2, 2014, "Tomm Moore", "PG"));
        manager.AddItem(new Magazine("American Girl", 3, "Sprint 2021"));
        manager.AddItem(new EBook("Outliers", 4, "Malcom Gladwell", 400, "November 2009", "Psychology/Philosophy", "December 2021"));

        manager.AddItem(new HardCopy("What Happened to Lani Garver", 5, "Carol Plum-Ucci", 307, "2002", "Young Adult", 9.27, true));
        manager.AddItem(new HardCopy("Zoo Station", 6, "Christiane F.", 366, "2013", "Autobiography", 7.75, false));
        manager.AddItem(new HardCopy("Wasted", 7, "Marya Hornbacher", 298, "1998", "Autobiography", 6.25, false));
        manager.AddItem(new HardCopy("A Little Life", 8, "Hanya Yanagihara", 720, "1998", "Slice of Life", 16.65, false));

        manager.AddItem(new Movie("Scary", 9, 2020, "Made Up Producer", "R"));
        manager.AddItem(new Movie("Weathering With You", 10, 2019, "Minami Ichikawa", "PG-13"));

        manager.AddItem(new Magazine("Deseret Book Catalogue", 11, "Summer 2020"));
        manager.AddItem(new Magazine("Lands End", 12, "Fall 2019"));

        manager.AddItem(new EBook("Valentines", 13, "Ted Kooser", 47, "2008", "Poetry", "February 2022"));
        manager.AddItem(new EBook("The Dictionary of Obscure Sorrows", 14, "John Koenig", 272, "2021", "Romance", "January 2021"));
        manager.AddItem(new EBook("Would You Kill The Fat Man", 15, "David Edmonds", 220, "2014", "Philosophy", "April 2021"));

        manager.AddHolder(new LibraryCardHolder("Ava Lee", 19));
        manager.AddHolder(new LibraryCardHolder("James Dirkson", 12));
        manager.AddHolder(new LibraryCardHolder("Joyce Jams", 44));
        manager.AddHolder(new LibraryCardHolder("Adam Webber", 66));


        Console.WriteLine();

        LibraryCardHolder user = manager.ChooseHolder();

        // Show the menu
        manager.Menu(user);
    }
}