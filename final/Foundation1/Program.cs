using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        List<Video> videos = new List<Video>();

            Video video1 = new Video("Videogame Analysis", "OMGamer", 300);
            video1.AddComment(new Comment("User1", "Great video!"));
            video1.AddComment(new Comment("User2", "Thanks for the info."));
            video1.AddComment(new Comment("User3", "Very helpful!"));

            Video video2 = new Video("Finding my Turtle", "NatureGuy", 450);
            video2.AddComment(new Comment("User4", "Awesome content."));
            video2.AddComment(new Comment("User5", "Keep it up!"));
            video2.AddComment(new Comment("User6", "So cute!!"));
            video2.AddComment(new Comment("User7", "Follow my Page"));

            Video video3 = new Video("C# for Dummies", "CarlosO", 450);
            video3.AddComment(new Comment("User8", "Awesome content."));
            video3.AddComment(new Comment("User9", "I don't understand :'( "));
            video3.AddComment(new Comment("User10", "First"));

            videos.Add(video1);
            videos.Add(video2);
            videos.Add(video3);

            foreach (var video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.Length} seconds");
                Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
                foreach (var comment in video.Comments)
                {
                    Console.WriteLine($"- {comment.Name}: {comment.Text}");
                }
                Console.WriteLine();
            }
    }
}