class Magazine : LibraryItem {
    private string issue;


    public Magazine(string title, int itemID, string issue) : base(title, itemID) {
        this.issue = issue;
    }

    public override void CheckOut()
    {
        base.CheckOut();
    }

    public override void CheckIn()
    {
        base.CheckIn();
    }
}