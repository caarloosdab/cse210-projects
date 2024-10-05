using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (string wordText in text.Split(' '))
        {
            _words.Add(new Word(wordText));
        }

    }

    public Reference GetReference()
    {
        return _reference;
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int wordsToHide = Math.Min(numberToHide, _words.Count);
        int hiddenCount = 0;

        while (hiddenCount < wordsToHide)
        {
            int index = rand.Next(_words.Count);
            if(!_words[index].Hidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.ConvertAll(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()}: {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.Hidden())
            {
                return false;
            }
        }
        return true;
    }

    
}



















































/*
using System.ComponentModel;
using System.Dynamic;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    public void Add(Word word)
    {
        _words.Add(word);
    }

    public Reference Get()
    {
        _reference.GetBook();
        _reference.GetChapter();
        _reference.GetVerse();
        return _reference;
    }

    public void SetReference(string b, int c, int v)
    {
        _reference.SetBook(b);
        _reference.SetChapter(c);
        _reference.SetVerse(v);
    }
}
*/