public class Journal
{
    public List<Entry> _entries { get; set; }

    public Journal()
    {
        _entries = new List<Entry>();

    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void Display()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"Date: {entry._date}, Prompt: {entry._promptText}, Response: {entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(',');
                _entries.Add(new Entry
                {
                    //_date = parts[0].Split(':')[1].Trim(),
                    _promptText = parts[1].Split(':')[1].Trim(),
                    _entryText = parts[2].Split(':')[1].Trim()
                });
            }
        }
    }
    
}