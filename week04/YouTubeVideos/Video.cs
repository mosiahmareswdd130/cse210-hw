using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

namespace YouTubeVideos;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    public Video( string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }

    public string GetTitle() => _title;
    public string GetAuthor() => _author;
    public int GetLengthInSeconds() => _lengthInSeconds;
    public List<Comment> GetComments() => _comments;

    public void SetTitle(string title) => _title = title;
    public void SetAuthor(string author) => _author = author;
    public void SetLengthInSeconds(int seconds) => _lengthInSeconds = seconds;
    public void AddComment(Comment comment) => _comments.Add(comment);
    public int GetNumberOfComments() => _comments.Count;


    public string GetFormattedLength()
    {
        int minutes = _lengthInSeconds / 60;
        int seconds = _lengthInSeconds % 60;
        return$"{minutes}{seconds:D2}";
    }
    
}