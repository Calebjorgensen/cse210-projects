using System;
public class Exercise
{
    protected string _date;
    protected int _minutes;
    protected string _name;

    public Exercise(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public virtual double CalulateDistance()
    {
        return 0;
    }
    public virtual double CalculateSpeed()
    {
        return 0;
    }
    public string GetSummary()
    {
        string summary = $"{_date} {_name} ({_minutes} min)- Distance {CaluclateDistance()} km, Speed: {CaluclateSpeed}";
        return summary;
    }
}