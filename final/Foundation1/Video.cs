using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    public List<Comment> Comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = length;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Video: {_title} by {_author} ({_lengthInSeconds} seconds)");
        Console.WriteLine($"Comments ({GetCommentCount()})");
        foreach (Comment comment in Comments)
        {
            Console.WriteLine($"- {comment._commentor}: {comment._commentText}");
        }
        Console.WriteLine();
    }
}