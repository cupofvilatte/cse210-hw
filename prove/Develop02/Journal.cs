using System;
using System.Transactions;
class Journal {
    private List<Entry> entries = new List<Entry>;

    private List<string> prompts = new List<string>();

    public Journal() {
        prompts.Add("What was a win from today?");
        prompts.Add("What's one thing I can take control of in my life?");
        prompts.Add("How can I focus on turning my thoughts into actions?");
        prompts.Add("What is something I've been frusterated with lately? How can I turn that around?");
        prompts.Add("How can I show that I am grateful for the people in my life?");
    }

    public void NewEntry() {

    }

    public void DeleteEntry() {

    }

    public void DisplayJournal() {

    }

    public void SaveJournal() {

    }

    public void LoadJournal() {
        
    }
}