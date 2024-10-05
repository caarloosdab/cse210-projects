public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }

    public string GetBook()
    {
        return _book;
    }

    public int GetChapter()
    {
        return _chapter;
    }
    public int GetVerse()
    {
        return _verse;
    }
    public int GetEndVerse()
    {
        return _endVerse;
    }


    public void SetBook(string book)
    {
        _book = book;
    }
    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }
    public void SetVerse(int verse)
    {
        _verse = verse;
    }
    public void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }


}































/*
public class Reference {
    private string _book;
    private int _chapter;
    private int _verse;

    public Reference()
    {
        _book = "Default";
        _chapter = 0;
        _verse = 00;
    }

    public Reference(string book)
    {
        _book = book;
        _chapter = 1;
        _verse = 1; 
    }

    public string GetBook()
    {
        return _book;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public int GetVerse()
    {
        return _verse;
    }


    public void SetBook(string b)
    {
        _book = b;
    }

    public void SetChapter(int c)
    {
        _chapter = c;
    }

    public void SetVerse(int v)
    {
        _verse = v;
    }

}
*/