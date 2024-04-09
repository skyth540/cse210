using System;
using System.Diagnostics;

public class Activity
{
    private string _startingMessage;
    private string _endingMessage;
    private string _activityDescription;
    private string _activityName;
    static int _Counter = 0;
    static int _userSessionLengthInput = 0;


    public Activity()
    {
        _Counter = _userSessionLengthInput = 0;
    }

    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }
    public void SetActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }

    public int GetUserSessionLengthInput()
    {
        return _userSessionLengthInput;
    }
    public void DisplayStartingtMessage()
    {
        _startingMessage = $"This is the {_activityName} activity.";
        Console.WriteLine(_startingMessage);
        Console.WriteLine();
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
    }
    public void DisplayEndingMessage()
    {
        _endingMessage = $"That was {_userSessionLengthInput} seconds of {_activityName}.\n";
        DisplayCounter(3);
        Console.WriteLine();
        Console.WriteLine(_endingMessage);
        DisplayCounter(5);
        Console.Clear();
    }

    public void DisplayCounter(int numSecondsToRun)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            _Counter++;
            switch (_Counter % 3)
            {
                case 0: Console.Write("."); break;
                case 1: Console.Write(".."); break;
                case 2: Console.Write("..."); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(500);
        }

        Console.Write(" ");
    }

    public void DisplayCountdown(int numSecondsToRun)
    {
        for (int i = numSecondsToRun; i >= 1; i--)
        {
            Console.Write($"You may begin in: {i}");
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }

    public void DisplayGetSessionLength()
    {
        Console.Write("How long, in seconds, would you like your session? ");
        _userSessionLengthInput = int.Parse(Console.ReadLine());
    }

    public void DisplayGetReady()
    {
        Console.WriteLine("Get ready...");
        DisplayCounter(5);
    }

    public void RunActivityStart()
    {
        DisplayStartingtMessage();
        DisplayDescription();
        DisplayGetSessionLength();
        DisplayGetReady();
        Console.Clear();
    }

    public void RunActivityEnd()
    {
        DisplayEndingMessage();
    }

}