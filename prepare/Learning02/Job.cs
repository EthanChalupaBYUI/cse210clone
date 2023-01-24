public class Job
{
    // public ECtasks = new List<int> { };
    public string _company = "";
    public string _startyear = "";
    public string _endyear = "";
    public string _title = "";


    public Job()
    {
    }

    public void display(){
        Console.WriteLine($"{_title} ({_company}) {_startyear}-{_endyear}")
    }
}