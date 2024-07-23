class LibraryCardHolder {
    public string Name { get; private set; }
    public int Age {get; private set; }
    private List<LibraryItem> checkedOutItems;
    private List<LibraryItem> onHoldItems;

    public void AddCheckedOutBooks(LibraryItem item) {
        checkedOutItems.Add(item);
    }

    public void DeleteCheckedInBooks(LibraryItem item) {
        bool removed = checkedOutItems.Remove(item);

        if (removed) {
            Console.WriteLine($"{item.Title} has been removed from the checked-out list.");
        } else {
            Console.WriteLine($"{item.Title} could not be found!");
        }
    }

    public void AddToHolds(LibraryItem item) {
        onHoldItems.Add(item);
    }

    public void ViewCheckedOutItems() {
        int totalWidth = 50;
        Console.WriteLine($"Title {new string('-', 37)} Due Date");
        foreach (LibraryItem item in checkedOutItems) {
            string title = item.Title;
            string dueDate = item.dueDate?.ToShortDateString() ?? "N/A";

            int dashesCount = totalWidth - (title.Length + dueDate.Length);
            if (dashesCount < 0) dashesCount = 0;

            string dashes = new string('-', dashesCount);

            Console.WriteLine($"{title} {dashes} {dueDate}");
        }
    }

    public void ViewHolds() {
        foreach (LibraryItem item in this.onHoldItems) {
            Console.WriteLine($"Title: {item.Title}");
        }
    }

    public LibraryCardHolder(string name, int age) {
        this.Name = name;
        this.Age = age;

        checkedOutItems = new List<LibraryItem>();
        onHoldItems = new List<LibraryItem>();
    }
}