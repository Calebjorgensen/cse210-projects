using System;

//public class Journal{

   // static void Main(string[] args){

     //   Entry record = new Entry();
        
   // }
//}


public class Journal
{
    private string _display;
    private string _load;
    private string _save;
    private string _quit;

    private List<Entry> _entry = new List<Entry>();

    public Journal(string Display, string Load, string Save, string Quit)
    {
        _display = Display;
        _load = Load;
        _save = Save;
        _quit = Quit;
    }
    public void ListEntry(Entry entry)
    {
        _entry.Add(entry);
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"{_display}");
        Console.WriteLine();
        Console.WriteLine($"{_entry}");

        foreach(Entry entry in _entry)
        {

        }
    }

<<<<<<< Updated upstream
=======
        foreach(Entry entry in _entry)
        {
            entry.DisplayInfo();

        }
    }
>>>>>>> Stashed changes

}