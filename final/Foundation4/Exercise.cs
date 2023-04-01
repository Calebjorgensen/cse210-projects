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
}