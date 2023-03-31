using System;
public class Event
{
    private string _title;
    private string _activity;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string activity, string date, string time, Address address)
    {
        _title = title;
        _activity = activity;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GenerateStandard()
    {
        string standand = "Title:" + _title + "\n";
        standand += "Description:" +_activity + "\n";
        standand += _date + " " + _time + "\n";

        string address = _address.GenerateCompleteAddress();
        standand += address;

        return standand;
    }
    public string GenerateShort()
    {
        string shortM = "Title:" +_title + "\n";
        shortM += _date + "\n";
        return shortM;
    }
}