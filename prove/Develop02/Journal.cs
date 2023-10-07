using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(DateTime date, string prompt, string content)
    {
        entries.Add(new Entry(date, prompt, content));
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        Console.WriteLine("Saving to file...");
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._Date},{entry._Prompt},{entry._Content}");
            }
        }
        Console.WriteLine("File saved successfully.");
    }

    public void ReadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            if (parts.Length == 3)
            {
                DateTime dateOfFile = DateTime.Parse(parts[0]);
                string promptOfFile = parts[1];
                string contentOfFile = parts[2];
                entries.Add(new Entry(dateOfFile, promptOfFile, contentOfFile));
            }
        }
    }
}