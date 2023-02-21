using System;

public class Scripture
{
    private string _reference;
    private bool[] _whatIsHidden;
    private string[] _rendered;
    private string[] _words;
    private string _content;

    public Scripture()
    {
        Reference reference = new Reference();
        _reference = reference.GetReference(reference);
        _content = reference.GetScripture(reference);
        Console.WriteLine(_content);
        CreateArrays(_content);
    }

    public Scripture(int i = 2)
    {
        Reference reference1 = new Reference();
        _reference = reference1.GetReference(reference1);
        _content = reference1.GetScripture(reference1);
        CreateArrays(_content);
    }
    public void CreateArrays(string source)
    {
        _words = source.Split();
        int wordCount = _words.Length;
        Console.WriteLine($"{wordCount}");
        bool[] whatIsHidden = new bool[wordCount];
        _whatIsHidden = whatIsHidden;
        _rendered = _words;
    }
    public void Display()
    {
        foreach(var word in _rendered)
        {
            Console.Write($"{word} ");
        }
        Console.WriteLine();
        Reference reference1 = new Reference();
        _reference = reference1.GetReference(reference1);
        _content = reference1.GetScripture(reference1);
        CreateArrays(_content);
    }
   
}