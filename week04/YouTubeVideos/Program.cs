using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.\n");
        

        Video video1 = new Video("Introduction to c#", "James Williams", 900);
        Video video2 = new Video("A day in the life of a student", "Margorie Dodson", 1500);
        Video video3 = new Video("How to succeed in life", "Melanie Sanz", 2800);

        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Jasmine", "This was very helpful!"));
        video1.AddComment(new Comment("Claudia", "Thank you! so clear and straight to teh point"));

        video2.AddComment(new Comment("Siena", "Where do you go? Seems like a great place to be."));
        video2.AddComment(new Comment("Drake", "I miss those days!"));
        video2.AddComment(new Comment("Jackson", "Hey! I think I've seen you around. Awesome content"));

        video3.AddComment(new Comment("Blake", "Love the analogies in the story you shared."));
        video3.AddComment(new Comment("Cindy", "Great insights!"));
        video3.AddComment(new Comment("Melanie", "Just the video i needed today"));


        List<Video> videos = new List<Video> { video1, video2, video3};

        foreach (Video video in videos)
        {
            video.Diplay();
        }


    }
}