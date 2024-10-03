using System;
using System.Collections.Generic;

public class Resume
{
    // Attributes
    public string _name;
    public List<Job> _jobs;

    // Builder
    public Resume(string name)
    {
        _name = name;
        _jobs = new List<Job>();
    }

    // Add to resume
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    // Add to resume
    public void DisplayResume()
    {
        Console.WriteLine($"Currículum de: {_name}");
        foreach (var job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}
