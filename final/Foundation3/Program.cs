using System;

 class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        Address address = new Address("832 fake street","city","OR","usa");

        Lecture lecture = new Lecture("Movie","Movie rating","23","24",address,"Caleb",200);

        Console.WriteLine("Event 1");

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateStandard());
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateDetailedLecture());
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateShortLecutre());

        Address addressT = new Address("A-1 warehouse","","","");

        
        

        Console.WriteLine("Event 2");
        Console.WriteLine();
        
    }
}