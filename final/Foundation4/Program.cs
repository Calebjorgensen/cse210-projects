using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        Console.WriteLine("Running");
        Running running = new Running("31 mar 2023",30,5);
        Console.WriteLine(running.GetSummary());


        Console.WriteLine("Cycling");
        Bicycles bicycles = new Bicycles("1 April 2023", 45, 10);
        Console.WriteLine(bicycles.GetSummary());

        Console.WriteLine("Swimming");
        Swimming swimming = new Swimming("2 April 2023", 20,20);
        Console.WriteLine(swimming.GetSummary());
    }
}