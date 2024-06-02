using System;

// Stretch: a unique 3 words are hidden each round of the activity. I basically create a list of visible index numbers. When the index isn't found for a word, it's replaced with the strings. This just ensures the activity will not have rounds with few or no new missing words. It also means the practice takes the same amount of turns each time it is run, while still maintaining randomness of which words disappear.
class Program
{
    static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture("Jacob", 3, 2, "O all ye that are pure in heart, lift up your heads and receive the pleasing word of God, and feast upon his love; for ye may, if your minds are firm, forever.");

        Scripture scripture2 = new Scripture("Alma", 37, 6, 7, "Now ye may suppose that this is a foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise. And the Lord God doth work by means to bring about his great and eternal purposes; and by very small means the Lord doth confound the wise and bringeth about the salvation of many souls.");

        Reference reference = new Reference(scripture1.GetScripture());

        bool quit = false;
        while (!quit) {
            Console.Write(scripture1.ToString());
            Console.WriteLine(reference.GetVerse());
            Console.WriteLine();
            Console.WriteLine("Press enter to coninue or type 'quit' to finish:");

            string userInput = Console.ReadLine()?.Trim().ToLower();
            Console.Clear();

            if (userInput == "quit") {
                quit = true;
            }
            else if (reference.AllWordsHidden()) {
                quit = true;
            }
            else {
                reference.HideRandomWords(3);
            }
        }
        Console.WriteLine("Great Job! Happy Memorizing!");
    }
}