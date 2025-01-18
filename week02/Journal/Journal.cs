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
    public void LoadFromFile (string file)
    {
        string[] lines = System.IO.File.ReadAllLines (file);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
            string[] parts = line.Split("|");
            if (parts.Length == 3)
            {
                Console.WriteLine();                
                 _entries.Add(new Entry
                {
                    _date = parts[0],
                    _promptText = parts[1],
                    _entryText = parts[2],
                });
               
            }
            

        };
        
    
    }

}