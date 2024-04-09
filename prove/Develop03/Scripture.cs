using System;
using System.Collections.Generic;
public class Scripture
{   
    private DisplayReference _theRef;
    private ScriptureWord theText;
    private List<string> _listVerse = new();
    private List<string> _hiddenWords = new();
    private string[] _text;
    public Scripture(DisplayReference reference)
    {
        _theRef = reference;
        _text = _theRef.GetTheVerse().Split(" ");
        foreach (string word in _text)
        {
            theText = new ScriptureWord(word);
            _listVerse.Add(theText.GetLine());
        }
    }
    public void HideWord (int number)
    {
        Random random = new();
        
        for (int i = 0; i < number; i++)
        {
            int randNum = random.Next(_listVerse.Count());
            string removedWord = _listVerse[randNum];
            
            if (removedWord != "______")
            {
                _hiddenWords.Add(removedWord);
            }
            if(removedWord == "______")
            {
                randNum = random.Next(_listVerse.Count());
                
            }
            
            _listVerse.RemoveAt(randNum);
            theText.Hide();
            _listVerse.Insert(randNum, theText.GetLine());
        }

    }
    public bool IsAllBlank()
    {
        bool isIt = false;
        bool result = _listVerse.All(word => word == "______");
        if(result)
        {
            isIt = true;
        }
        return isIt;
    }
    public void DisplayText()
    {
        string theRef = _theRef.FormatRef();
        Console.WriteLine($"\n{theRef}\n{string.Join(" ", _listVerse)}\n");
    }

}