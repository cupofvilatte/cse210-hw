class HardCopy : Book {
    private double weight;
    private bool isHardcover;

    public HardCopy(string title, int itemID, string author, int pageCount, string copyrightDate, string genre, double weight) : base(title, itemID, author, pageCount, copyrightDate, genre) {
        this.weight = weight;
    }

    public override void CheckOut() {

    }

    public override void CheckIn() {

    }
}