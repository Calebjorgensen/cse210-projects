using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        Address address = new Address("832 fake street");

        Lecture lecture = new Lecture("Rocky 3 is better then Cree 3");

        Console.WriteLine("Event 1");

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateStandard());
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateDetailedLecture());
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateShortLecutre());

        Address address1 = new Address("A-1 warehouse");
        Reception reception = new Reception("Joey and el", address);
    }
}