using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
public class Journal
{
    // The journal displays the total number of entries currently stored and the entries themselves

    public List<Entry> _entries= new List<Entry>();
    public void DisplayAll()
    {
        Console.WriteLine($"Total entries: {_entries.Count}");
        foreach(Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"Response: {entry._response}");
        }
    }
    // Saves the journal to a file with the specified filename
    public void SaveToFile(string filename)
    {
        using(StreamWriter writer=new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
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
                string[] parts = line.Split('|');
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._prompt = parts[1];
                entry._response = parts[2];
                _entries.Add(entry);
            }
        }
    }
}