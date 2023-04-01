using System;
public class Swimming : Exercise
{
    private double _laps;
    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _name = "Swimming";
        _laps = laps;
    }
    public override double CalulateDistance()
    {
        double distance = _laps * 50 / 1000;
        return distance;
    }
    public override double CalculateSpeed()
    {
        double speed = CalulateDistance() / _minutes * 60;
        return speed;
    }
    public override double CalculatePace()
    {
        double pace = _minutes / CalulateDistance();
        return pace;
    }

}