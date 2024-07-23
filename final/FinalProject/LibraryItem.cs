using System;
using Microsoft.VisualBasic;
abstract class LibraryItem {
    protected string title;
    protected int itemID;
    public bool checkedOut { get; set;}
    public DateOnly? dueDate { get; protected set; }

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
        this.dueDate = null;
    }

    public virtual void CheckOut() {
        checkedOut = true;
        dueDate = DateOnly.FromDateTime(DateTime.Now.AddDays(14));
    }

    public virtual void CheckIn() {
        checkedOut = false;
        dueDate = null;
    }
}