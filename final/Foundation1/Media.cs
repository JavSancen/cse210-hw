using System;
using System.Collections.Generic;

public abstract class Media
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int Length { get; private set; } // Length in seconds

    protected Media(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public abstract void DisplayInfo();
}