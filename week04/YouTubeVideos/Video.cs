using System.Data;

public class Video 
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;


    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    public void Diplay()
    {
        Console.WriteLine($"TITLE: {_title}");
        Console.WriteLine($"AUTHOR: {_author}   ");
        Console.WriteLine($"LENGTH: {_length}");
        Console.WriteLine($"NUMBER OF COMMENTS: {GetNumberOfComments()}");

        Console.WriteLine("COMMENTS:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($" - {comment.Display()}");
        }
        Console.WriteLine();
    }

}