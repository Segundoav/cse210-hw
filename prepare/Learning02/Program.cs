using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances job
        Job job1 = new Job("Software Engineer", "Microsoft", 2019, 2022);
        Job job2 = new Job("Manager", "Apple", 2022, 2023);

        // Create summary instances
        Resume myResume = new Resume("Juan Pérez");

        // Add to resume
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Show resume
        myResume.DisplayResume();
    }
}
