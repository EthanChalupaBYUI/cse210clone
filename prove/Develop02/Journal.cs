public class Journal
{
    string _title = "";
    List<Entry> _entries = new List<Entry> { };


    public Journal()
    {
    }
    
    public void createEntry(){
        Entry entry = new Entry();
        entry.setTitle();
        entry.write();
        _entries.Add(entry);
    }

    public void setTitle(){
        Console.WriteLine("What would you like to title this Journal?: ");
        _title = Console.ReadLine();
    }


    public void display(){
        foreach (Entry entry in _entries){
            Console.WriteLine($"{entry}");
        }
    }
}
