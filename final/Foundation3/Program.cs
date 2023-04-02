using System;

 class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        Address address = new Address("832 fake street","city","OR","usa"); // address is set up in the address class simple string set up

        Lecture lecture = new Lecture("Movie","Movie rating","23","24",address,"Caleb",200);

        Console.WriteLine("Event 1");

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateStandard());
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateDetailedLecture());
        Console.WriteLine();
       

// This is event one, set up in a simple line set up. of writeline 

        Address addressT = new Address("A-1 warehouse","","","");
        Reception reception = new Reception("","","","",address,"");

        Console.WriteLine("Event 2");
        Console.WriteLine();
        Console.WriteLine(reception.GenerateStandard());
        Console.WriteLine();
        Console.WriteLine(reception.GenerateDetailReception());
        
        
    }
}