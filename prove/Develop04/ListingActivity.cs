using System;

public class Listing
{
    public Listing()
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Listing Activity.");
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as your can in a certain area.");
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session?");

        int Time = Convert.ToInt32(Console.ReadLine());

        Console.Clear();
        for(int i=1; i>0; i--)
        {
            List<string> aninmationStrings = new List<string>();
            aninmationStrings.Add("Get ready...");
            aninmationStrings.Add("List as many responses you can to the following prompt:");
            aninmationStrings.Add("--- When you have felt the Holy Ghost this month?---");
            aninmationStrings.Add("You may begin: ");
            

            foreach(string x in aninmationStrings)
            {
                Console.WriteLine(x);
                Thread.Sleep(3000);

            }
        }
    }
}