// I added a Scripture Library class so the program gets the scriptures 
// from a library and the user only has to select the scripture by typing 
// the number or letter corresponding to it

using System;

class Program
{
    public static void Main(string[] args)
    {
        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();

        Console.WriteLine("Select a scripture to display: ");
        scriptureLibrary.DisplayScriptureList();

        Console.Write("\nEnter the number of the scripture you want to select: ");
        string selectedKey = Console.ReadLine();

        Scripture selectedScripture = scriptureLibrary.GetScripture(selectedKey);

        if (selectedScripture == null)
        {
            Console.WriteLine("Invalid selection. Program will now exit.");
            return;
        }

        Console.Clear();
        Console.WriteLine(selectedScripture.GetDisplayText());
        Console.WriteLine("\nPress Enter to hide random words or type 'quit' to exit.");

        while (!selectedScripture.IsCompletelyHidden())
        {
            string input = Console.ReadLine();
            if(input.ToLower() == "quit")
            {
                break;
            }

            selectedScripture.HideRandomWords(3);
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
        }

        Console.WriteLine("All words are hidden. Program ends.");
    }
}


































/*
using System;

class Program
{
    static void Main(string[] args)
    {
        string book = "Nefi";
        int chapter = 3;
        int verse = 7;
        
        string text = "You could consider creating a Hider class that has the responsibility for hiding the words in the scripture. What would be Inconvenientes of creating a Hider class instead of leaving that responsibility to the Scripture and Word classes?";


        string[] wordsArray = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        // Convert the array into a list
        List<string> wordsList = new List<string>(wordsArray);

        // Output the list of words
        foreach (string word in wordsList)
        {
            Console.WriteLine(word);
        }


        Console.WriteLine("Hello Develop03 World!");
    }
}
*/