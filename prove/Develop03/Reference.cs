using System;
using System.Data;
using System.Globalization;
using System.Text;
using System.Text.Json.Serialization;
class Reference {
    private List<Word> verse = new List<Word>();
    private List<int> visibleIndices = new List<int>();

    public Reference(string scripture) {
        string[] words = scripture.Split(' ');
        foreach (string word in words) {
            verse.Add(new Word(word));
            visibleIndices.Add(verse.Count - 1);
        }
    }

    public string GetVerse() {
        // List<string> visibleWords = new List<string>();
        // foreach (int index in visibleIndices) {
        //     visibleWords.Add(verse[index].GetWord());
        // }
        // return string.Join(" ", visibleWords);

        StringBuilder visibleVerse= new StringBuilder();

        for (int i = 0; i < verse.Count; i++) {
            if (visibleIndices.Contains(i)) {
                visibleVerse.Append(verse[i].ToString());
            }
            else {
                visibleVerse.Append(new string('_', verse[i].GetWord().Length));
            }

            if (i < verse.Count -1) {
                visibleVerse.Append(" ");
            }
        }
        return visibleVerse.ToString();
    }

    public void HideRandomWords(int wordsToHideCount) {
        Random random = new Random();
        for (int i = 0; i < wordsToHideCount; i++) {
            int index = random.Next(visibleIndices.Count);
            visibleIndices.RemoveAt(index);
        }
    }

    public bool AllWordsHidden() {
        foreach (int index in visibleIndices) {
            if (!verse[index].Hidden) {
                return false;
            }
        }
        return true;
    }

    public override string ToString()
    {
        List<string> visibleWords = new List<string>();
        foreach (int index in visibleIndices)
        {
            visibleWords.Add(verse[index].ToString());
        }
        return string.Join(" ", visibleWords);
    }
}