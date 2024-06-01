using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create some comments
        Comment comment1 = new Comment("Alice", "Great video!");
        Comment comment2 = new Comment("Bob", "Very informative.");
        Comment comment3 = new Comment("Charlie", "I learned a lot.");
        Comment comment4 = new Comment("Diana", "Awesome content!");

        // Create some videos and add comments to them
        Video video1 = new Video("C# Basics", "John Doe", 600);
        video1.Comments.Add(comment1);
        video1.Comments.Add(comment2);

        Video video2 = new Video("Advanced C#", "Jane Smith", 1200);
        video2.Comments.Add(comment3);

        Video video3 = new Video("C# Design Patterns", "Emily Johnson", 900);
        video3.Comments.Add(comment4);
        video3.Comments.Add(comment1);

        Video video4 = new Video("C# in Depth", "Michael Brown", 1500);
        video4.Comments.Add(comment2);
        video4.Comments.Add(comment3);
        video4.Comments.Add(comment4);

        // Add videos to a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Iterate through the list of videos and display their details
        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}