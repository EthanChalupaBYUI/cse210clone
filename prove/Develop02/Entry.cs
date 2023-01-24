public class Entry
{
    string _title = "";
    string _content = "";

    string _date = "";

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