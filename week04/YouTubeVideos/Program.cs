using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.\n");
        

        Video video1 = new Video("Introduction to c#", "James Williams", 900);
        Video video2 = new Video("A day in the life of a student", "Margorie Dodson", 1500);

        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Jasmine", "This was very helpful!"));

        video2.AddComment(new Comment("Siena", "Where do you? Seems like a great place to be"));
        video2.AddComment(new Comment("Drake", "I miss those days"));


        List<Video> videos = new List<Video> { video1 };

        foreach (Video video in videos)
        {
            video.Diplay();
        }


    }
}