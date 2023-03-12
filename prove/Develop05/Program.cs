using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1.Create New Goal");
        Console.WriteLine(" 2.List Goals");
        Console.WriteLine(" 3.Save Goals");
        Console.WriteLine(" 4.Load Goals");
        Console.WriteLine(" 5.Record Event");
        Console.WriteLine(" 6.Quit");
        Console.WriteLine();

        // This is going to the base of the Code, Start with a switch. 

        int choice = Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 1:
            Console.WriteLine();
            Goals goals = new Goals();
            break;

            case 2:
            Console.WriteLine();
            break;

        }

        return;

    }

}