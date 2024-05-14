using System;

class Program
{
    static void Main()
    {
        // Create a WritingAssignment object
        WritingAssignment myWritingAssignment = new WritingAssignment(
            "Raef Meeuwisse",
            "Cibersecurity",
            "Cybersecurity for beginners" // It is a book I'm reading right now
        );

        // Call the GetSummary method inherited from the base class and display the result
        string summary = myWritingAssignment.GetSummary();
        Console.WriteLine(summary);

        // Call the GetWritingInformation method specific to WritingAssignment and display the result
        string writingInfo = myWritingAssignment.GetWritingInformation();
        Console.WriteLine(writingInfo);
    }
}