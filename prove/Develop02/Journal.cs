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

    public Journal(string Display, string Load, string Save, string Quit)
    {
        _display = Display;
        _load = Load;
        _save = Save;
        _quit = Quit;
    }
    public void DisplayInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"{_display}");
    }

}