using System;
using System.Collections.Generic;
using System.IO;
public class Entry
{
    public DateTime _Date;
    public string _Prompt;
    public string _Content;

    public Entry(DateTime date, string prompt, string content)
    {
        _Date = date;
        _Prompt = prompt;
        _Content = content;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_Date.ToShortDateString()} - Prompt: {_Prompt}");
        Console.WriteLine($"{_Content}");
    }
}