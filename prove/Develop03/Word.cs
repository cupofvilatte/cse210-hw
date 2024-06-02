using System;
class Word {
    private string word;
    private bool hidden;

    public Word(string word) {
        this.word = word;
        hidden = false;
    }
    public string GetWord() {
        return word;
    }

    public void HideWord() {
        hidden = true;
    }

    public bool Hidden {
        get { return hidden; }
    }

    public override string ToString()
    {
        return hidden ? new string('_', word.Length) : word;
    }
}