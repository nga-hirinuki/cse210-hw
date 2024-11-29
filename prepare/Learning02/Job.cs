using System;


public class Job
{
    public string _company;   // create variables to pull from user
    public string _jobTitle;            
    public int _startYear;
    public int _endYear;

    public void Display()  //This is how to display results of class Job
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
    
