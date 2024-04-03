using System;

public class Entry 
{
    public string _date;
    public string _prompt;
    public string _response;

    public void Date()
    {
        DateTime now = DateTime.Now;
        _date = now.ToShortDateString();
    }

    public void Prompt()
    {
        List<string> prompts = new List<string>()
        {
        "What friends did I see today?",
        "What did I learn about in my classes today?",
        "What goals did I accomplish today?",
        "What about my day was the most positive, and what should I work on tomorrow?",
        };

        Random rand = new Random();
        int randI = rand.Next(prompts.Count);
        _prompt = prompts[randI];
        Console.WriteLine(_prompt);
    }


    public void Response()
    {
        Console.Write(">");
        _response = Console.ReadLine();
    }
}