using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Add a new entry to the journal
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Display all journal _entries
    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    // Save the journal to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}~|~{entry._prompt}~|~{entry._response}");
            }
        }
    }

    // Load journal _entries from a file
    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                _entries.Add(entry);
            }
        }
    }
}