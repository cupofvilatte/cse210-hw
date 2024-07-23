using System.Diagnostics;

class LibraryManager {
    private List<LibraryItem> inventory;
    private List<LibraryCardHolder> cardHolders;

    public LibraryManager() {
        inventory = new List<LibraryItem>();
        cardHolders = new List<LibraryCardHolder>();
    }

    public LibraryCardHolder ChooseHolder() {
        for (int i = 0; i < cardHolders.Count; i++) {
            Console.WriteLine($"{i+1}) {cardHolders[i].Name}");
        }

        Divider();

        Console.WriteLine();
        Console.WriteLine("Select a user");

        int userIndex = int.Parse(Console.ReadLine()) - 1;
        LibraryCardHolder user = cardHolders[userIndex];

        return user;
    }

    public void Menu(LibraryCardHolder holder) {
        bool quit = false;
        while (!quit){
            Console.WriteLine($"Library Manager Menu ------- {holder.Name}");
            Console.WriteLine("1. Check In Item");
            Console.WriteLine("2. Check Out Item");
            Console.WriteLine("3. View Total Inventory");
            Console.WriteLine("4. View Holds");
            Console.WriteLine("5. View Checked Out Items");
            Console.WriteLine("6. Switch Card Holder");
            Console.WriteLine("7. Quit");

            Divider();

            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice){
                case "1":

                    CheckInBook(holder);
                    break;

                case "2":
                    CheckOutBook(holder);
                    break;

                case "3":
                    ViewInventory();
                    break;

                case "4":
                    holder.ViewHolds();
                    Divider();
                    break;

                case "5":
                    holder.ViewCheckedOutItems();
                    Divider();
                    break;

                case "6":
                    holder = ChooseHolder();
                    break;

                case "7":
                    quit = true;
                    break;
            }
        }
    }

    private void CheckInBook(LibraryCardHolder holder)
    {
        Console.WriteLine("Enter the title of the item to check in: ");
        string title = Console.ReadLine();
        LibraryItem item = inventory.Find(b => b.Title == title && b.checkedOut);

        if (item != null) {
            if (item.checkedOut == true) {
                item.CheckIn();
                Console.WriteLine($"Book '{title}' has been checked in.");

                holder.DeleteCheckedInBooks(item);
            } else {
                Console.WriteLine("This book was already checked in!");
            } 
        } else {
            Console.WriteLine($"Book '{title}' not found.");
        }

        Divider();
    }

    private void CheckOutBook(LibraryCardHolder holder)
    {
        Console.WriteLine("Enter the title of the item to check out: ");
        string title = Console.ReadLine();

        LibraryItem item = inventory.Find(b => b.Title == title);
        if (item != null) {
            if (item.checkedOut == false) {
                item.CheckOut();

                holder.AddCheckedOutBooks(item);

            } else {
                Console.WriteLine($"'{title}' has been checked out by someone else.");
                Console.WriteLine($"Would you like to place '{title}' on hold? (y/n)");

                Divider();

                string response = Console.ReadLine();
                if (response == "y") {
                    holder.AddToHolds(item);
                    Console.WriteLine("Item successfully held!");
                }
            }
        } else {
            Console.WriteLine($"'{title}' not found in this library.");
        }

        Divider();
    }

    private void ViewInventory()
    {
        Console.WriteLine("Library Inventory:");
        foreach (LibraryItem item in inventory){

            Console.WriteLine($"Title: {item.Title}, Item ID: {item.ItemID}, Checked Out: {item.CheckedOut}");
        }

        Divider();
    }

    // Method to add books to the inventory to implement later
    public void AddItem(LibraryItem item){
        inventory.Add(item);
    }

    public void AddHolder(LibraryCardHolder newHolder) {
        cardHolders.Add(newHolder);
    }

    public static void Divider() {
        Console.WriteLine();
        Console.WriteLine(new string('-', 30));
        Console.WriteLine();
    }
}