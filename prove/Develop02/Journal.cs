public class Journal
{
    public List<Entry> Entries { get; set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void AddEntry(string prompt, string response, string date)
    {
        Entries.Add(new Entry { Prompt = prompt, Response = response, Date = date });
    }

    public void DisplayEntries()
    {
        foreach (var entry in Entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using var writer = new StreamWriter(filename);
        foreach (var entry in Entries)
        {
            writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
        }
    }

    public void LoadFromFile(string filename)
    {
        Entries.Clear();
        using var reader = new StreamReader(filename);
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            var parts = line.Split('|');
            AddEntry(parts[1], parts[2], parts[0]);
        }
    }
}