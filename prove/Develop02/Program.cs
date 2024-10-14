using System;

class Program
{
    static void Main(string[] args)
    {
        Journal _journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry(_journal, promptGenerator);
                    break;

                case "2":
                    _journal.DisplayJournal();
                    break;

                case "3":
                    SaveJournal(_journal);
                    break;

                case "4":
                    LoadJournal(_journal);
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }

    // Handles writing a new entry
    static void WriteNewEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine("\nPrompt: " + prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        // Record the current date
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        Entry newEntry = new Entry(date, prompt, response);
        journal.AddEntry(newEntry);

        Console.WriteLine("Your entry has been recorded.");
    }

    // Handles saving the journal to a file
    static void SaveJournal(Journal journal)
    {
        Console.Write("\nEnter a filename to save the journal: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
        Console.WriteLine("Journal saved to " + filename);
    }

    // Handles loading the journal from a file
    static void LoadJournal(Journal journal)
    {
        Console.Write("\nEnter a filename to load the journal: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
        Console.WriteLine("Journal loaded from " + filename);
    }
}
