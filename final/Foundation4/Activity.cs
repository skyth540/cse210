using System;
public abstract class Activity
{
    private string _date { get; set; }
    private double _length { get; set; }
    public Activity(double length)
    {
        _length = length;
    }
    public string GetDate() 
    {
        DateTime date = DateTime.Now;
        string _date = date.ToString("dd-MMM-yyyy");
        return _date;
    }
    public double GetLength()
    {
        return _length;
    }
    public abstract double CalcDistance();
    public abstract double CalcSpeed();
    public abstract double CalcPace();
    public abstract void DisplaySummary();
}
