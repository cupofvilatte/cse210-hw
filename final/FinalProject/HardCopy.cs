class HardCopy : Book {
    private double weight;
    private bool isHardcover;

    public HardCopy(string title, int itemID, string author, int pageCount, string copyrightDate, string genre, double weight, bool isHardcover) : base(title, itemID, author, pageCount, copyrightDate, genre) {
        this.weight = weight;
        this.isHardcover = isHardcover;
    }

    public override void CheckOut() {
        base.CheckOut();
    }

    public override void CheckIn() {
        base.CheckIn();
    }
}