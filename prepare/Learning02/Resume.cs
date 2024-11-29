public class Resume
{
    public string _name;
    
    public List<Job> _jobs = new List<Job>();  // when job values are submitted store in Job list

     public void Display()                      // I got stuck here so I copied from tutors files to understand why 
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)              // display all results stored in list
        {
            job.Display();  // This calls the Display method on each job
        }
    }
}