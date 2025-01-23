using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Senior Software Developer";
        job1._startYear = 2022;
        job1._endYear = 2025;

        // job1.DisplayDetails();

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2018;
        job2._endYear = 2022;

        // job2.DisplayDetails();

        Resume myResume = new Resume();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Console.WriteLine(myResume._jobs[0]._jobTitle);

        myResume._name = "Ben Lemmon";
        myResume.DisplayDetails();
    }
}