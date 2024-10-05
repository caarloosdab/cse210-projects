public class Word 
{
    private string _text;
    private bool _hidden;

    public Word (string text)
    {
        _text = text;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }
    public void Show()
    {
        _hidden = false;
    }
    public bool Hidden()
    {
        return _hidden;
    }

    public string GetDisplayText()
    {
        return _hidden ? "____" : _text;
    }
}







































/*public class Word
{
    private string _word;
    private bool _hide;


    public Word()
    {
        _word = "Default";
        _hide = false;
    }

    public string Get()
    {
        return _word;
    }

    public void Set(string w)
    {
        _word = w;
    }
}
*/