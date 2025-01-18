using System.IO; 
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry (Entry newEntry)
    {
        _entries.Add (newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile (string file)
    {
       
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}| {entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine ($"Journal Entry saved to {file}");
    }
       

    public void LoadFromFile (string fileName)
    {
        string [] lines = File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string [] parts = line.Split("|");

            if (parts.Length == 3)
            {
                Entry newEntry = new Entry
                {
                    _date = parts[0],
                    _promptText = parts [1],
                    _entryText = parts [2]

                };
                _entries.Add(newEntry);
            }
        }
        Console.WriteLine($"Journal loaded from {fileName}");
    }



}