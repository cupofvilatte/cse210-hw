using System;
using System;
class Scripture {

    private string book;
    private int chapter;
    private int verse;
    private int startVerse;
    private int endVerse;
    private string scriptureText;

    private List<Reference> scriptures = new List<Reference>();

    public Scripture(string book, int chapter, int verse, string scriptureText) {
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
        this.scriptureText = scriptureText;
    }

    public Scripture(string book, int chapter, int startVerse, int endVerse, string scriptureText) {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse;
        this.scriptureText = scriptureText;
    }

    public string GetScripture() {
        return scriptureText;
    }

    public override string ToString()
    {
        if (verse != 0) {
            return $"{book} {chapter}:{verse} ";
        }
        else {
            return $"{book} {chapter}:{startVerse}-{endVerse} ";
        }
    }
}