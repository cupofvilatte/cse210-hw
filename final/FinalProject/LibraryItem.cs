abstract class LibraryItem {
    protected string title;
    protected int itemID;
    protected bool checkedOut;

    public string Title
    {
        get { return title; }
    }

    public int ItemID
    {
        get { return itemID; }
    }

    public bool CheckedOut
    {
        get { return checkedOut; }
    }

    public LibraryItem(string title, int itemID) {
        this.title = title;
        this.itemID = itemID;
        this.checkedOut = false;
    }

    public virtual void CheckOut() {
        checkedOut = true;
    }

    public virtual void CheckIn() {
        checkedOut = false;
    }
}