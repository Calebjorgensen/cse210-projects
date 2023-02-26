using System;

class Program
{
    static void Main(string[] args)
    {

        // To get the first menu open and seen.
        Console.WriteLine();
        Console.WriteLine("Menu Options");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start lisitng activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("Please select a choice from the menu: ");

        List<string> aninmationStrings = new List<string>();
        aninmationStrings.Add("/");
        aninmationStrings.Add("\\");
        aninmationStrings.Add("/");
        aninmationStrings.Add("\\");
       foreach (string s in aninmationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();



        int choice = Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 1:
            Console.Clear();
            Breathing breathing = new Breathing();
            break;

            case 2:
            Console.Clear();
            Reflecting reflecting = new Reflecting();
            break;

            case 3:
            Console.Clear();
            Listing listing = new Listing();
            break;

            case 4:
            break;

        }
    }
}