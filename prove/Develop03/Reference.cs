public class DisplayReference
{
    private string _book;
    private int _chapter; 
    private int _verseNum;
    private string _verseText;

    public DisplayReference (string book, int chap, int vrs_n)
    {

        _book = book;
        _chapter = chap;
        _verseNum = vrs_n;
    }

    public string FormatRef()
    {
            return $"{_book} {_chapter}:{_verseNum}";
    }

    public void SetText()
    {
        _verseText  = Console.ReadLine();
    }

    public string GetTheVerse()
    {
        return _verseText;
    }
    public string GetBook()
    {
        return _book;
    }

    public int GetChap()
    {
        return _chapter;
    }
    public int GetVerseNum()
    {
        return _verseNum;
    }

}
