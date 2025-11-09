// A code template for the category of things known as Job.
// The responsibility of a Job is to hold and display job-related information.

public class Job
{
    // Member variables (attributes)
    public string _jobTitle = "";
    public string _company = "";
    public int _startYear;
    public int _endYear;

    // Method to display job details in the format: "Job Title (Company) StartYear-EndYear"
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
