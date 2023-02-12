using System;

public class Scripture
{
    private string _reference;
    private bool[] _whatIsHidden;
    private string[] _rendered;
    private string[] _words;
    private string _content;


//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/

// Link to help with the Array code. Remember the 3 paragraph with it. 

    public Scripture()
    {
        Reference reference = new Reference();
        _reference = reference.GetReference(reference);
        _content = reference.GetScripture(reference);
        CreateArrays(_content);
    }
    public void CreateArrays(string source)
    {
        _words = source.Split();
        int wordCount = _words.Length;
        bool[] whatIsHidden = new bool[wordCount];
        _whatIsHidden = whatIsHidden;
        _rendered = _words;
    }
    public Scripture(int i = 2)
    {
        Reference reference1 = new Reference();
        _reference = reference1.GetReference(reference1);
        _content = reference1.GetScripture(reference1);
        CreateArrays(_content);
    }
   
}