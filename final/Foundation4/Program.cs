using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        // The Exercise class does all the main work. 

// The code is super simple its just a copy over of the lines from each of the classes. 

        // this is the running class
        Console.WriteLine("Running");
        Running running = new Running("31 mar 2023",30,5);
        Console.WriteLine(running.GetSummary());

        // This is the cycling class
        Console.WriteLine("Cycling");
        Bicycles bicycles = new Bicycles("1 April 2023", 45, 10);
        Console.WriteLine(bicycles.GetSummary());


        // this is the Swimminglaps class
        Console.WriteLine("Swimming");
        Swimming swimming = new Swimming("2 April 2023", 20,20);
        Console.WriteLine(swimming.GetSummary());
    }
}