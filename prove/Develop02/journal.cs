using System;

public class Journal
{

    public List<Entry> _entries = new List<Entry>();
    public void Write()
    {
        Entry userEntry = new Entry();
        userEntry.Date();
        userEntry.Prompt();
        userEntry.Response();
        _entries.Add(userEntry);
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"{entry._response}");
            Console.WriteLine();
        }
    }

    public void Load(string file)
    {
        while (true) // Loop until a valid file name is provided
        {
            try
            {
                if (file.EndsWith(".csv"))
                {
                    string[] lines = System.IO.File.ReadAllLines(file);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(",");
                        string date = parts[0];
                        string prompt = parts[1];
                        string response = parts[2];
                        Console.WriteLine($"Date: {date}");
                        Console.WriteLine($"Prompt: {prompt}");
                        Console.WriteLine($"{response}");
                        Console.WriteLine();
                    }
                }
                else
                {
                    using (StreamReader reader = new StreamReader(file))
                    {
                        string journalEntries = reader.ReadToEnd();
                        Console.Write(journalEntries);
                    }
                }

                // Break out of the loop if everything executed successfully
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Not recognized. Please try again.");
                file = Console.ReadLine(); // Read the file name again
            }
        }
    }

    public void Save(string file)
    {
        using StreamWriter finFile = new StreamWriter(file, true);
        if (file.EndsWith(".csv"))
        {
            foreach (Entry entry in _entries)
                {
                    finFile.WriteLine($"{entry._date},{entry._prompt},{entry._response}");
                }
        }
        else
        {
            foreach (Entry entry in _entries)
                {
                    finFile.WriteLine($"Date:{entry._date},{entry._prompt},{entry._response}");
                    finFile.WriteLine($"Prompt:{entry._prompt}");
                    finFile.WriteLine($"{entry._response}");
                    finFile.WriteLine();
            }
        }
    }
}