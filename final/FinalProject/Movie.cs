class Movie : LibraryItem {
    private int releaseYear;
    private string producer;
    private string rating;
    private List<string> cast;

    public override void CheckOut()
    {
        base.CheckOut();
    }

    public override void CheckIn()
    {
        base.CheckIn();
    }
}