using System;

using System.Collections.Generic;

using System.IO;

// Constructor initializes the journal
public class Journal

{
    private List<JournalEntry> entries;
    private string[] prompts;
    private Random rand;

    public Journal()
    {
        entries = new List<JournalEntry>();

        prompts = new string[]
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I could do one thing today, what would it be?"
        };
        rand = new Random();
    }

    // Adds a new entry to the journal
    public void WriteNewEntry()

    {
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(prompt);

        Console.Write("> ");
        string response = Console.ReadLine();

        JournalEntry entry = new JournalEntry(prompt, response);
        entries.Add(entry);
    }

    public void DisplayEntries()

    {
        foreach (var entry in entries)

        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine();
        }
    }

    // saves the journal entries to a file
    public void SaveToFile(string filename)

    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string filename)

    {
        entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (var line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length == 3)

            {
                JournalEntry entry = new JournalEntry(parts[1], parts[2], parts[0]);
                entries.Add(entry);
            }
        }
    }
}
