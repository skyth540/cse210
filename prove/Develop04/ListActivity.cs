using System;
using System.Diagnostics;
public class ListingActivity : Activity
{
    private string _randomPrompt { get; set; }
    private List<string> _prompts;
    public ListingActivity() : base()
    {
        SetActivityName("Listing Activity");
        SetActivityDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }
    public void RunListingActivity()
    {
        RunActivityStart();
        DisplayPrompt();
        ListingCounter();
        RunActivityEnd();
    }
    private void DisplayPrompt()
    {
        Console.WriteLine("Give as many responses as you can:\n");
        int randomIndex = new Random().Next(0, _prompts.Count());
        Console.WriteLine(_prompts[randomIndex]);
        Console.WriteLine();
    }
    private void ListingCounter()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetUserSessionLengthInput());
        int count = 0;
        while (startTime < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count += 1;
            startTime = DateTime.Now;
        }
        Console.WriteLine($"\nYou got {count} items");
    }
}