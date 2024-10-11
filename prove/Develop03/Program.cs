using System;
using System.Linq;
using System.Collections.Generic;

public class Reference
{

    public string Book { get; }
    public int StartVerse { get; }
    public int? EndVerse { get; }


    public Reference(string book, int verse)
    
    {
        Book = book;
        StartVerse = verse;
        EndVerse = null;

    }

    public Reference(string book, int startVerse, int endVerse)

    {
        Book = book;
        StartVerse = startVerse;
        EndVerse = endVerse;

    }

    public override string ToString()
    {
        return EndVerse.HasValue ? $"{Book} {StartVerse}-{EndVerse}" : $"{Book} {StartVerse}";

    }
}

public class Word
{
    public string Text { get; private set; }
    public bool IsHidden { get; private set; }


    public Word(string text)

    {

        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public override string ToString()
    {
        return IsHidden ? "__" : Text;
    }

}

public class Scripture

{
    public Reference Ref { get; }
    private List<Word> Words { get; }


    public Scripture(Reference reference, string text)

    {
        Ref = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList(); 
    }

    public void HideRandomWord(Random rand)

    {
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();
        if (visibleWords.Count > 0)
        {

            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }

    public override string ToString()
    {
        return $"{Ref}: {string.Join(" ", Words)}";
    }

    public bool AllWordsHidden()
    {

        return Words.All(w => w.IsHidden);
    }
}

public class Program

{

    public static void Main()
    {
        var reference = new Reference("John", 3, 16);
        var scripture = new Scripture(reference, "For God so loved the world that He gave His only begotten son, that whosoever belieth in him shall not perish, but have everlasting life");
        var rand = new Random();

        Console.WriteLine(scripture);

        while (!scripture.AllWordsHidden())

        {
            Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit:");
            var input = Console.ReadLine();

            if (input.ToLower() == "quit")
            break;

            Console.Clear();
            scripture.HideRandomWord(rand);
            Console.WriteLine(scripture);
        }

        Console.WriteLine("All words are hidden, Program has ended!");

    }
}




