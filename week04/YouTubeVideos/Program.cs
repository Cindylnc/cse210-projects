using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.\n");
        

        Video video1 = new Video("Introduction to c#", "James Williams", 900);

        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Jasmine", "This was very helpful!"));


        List<Video> videos = new List<Video> { video1 };

        foreach (Video video in videos)
        {
            video.Diplay();
        }


    }
}