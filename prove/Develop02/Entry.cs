using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    // Returns the entry as a formatted string
    public override string ToString()
    {
        return $"{Date} | Prompt: {Prompt} | Response: {Response}";
    }
}