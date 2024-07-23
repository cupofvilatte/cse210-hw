class Magazine : LibraryItem {
    private string issue;


    public Magazine(string title, int itemID, string issue) : base(title, itemID) {
        this.issue = issue;
    }

    public override void CheckOut()
    {
        checkedOut = true;
        dueDate = DateOnly.FromDateTime(DateTime.Now.AddDays(2));
    }

    public override void CheckIn()
    {
        base.CheckIn();
    }
}