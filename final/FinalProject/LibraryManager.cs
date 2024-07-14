class LibraryManager {
    private List<LibraryItem> inventory;

    public LibraryManager() {
        inventory = new List<LibraryItem>();
    }

    public void Menu(){
        bool quit = false;
        while (!quit){
            Console.WriteLine("Library Manager Menu:");
            Console.WriteLine("1. Check In Book");
            Console.WriteLine("2. Check Out Book");
            Console.WriteLine("3. View Inventory");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice){
                case "1":
                    CheckInBook();
                    Console.WriteLine("This element is not yet completely opperational");
                    break;
                case "2":
                    CheckOutBook();
                    Console.WriteLine("This element is not yet completely opperational");
                    break;
                case "3":
                    ViewInventory();
                    break;
                case "4":
                    quit = true;
                    break;
            }
        }
    }

    private void CheckInBook()
    {
        // Console.WriteLine("Enter the title of the book to check in: ");
        // string title = Console.ReadLine();
        // LibraryItem item = inventory.Find(b => b.title == title && b.checkedOut);
        // if (book != null)
        // {
        //     book.checkedOut = false;
        //     Console.WriteLine($"Book '{title}' has been checked in.");
        // }
        // else
        // {
        //     Console.WriteLine($"Book '{title}' not found or is already checked in.");
        // }
    }

    private void CheckOutBook()
    {
        // Console.WriteLine("Enter the title of the book to check out: ");
        // string title = Console.ReadLine();
        // Book book = inventory.Find(b => b.title == title && !b.checkedOut);
        // if (book != null)
        // {
        //     book.checkedOut = true;
        //     Console.WriteLine($"Book '{title}' has been checked out.");
        // }
        // else
        // {
        //     Console.WriteLine($"Book '{title}' not found or is already checked out.");
        // }
    }

    private void ViewInventory()
    {
        Console.WriteLine("Library Inventory:");
        foreach (LibraryItem item in inventory){

            Console.WriteLine($"Title: {item.Title}, Item ID: {item.ItemID}, Checked Out: {item.CheckedOut}");
        }
    }

    // Method to add books to the inventory to implement later
    public void AddItem(LibraryItem item)
    {
        inventory.Add(item);
    }
}