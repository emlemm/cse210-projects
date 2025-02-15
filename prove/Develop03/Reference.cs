// The Reference class will store the data for a reference.
// Includes 2 constructors, one for a reference with a single verse 
//      and one for a reference with multiple verses.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
 public class Reference 
 {
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    // private bool _isMultiVerse = false;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }

        public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = endVerse;
    }

    public void Display()
    {
        if (_startVerse != _endVerse)
        {    
            Console.WriteLine($"{_book} {_chapter}:{_startVerse}");
        }
        else 
        {
            Console.WriteLine($"{_book} {_chapter}:{_startVerse}-{_endVerse}");
        }
    }

 }