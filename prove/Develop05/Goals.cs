using System;

public class Goals
{
    public Goals()
    {
        Console.WriteLine();
        Console.WriteLine("Select a choice from the Menu: ");
        Console.WriteLine("The type of Goals are: ");
        Console.WriteLine(" 1.Simple Goal");
        Console.WriteLine(" 2.Eternal Goal");
        Console.WriteLine(" 3.CheckList Goal");
        Console.WriteLine("What type of Goals would you like to create? ");




        int goalchoice = Convert.ToInt32(Console.ReadLine());
        switch(goalchoice)
        {
            case 1:
            Console.WriteLine("This is a test");
            Simplegoals simplegoals = new Simplegoals();
            break;

            case 2:
            Console.WriteLine();
            Eternalgoals eternalgoals = new Eternalgoals();

            break;

            case 3:
            Console.WriteLine();
            Checklist checklist = new Checklist();
            break;
        }
    }
   
}