using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the class
        var job1 = new Job();
        var job2 = new Job();
        // Call the method
        job1._company = "Amazon";
        job2._company = "Microsoft";

        job1._jobTitle = "Software Engineer";
        job2._jobTitle = "Data Scientist";

        job1._startYear = "2019";
        job2._startYear = "2020";

        job1._endYear = "2020";
        job2._endYear = "2021";

        

        var resume = new Resume();
        resume._firstname = "Carlos";


        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.displayDetails();

        
        
    }
}