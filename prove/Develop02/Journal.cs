using System;
public class Journal
{
    public string _title = "";
    public string filepath = @"save.csv";

    public List<Entry> _entries = new List<Entry> { };


    public Journal()
    {

    }

    public void createEntry()
    {
        Entry entry = new Entry();
        entry.setTitle();
        entry.write();
        _entries.Add(entry);

    }

    public void deleteEntry(int toDelete)
    {
        _entries.Remove(_entries[toDelete - 1]);
        Console.WriteLine($"Deleted entry {toDelete}");
    }

    public void setTitle()
    {
        Console.WriteLine("What would you like to title this Journal?: ");
        _title = Console.ReadLine();
    }

 
    public void display()
    {
        int index = 1;
        Console.WriteLine(_title);
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"{index}.{entry._title}");
            Console.WriteLine(entry._content);
            index++;
        }
    }
    public void saveData()
    {

        string toSave = "";
        toSave += _title;
        toSave += "|";
        for (int i = 0; i < _entries.Count(); i++)
        {

            toSave += _entries[i]._title;
            toSave += "|";
            toSave += _entries[i]._prompt;
            toSave += "|";
            toSave += _entries[i]._content;
            toSave += "|";
            toSave += _entries[i]._date;

        }
        try
        {
            File.Delete(filepath);
            using (StreamWriter writer = new StreamWriter(filepath))
            {
                writer.Write(toSave);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error writing to file: " + ex.Message);
        }
    }
    public void loadData()
    {
        List<Entry> entries = new List<Entry>();
        try
        {
            using (StreamReader reader = new StreamReader(filepath))
            {

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split('|');
                    _title = fields[0];
                    Entry entry = new Entry();
                    for (int i = 0; i < fields.Count(); i++)
                    {
                        switch(i % 4){
                            case 1: entry._title = fields[i]; break;
                            case 2: entry._prompt = fields[i]; break;
                            case 3: entry._content = fields[i]; break;
                            case 0: entry._date = fields[i]; break;

                        }
                        entries.Add(entry);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading from file: " + ex.Message);
        }
        _entries = entries;
    }
}
