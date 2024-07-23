class EBook : Book {
    private string electronicPublicationDate;

    public EBook(string title, int itemID, string author, int pageCount, string copyrightDate, string genre, string electronicPublicationDate) : base(title, itemID, author, pageCount, copyrightDate, genre) {
        this.electronicPublicationDate = electronicPublicationDate;
    }

    public override void CheckOut() {
        checkedOut = false;
        dueDate = DateOnly.FromDateTime(DateTime.Now.AddDays(14));
    }

    public override void CheckIn() {
        base.CheckIn();
    }
}