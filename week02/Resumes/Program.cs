using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Civil engineer";
        job1._company = "  Gft";
        job1._startYear = 2014;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._jobTitle = "Programmer";
        job2._company = "Google";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Jhonatan Yugsan";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}