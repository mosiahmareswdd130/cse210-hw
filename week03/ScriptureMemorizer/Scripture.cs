using System.Buffers.Binary;

namespace ScriptureMemorizer;

public class Scripture
{
    public readonly ScriptureReference _reference;
    public readonly List<Word> _words;
    private readonly Random _random;
    private const int WordsToHidePerStep = 3;

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _random = new Random();
        _words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                     .Select(w => new Word(w))
                     .ToList();
    }
    public bool IsFullyHidden => _words.All(w=> !w.IsHidden);

    public void HideRandomWords()
    {
        var visible = _words.Where(w => !w.IsHidden).ToList();
        int count = Math.Min(WordsToHidePerStep, visible.Count);

        for( int i = 0; i < count; i++){
            int index = _random.Next(visible.Count);
            visible[index].Hide();
            visible.RemoveAt(index);
        }
    }


    public string GetDisplayText()
    {
        string reference = _reference.ToString();
         string body = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference}{body}";
    }

}