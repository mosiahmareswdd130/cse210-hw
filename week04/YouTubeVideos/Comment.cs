namespace YouTubeVideos;

public class Comment
{
    public string _commenterName;
    public string _text;

    public Comment(String commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    public string GetCommenterName() => _commenterName;
    public string GetText() => _text;

    public string SetCommenterName(string name) => _commenterName = name;
    public string SetText(string text) => _text = text;
}