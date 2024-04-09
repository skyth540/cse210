public class ScriptureWord
{
    private string _theWord;
    private bool _isHidden;

    public ScriptureWord(string text)
    {
        _theWord = text;
        _isHidden = false;
    }

    public string GetLine()
    {
        if(_isHidden == true)
        {
            _theWord = "______";
        }
        return _theWord;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}