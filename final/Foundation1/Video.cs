using System;
using System.Collections.Generic;

public class Video : Media
{
    public List<Comment> Comments { get; private set; }

    public Video(string title, string author, int length)
        : base(title, author, length)
    {
        Comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

        foreach (Comment comment in Comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }

        Console.WriteLine(); // For better readability between videos
    }
}
