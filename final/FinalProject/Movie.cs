class Movie : LibraryItem {
    private int releaseYear;
    private string producer;
    private string rating;

    public Movie(string title, int itemID, int releaseYear, string producer, string rating) : base (title, itemID) {
        this.releaseYear = releaseYear;
        this.producer = producer;
        this.rating = rating;
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