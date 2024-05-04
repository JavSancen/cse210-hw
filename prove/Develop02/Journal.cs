public class Journal
{
    private List<Entry> Entries = new List<Entry>();
    private PromptGenerator _promptGenerator = new PromptGenerator();

    public void StartJournal()
    {
        Console.WriteLine("To start, select one of the following options: ");
        Console.WriteLine("1 - Write");
        Console.WriteLine("2 - Display");
        Console.WriteLine("3 - Load");
        Console.WriteLine("4 - Save");
        Console.WriteLine("5 - Quit");

        string input = Console.ReadLine();

        while (input != "5")
        {
            switch (input)
            {
                case "1":
                    string randomQuestion = _promptGenerator.GetRandomPrompt();
                    Console.WriteLine(randomQuestion);
                    string answer = Console.ReadLine();
                    AddEntry(new Entry { Description = randomQuestion, Value = answer, Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") });
                    break;
                case "2":
                    DisplayAll();
                    break;
                case "3":
                    Console.WriteLine("Enter the file name to load: ");
                    string fileToLoad = Console.ReadLine();
                    LoadFromFile(fileToLoad);
                    break;
                case "4":
                    Console.WriteLine("Enter the file name to save: ");
                    string fileToSave = Console.ReadLine();
                    SaveToFile(fileToSave);
                    break;
            }

            Console.WriteLine("\nSelect an option: ");
            input = Console.ReadLine();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter streamWriter = new StreamWriter(file))
        {
            foreach (var entry in Entries)
            {
                //- You can write data to a file line by line or character by character using `StreamWriter`.
                //- It provides methods like `Write()`, `WriteLine()`, and `Flush()` to write text data.
                //In the context of the `Journal` class you provided:
                //- `StreamWriter` is used in the `SaveToFile` method to write journal entries to a file.
                //- `StreamReader` is used in the `LoadFromFile` method to read journal entries from a file.
                streamWriter.WriteLine($"{entry.Id}|{entry.Date}|{entry.Description}|{entry.Value}");
            }
        }
        Console.WriteLine($"Journal saved to {file}.");
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        using (StreamReader streamReader = new StreamReader(file))
        {
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                var entryData = line.Split('|');
                if (entryData.Length !=4)
                {
                    Console.WriteLine("Invalid entry format in file.");
                    continue;
                }

                AddEntry(new Entry
                {
                    // It is '?' a short way to make an if-else operator to indicate that if the parsing is true to assign a value and if not let it = 0.
                    Id = int.TryParse(entryData[0], out int id) ? id : 0,
                    Date = entryData[1],
                    Description = entryData[2],
                    Value = entryData[3]
                });
            }
        }
        Console.WriteLine($"Journal loaded from {file}.");
    }

    private void AddEntry(Entry entry)
    {
        // This line is to make sure every entry has a unique identifier in case of a research and make it efficient in the future.
        entry.Id = Entries.Count + 1;
        Entries.Add(entry);
    }

    private void DisplayAll()
    {
        foreach (var entry in Entries)
        {
            Console.WriteLine($"ID: {entry.Id}, Date: {entry.Date}, DEscription: {entry.Description}, Value: {entry.Value}");
        }
    }
}