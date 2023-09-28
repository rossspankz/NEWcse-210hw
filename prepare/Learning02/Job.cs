public class job
{
    public string _company = Console.ReadLine();
    public string _jobTitle = Console.ReadLine();
    public int _startYear = int.Parse(Console.ReadLine());
    public int _endYear = int.Parse(Console.ReadLine());
    public void showJob()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
    

}