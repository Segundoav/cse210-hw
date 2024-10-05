using System;

public class JournalEntry

{
    // Properties for the journal entry
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    // Constructor that initializes a new journal entry

    public JournalEntry(string prompt, string response)

    {
        Date = DateTime.Now.ToString("yyyy-MM-dd");

        Prompt = prompt;

        Response = response;
    }

    public JournalEntry(string prompt, string response, string date)

    {
        Date = date;

        Prompt = prompt;

        Response = response;
    }
}
