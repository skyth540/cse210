using System;
public class Swimming : Activity
{
    private int _laps { get; set; }
    public Swimming(double length, int laps) : base(length)
    {
        _laps = laps;
    }
        public override double CalcDistance()
    {
        double distance =  Math.Round(_laps * 50 / 1000 * 0.62, 1);
        return distance;
    }
    public override double CalcSpeed()
    {
        double speed = Math.Round((CalcDistance() / GetLength()) * 60, 1);
        return speed;
    }
    public override double CalcPace()
    {
        double pace = Math.Round(GetLength() / CalcDistance(), 1);
        return pace;
    }
    public override void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} Swimming ({GetLength()} min), Distance: {CalcDistance()} miles, Speed: {CalcSpeed()}, Pace: {CalcPace()} minutes per mile");
    }
}