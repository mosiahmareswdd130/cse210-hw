namespace ScriptureMemorizer;


public class ScriptureLibrary
{
    private readonly List<Scripture> _scriptures;
    private readonly Random _random;

    public ScriptureLibrary()
    {
        _random = new Random();
        _scriptures = new List<Scripture>
        {
            new Scripture(
                new ScriptureReference("John", 3, 16),
                "For God so loved the world that he gave his one and only Son, " +
                "that whoever believes in him shall not perish but have eternal life."),

            new Scripture(
                new ScriptureReference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all your heart and lean not on your own understanding; " +
                "in all your ways submit to him, and he will make your paths straight."),

            new Scripture(
                new ScriptureReference("Philippians", 4, 13),
                "I can do all this through him who gives me strength."),

            new Scripture(
                new ScriptureReference("Romans", 8, 28),
                "And we know that in all things God works for the good of those who love him, " +
                "who have been called according to his purpose."),

            new Scripture(
                new ScriptureReference("Joshua", 1, 9),
                "Have I not commanded you? Be strong and courageous. Do not be afraid; " +
                "do not be discouraged, for the Lord your God will be with you wherever you go."),

            new Scripture(
                new ScriptureReference("Psalm", 23, 1, 3),
                "The Lord is my shepherd, I lack nothing. He makes me lie down in green pastures, " +
                "he leads me beside quiet waters, he refreshes my soul."),

            new Scripture(
                new ScriptureReference("Isaiah", 40, 31),
                "But those who hope in the Lord will renew their strength. They will soar on wings " +
                "like eagles; they will run and not grow weary, they will walk and not be faint."),

            new Scripture(
                new ScriptureReference("Matthew", 11, 28),
                "Come to me, all you who are weary and burdened, and I will give you rest."),
        };
    }

    public Scripture GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }

    public int Count => _scriptures.Count;
}