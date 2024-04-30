public class Resume
{
    public string _nameOwner;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_nameOwner}\nJobs:");

        foreach (Job j in _jobs)
        {
            j.Display();
        }
    }

}