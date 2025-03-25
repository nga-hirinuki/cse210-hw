using System.Security.Cryptography.X509Certificates;
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
        foreach (var entry in _entries)
        {
            entry.Display();  // Using Entry's Display() method for formatting
            Console.WriteLine();  // Add spacing for clarity
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
            }
        }
        Console.WriteLine($"Entries successfully saved to {fileName}.");
    }

    public void LoadFromFile(string fileName)
    {

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found. Please try again.");
            return;
        }
        _entries.Clear(); // Prevent duplicates when loading again

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _promptText = parts[1],
                        _entryText = parts[2]
                    };
                    _entries.Add(entry);
                }   
            }
        }
        Console.WriteLine($"Entries successfully loaded from {fileName}.");
     

        
    }
}
