public class Entry
{
    public string _title = "";
    public string _prompt = "";
    public string _content = "";
    public string _date = "";

    public Entry()
    {
        DateTime localDate = DateTime.Now;
        _date = localDate.ToShortDateString();
    }

    public void setTitle()
    {
        Console.WriteLine("What would you like to title this entry?: ");
        _title = Console.ReadLine();
    }
    public void write()
    {
        _prompt = getPrompt();
        Console.WriteLine(_prompt);
        _content = Console.ReadLine();
    }
    private string getPrompt()
    {
        List<string> _prompts = new List<string> {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };
        Random rnd = new Random();
        return _prompts[rnd.Next(0, _prompts.Count())];
    }

    public void display()
    {
        Console.WriteLine($"{_content}");
    }
}