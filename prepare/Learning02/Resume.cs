using System.Runtime.CompilerServices;

public class Resume
{
    public string _firstname;
    
    public List<Job> _jobs = new List<Job>();

    public void displayDetails()
    {
        Console.WriteLine(_firstname);
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
           job.displayJobDetails();
        }
    }
}