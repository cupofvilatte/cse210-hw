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
        int deleteIndex = 0;
        for (int i = 0; i < entries.Count; i++)
        {
            Console.WriteLine($"{i+1}. {entries[i].response}, {entries[i].date}");
        }

        Console.Write("Which number would you like to delete? ");
        deleteIndex = int.Parse(Console.ReadLine());
        deleteIndex -= 1;

        entries.RemoveAt(deleteIndex);
    }

    public void DisplayJournal() {
        foreach (Entry entry in entries) {
            entry.DisplayEntry();
        }
    }

    public void SaveJournal() {
        Console.Write("What filename would you like to save to? ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine("Prompt,Response,Date");

            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.prompt},{entry.response},{entry.date}");
            }
        } 
    }

    public void LoadJournal() {
        Console.Write("What file would you like to load from? ");
        string filename = Console.ReadLine();
        using (StreamReader reader = new StreamReader(filename))
        {
            string header = reader.ReadLine();

            string line;
            while ((line = reader.ReadLine()) != null) {
                string[] values = line.Split(',');

                string prompt = values[0];
                string response = values [1];
                DateOnly date = DateOnly.Parse(values[2]);

                Entry newEntry = new Entry(prompt, response, date);
                entries.Add(newEntry);
            }

            Console.WriteLine("Journal Entries:");
            foreach (var entry in entries)
            {
                Console.WriteLine($"Prompt: {entry.prompt}, Response: {entry.response}, Date: {entry.date}");
            }
        }
    }
}