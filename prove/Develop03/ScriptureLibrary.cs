using System;
using System.Collections.Generic;

public class ScriptureLibrary
{
    private Dictionary<string, Scripture> _library;

    public ScriptureLibrary()
    {
        _library = new Dictionary<string, Scripture>();

        _library.Add("1", new Scripture(new Reference("John", 3, 16), "For God so loved the world that He gave His only begotten Son"));
        _library.Add("2", new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight"));
        _library.Add("3", new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd; I shall not want"));
        _library.Add("4", new Scripture(new Reference("Matthew", 5, 14, 16), "14 Ye are the light of the world. A city that is set on an hill cannot be hid. Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house. Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven."));
        _library.Add("5", new Scripture(new Reference("1 Corinthians", 6, 19, 20), "What? know ye not that your body is the temple of the Holy Ghost which is in you, which ye have of God, and ye are not your own? For ye are bought with a price: therefore glorify God in your body, and in your spirit, which are God’s."));
        _library.Add("6", new Scripture(new Reference("Isaiah", 53, 3, 5), "3 He is despised and rejected of men; a man of sorrows, and acquainted with grief: and we hid as it were our faces from him; he was despised, and we esteemed him not. Surely he hath borne our griefs, and carried our sorrows: yet we did esteem him stricken, smitten of God, and afflicted. But he was wounded for our transgressions, he was bruised for our iniquities: the chastisement of our peace was upon him; and with his stripes we are healed."));
    }

    public void DisplayScriptureList()
    {
        Console.WriteLine("Available Scriptures:");
        foreach (var key in _library.Keys)
        {
            Console.WriteLine($"{key}: {_library[key].GetReference().GetDisplayText()}");
        }
    }

    public Scripture GetScripture(string key)
    {
        if (_library.ContainsKey(key))
        {
            return _library[key];
        }
        else
        {
            return null;
        }
    }
}
