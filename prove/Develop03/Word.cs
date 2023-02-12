using System;

public class Word
{
    private string _word1;
    private bool _hidden;
    // There is also 0 references for this line of Code??? Why is that. 
    public void SetWord(string word1, bool hidden = true)
    {
        _word1 = word1;
        _hidden = hidden;
    }

// WHAT AM I MISSING?

    // There is 0 references so this Code is not set up correctly somewhere else, (Probably program.cs)
    public string rendered()
    {
        int len = _word1.Length;
        string rendered = "";
        for(int i = 0; i < len; i++)
        {
            rendered = " ";
        }
        return rendered;
    }
}