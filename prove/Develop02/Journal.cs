using System;
using System.Collections.Generic;
using System.Transactions;

class Journal {

    private List<Entry> entries = new List<Entry>();

    private List<string> prompts = new List<string>();

    public Journal() {

        prompts.Add("What was a win from today?");
        prompts.Add("What's one thing I can take control of in my life?");
        prompts.Add("How can I focus on turning my thoughts into actions?");
        prompts.Add("What is something I've been frusterated with lately? How can I turn that around?");
        prompts.Add("How can I show that I am grateful for the people in my life?");
    }

    public void NewEntry() {
        // randomly choose entry
        Random randomNumber = new Random();
        int randomPrompt = randomNumber.Next(0, 5);

        string currentPrompt = prompts[randomPrompt];

        Console.WriteLine(currentPrompt);
        Console.Write("Please enter your thoughts: ");

        string response = Console.ReadLine();

        DateOnly date = DateOnly.FromDateTime(DateTime.Today);

        Entry entry = new Entry(currentPrompt, response, date);

        entries.Add(entry);
    }

    public void DeleteEntry() {

    }

    public void DisplayJournal() {
        foreach (Entry entry in entries) {
            entry.DisplayEntry();
        }
    }

    public void SaveJournal() {
        using StreamWriter writer = new("journal.csv");
        writer.WriteLine("prompt,response,date");
        
    }

    public void LoadJournal() {
        
    }
}