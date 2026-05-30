using YouTubeVideos;


List<Video> videos = new List<Video>();


Video video1 = new Video("C# for Beginners - Full Course", "CodingWithMosh", 7245);
video1.AddComment(new Comment("alice99", "This is exactly what I needed, so clear!"));
video1.AddComment(new Comment("dev_sam", "Watched this three times already, great content."));
video1.AddComment(new Comment("LuisM", "The OOP section really helped me understand encapsulation."));
videos.Add(video1);


Video video2 = new Video("10 VS Code Tips to Code Faster", "Fireship", 612);
video2.AddComment(new Comment("techTina", "The multi-cursor trick blew my mind!"));
video2.AddComment(new Comment("dev_sam", "Number 7 saved me so much time today."));
video2.AddComment(new Comment("marco_dev", "Short and packed with value, subscribed!"));
video2.AddComment(new Comment("Sara_K", "I had no idea about the integrated terminal shortcut."));
videos.Add(video2);


Video video3 = new Video("How Git Works Under the Hood", "TheCherno", 2187);
video3.AddComment(new Comment("LuisM", "Finally a video that explains commits as snapshots!"));
video3.AddComment(new Comment("gitNewbie", "This cleared up so much confusion I had about branches."));
video3.AddComment(new Comment("open_source_fan", "The diagram at 12:00 is worth the whole video."));
videos.Add(video3);


Video video4 = new Video("Object-Oriented Design Patterns Explained", "NeetCode", 3540);
video4.AddComment(new Comment("alice99", "The factory pattern example was really intuitive."));
video4.AddComment(new Comment("marco_dev", "I've read books on this and your explanation tops them all."));
video4.AddComment(new Comment("techTina", "Please do a follow-up on behavioral patterns!"));
video4.AddComment(new Comment("LuisM", "Singleton was always confusing to me, not anymore."));
videos.Add(video4);


foreach (Video video in videos)
{
    Console.WriteLine("══════════════════════════════════════════════");
    Console.WriteLine($"  Title   : {video.GetTitle()}");
    Console.WriteLine($"  Author  : {video.GetAuthor()}");
    Console.WriteLine($"  Length  : {video.GetFormattedLength()}");
    Console.WriteLine($"  Comments: {video.GetNumberOfComments()}");
    Console.WriteLine("  ── Comments ──────────────────────────────");

    foreach (Comment comment in video.GetComments())
    {
        Console.WriteLine($"  [{comment.GetCommenterName()}]: {comment.GetText()}");
    }

    Console.WriteLine();
}
