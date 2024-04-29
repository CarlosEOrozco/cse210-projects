using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        Job job2 = new Job();

        Resume resume1 = new Resume();
        Resume resume2 = new Resume();

        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        resume1._name ="Carlos";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume2._name ="Bob";

        //Console.WriteLine(resume1._jobs[0]._jobTitle);

        //Console.WriteLine(job1.DisplayJobDetails());
        //Console.WriteLine(job2.DisplayJobDetails());

        resume1.DisplayResume();



    }
}