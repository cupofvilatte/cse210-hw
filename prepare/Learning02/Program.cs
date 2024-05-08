using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 1999;
        job1._endYear = 2004;

        Job job2 = new Job();
        job2._company = "Taco Bell";
        job2._jobTitle = "Schmuck";
        job2._startYear = 2004;
        job2._endYear = 2006;

        Resume resume1 = new Resume();
        resume1.name = "Smithy Jones";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}