using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scritpure = new Scripture();
        string input = "";
       
        while (input != "quit")
        {   
            // Why is this not working? 
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Press enter or type quit:   ");
            Console.WriteLine();
            input = Console.ReadLine();
            
        } 
        Console.WriteLine();
        Console.WriteLine("See you next time!");
        Console.WriteLine();
        Environment.Exit(0);
    }
    // The quit varbile works, but I can't bring up the scripture, something 
}