using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("C# Tutorial for Beginners", "Techie Tom", 600);
        Video video2 = new Video("Top 10 Programming Languages", "CodeWithChris", 900);
        Video video3 = new Video("Advanced C# Programming", "Dev Jane", 1200);

        // Add comments to video 1
        video1.AddComment(new Comment("Alice", "Great tutorial, thanks!"));
        video1.AddComment(new Comment("Bob", "Very helpful for beginners."));
        video1.AddComment(new Comment("Charlie", "Looking forward to the next video!"));

        // Add comments to video 2
        video2.AddComment(new Comment("David", "Python should be number one!"));
        video2.AddComment(new Comment("Eva", "Nice comparison between languages."));
        video2.AddComment(new Comment("Frank", "Go Java!"));

        // Add comments to video 3
        video3.AddComment(new Comment("George", "This was quite advanced, but I learned a lot."));
        video3.AddComment(new Comment("Helen", "Clear explanations, great job."));
        video3.AddComment(new Comment("Ian", "Could you make a tutorial on LINQ?"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video details and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment._commenterName}: {comment._commentText}");
            }
            Console.WriteLine();
        }
    }
}