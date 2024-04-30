using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._jobCompany = "(Microsoft)";
        job1._jobStartYear = 2019;
        job1._jobEndYear = 2022;


        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._jobCompany = "(Apple)";
        job2._jobStartYear = 2022;
        job2._jobEndYear = 2023;

        Resume resumeOwner = new Resume();
        resumeOwner._nameOwner = "Allison Rose";
        resumeOwner._jobs.Add(job1);
        resumeOwner._jobs.Add(job2);
        resumeOwner.Display();
    }
}