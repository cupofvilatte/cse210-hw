abstract class LibraryItem {
    private string title;
    private int itemID;
    private bool checkedOut;

    public virtual void CheckOut() {
        checkedOut = true;
    }

    public virtual void CheckIn() {
        checkedOut = false;
    }
}