using System;
using System.ComponentModel.DataAnnotations;
class Entry {
    public string prompt;
    public string response;
    public DateOnly date;
    public Entry(string prompt, string response, DateOnly date) {
        this.prompt = prompt;
        this.response = response;
        this.date = date;
    }

    public void DisplayEntry() {
        Console.WriteLine($"{prompt}, {response}, {date}");
    }
}