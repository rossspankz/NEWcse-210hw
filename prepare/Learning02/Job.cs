public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;
    public void showJob()
    {
        Console.Write("What was your job title? ");
        _jobTitle = Console.ReadLine();

        Console.Write("What comapny did you work for? ");
        _company = Console.ReadLine();

        Console.Write("What year did you start? ");
        _startYear = int.Parse(Console.ReadLine());

        Console.Write("What year did you stop working there? ");
        _endYear = int.Parse(Console.ReadLine());

        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
    

}