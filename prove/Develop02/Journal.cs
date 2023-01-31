public class Journal
{
    public string _title = "";
    public List<Entry> _entries = new List<Entry> { };


    public Journal()
    {
    }
    6
    public void createEntry(){
        Entry entry = new Entry();
        entry.setTitle();
        entry.write();
        _entries.Add(entry);

    }

    public void deleteEntry(int toDelete){
        _entries.Remove(_entries[toDelete-1]);
        Console.WriteLine($"Deleted entry {toDelete}")
    }

    public void setTitle(){
        Console.WriteLine("What would you like to title this Journal?: ");
        _title = Console.ReadLine();
    }


    public void display(){
        int index = 1;
        Console.WriteLine("blah blah");
        foreach (Entry entry in _entries){
            Console.WriteLine($"{index}.{entry._title}");
            index++;
        }
    }
}
