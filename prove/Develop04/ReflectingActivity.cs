using System;

public class Reflecting
{
    public Reflecting()
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Reflection Activity.");
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflecet on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session?");

        int Time = Convert.ToInt32(Console.ReadLine());

        Console.Clear();
        for(int i=1; i>0; i--)
        {
            List<string> aninmationStrings = new List<string>();
            aninmationStrings.Add("Get ready...");
            aninmationStrings.Add("Consider the following promt:");
            aninmationStrings.Add("---Think of a time when you did something really difficult.---");
            aninmationStrings.Add("When you have something in mind, press enter to continue.");
          

            foreach(string x in aninmationStrings)
            {
                Console.WriteLine(x);
                Thread.Sleep(1000);

            }
        }

    }
}