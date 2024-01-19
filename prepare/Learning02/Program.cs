using System;

class Program
{
    static void Main(string[] args)
    {
        var job1 = new Job { Company = "Microsoft", JobTitle = "Software Engineer", StartYear = 2019, EndYear = 2022 };
        var job2 = new Job { Company = "Apple", JobTitle = "Manager", StartYear = 2022, EndYear = 2023 };

        var resume = new Resume { Name = "Nicholas Mendez" };
        resume.Jobs.Add(job1);
        resume.Jobs.Add(job2);

        resume.Display();
    }
}