class LibraryCardHolder {
    private string name;
    private int age;
    private List<LibraryItem> checkedOutItems;
    private List<LibraryItem> onHoldItems;

    public LibraryCardHolder(string name, int age) {
        this.name = name;
        this.age = age;
    }
}