namespace ScriptureMemorizer;

public class Word
{
    private readonly string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public bool IsHidden => _isHidden;

    public void Hide() => _isHidden = true;

    public string GetDisplayText()
    {
        if (!IsHidden)
        return _text;

        int letterCount = 0;
        string punctuation = "";

        for (int i = _text.Length - 1; i >= 0; i--)
        {
            if (char.IsLetter(_text[i]) || char.IsDigit(_text[i]))
                break;
            punctuation = _text[i] + punctuation;
        }

        foreach (char c in _text)
        {
            if (char.IsLetter(c) || char.IsDigit(c))
                letterCount++;
        }

        return new string('_', letterCount) + punctuation;
    }

    public override string ToString() => GetDisplayText();
}