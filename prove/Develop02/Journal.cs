using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        file = file + ".csv";
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine("Date,Prompt,Entry");
             foreach (Entry entry in _entries)
             {
                writer.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
             }   
        }
        Console.WriteLine("Entries saved successfully!");
    }

    public void LoadFromFile(string file)
    {
        file = file + ".csv";
        using (StreamReader reader = new StreamReader(file))
        {
            string line;
            reader.ReadLine();
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(",");
                if (parts.Length == 3)
                {
                    DateTime date = DateTime.Parse(parts[0]);
                    string promptText = parts[1];
                    string entryText = parts[2];

                    Entry loadedEntry = new Entry(date, promptText, entryText);
                    _entries.Add(loadedEntry);
                }
            }
        }
        Console.WriteLine("Entries loaded successfully!");
    }
}