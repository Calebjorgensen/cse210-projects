using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private string _text;
    private string _john_3_16 = "For God so loved the world taht he gave his only begotten Son, that whosoever believth in him should not peris, but have everlasting life.";

    public Reference()
    {
        _book = "john";
        _chapter = 3;
        _verse = 16;
        _text = _john_3_16;
    }
    public Reference(string book, int chapter, int verse, string text )
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _text = text;
    }
    public string GetScripture(Reference reference)
    {
        return reference._text;
    }
    public string GetReference(Reference reference)
    {
        return reference._book;
    }

}