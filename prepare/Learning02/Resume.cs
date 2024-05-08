using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;
class Resume
{
    public string name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }

    }

}