using System.Collections.Concurrent;
using System.Data;

namespace ScriptureMemorizer;

public class ScriptureReference
{
    private readonly string _book;
    private readonly int _chapter;
    private readonly int _startVerse;
    private readonly int _endVerse;
    private readonly bool _isRange;

    public ScriptureReference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
        _isRange = false;
    }

    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _isRange = true;
    }

    public override string ToString()
    {
        return _isRange
            ? $"{_book}{_chapter}{_startVerse}{_endVerse}"
            :$"{_book}{_chapter}{_startVerse}{_endVerse}";
    }
}