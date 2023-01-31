public class Entry
{
    public string _title = "";
    public string _content = "";

    public string _date = "";

    public Entry()
    {
    }

    public void setTitle(){
        Console.WriteLine("What would you like to title this entry?: ");
        _title = Console.ReadLine();
    }
    public void write(){
        Console.WriteLine("Whats on your mind?: ");
        _content = Console.ReadLine();
    }

    public void display(){
        Console.WriteLine($"{_content}");
    }
}