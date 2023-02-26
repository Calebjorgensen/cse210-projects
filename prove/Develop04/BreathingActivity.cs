using System;


public class Breathing
{
    public Breathing()
    {
        Console.WriteLine("Welcome to the Breathing activity!");
        Console.WriteLine();
        Console.WriteLine("This activity will helo you relax by walking you through breathing in and out slowly. Clear your min and focus on your breathing.");
        Console.WriteLine();
        Console.WriteLine("How long, in seconds would you like for your session?");

        int Time = Convert.ToInt32(Console.ReadLine());

        Console.Clear();
        for(int i=1; i>0; i--)
        {
            List<string> aninmationStrings = new List<string>();
            aninmationStrings.Add("Get ready...");
            aninmationStrings.Add("Breathe in...");
            aninmationStrings.Add("breathe out...");
            aninmationStrings.Add("Breathe in...");
            aninmationStrings.Add("breathe out...");
            aninmationStrings.Add("Great Job!");

            foreach(string x in aninmationStrings)
            {
                Console.WriteLine(x);
                Thread.Sleep(3000);

            }
        }

    }    
  
}