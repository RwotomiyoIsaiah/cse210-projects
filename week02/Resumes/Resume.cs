public class Resume()
{
    public string _name;
    public List<Job>_myJobs=new List<Job>();
    public void DisplayJobs()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach(Job job in _myJobs)
        {
            job.DisplayJobInformation();
        }  
    }   
}