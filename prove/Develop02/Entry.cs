using System;

public class Entry
{
    public string _date { get; set; }
    public string _prompt { get; set; }
    public string _response { get; set; }

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    // Returns the entry as a formatted string
    public override string ToString()
    {
        return $"{_date} | Prompt: {_prompt} | Response: {_response}";
    }
}