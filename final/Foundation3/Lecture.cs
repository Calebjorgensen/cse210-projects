using System;
public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string activity, string date, string time, Address address, string speaker, int capacity) : base(title, activity, date, time, address, speaker, capacity)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string GetSpeaker()
    {
        return _speaker;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public string ReturnEventType()
    {
        return "Lecture";
    }
    public string GenerateDetailedLecture()
    {
        string detailed = GeneratedStandard() + "\n";
        detailed += "Speaker:" + _speaker + "\n";
        detailed += "Capacity:" + _capacity + " pax";

        return detailed;

    }
    public string GenerateShortLecutre()
    {
        string shortLecture = "";
        string eventType = ReturnEventType();
        shortLecture += "Event Type: " + eventType + "\n";
        shortLecture += GenerateShort();
        return shortLecture; 
    }

}