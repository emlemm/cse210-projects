// The Word class will store each word of a scripture
//      and stores it's hidden/shown state.
// The Word class will handle switching the state from hidden to shown.

using System;
using System.Collections.Generic;

public class Word
{
    private string _text;

    private bool _isHidden = false;

    public Word(string word)
    {
        _text = word;
    }

    public void Hide() 
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public void Display()
    {
        if (!_isHidden)
        { 
            Console.Write($" {_text}");
        }
        else
        {
            Console.Write(" ");
            Console.Write(new String('_', _text.Length));
        }
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}