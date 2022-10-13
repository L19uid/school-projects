using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DefaultNamespace;

public class Diary
{   
    private static LinkedList<diaryValue> _entries = new LinkedList<diaryValue>();

    public static int index;

    public static void Next()
    {
        if(_entries.Count > index + 1)
        {
            index += 1;
        }
    }
    
    public static void Previous()
    {
        if(index > 0)
        {
            index -= 1;
        }
    }
    
    public void HandleInput(string input)
    {
        switch (input)
        {
            case"dalsi": Next(); break;
            case"predchozi": Previous(); break;
            case"novy": New(); break;
            case"smaz": Delete(); break;
            case"zavri": Close(); break;
        }
    }

    public static void Load()
    {
        _entries = JsonService.LoadData();
    }
    
    public static void New()
    {
        Console.Write("Datum : ");
        String dateInput = Console.ReadLine();
        if (!CheckDate(dateInput))
            return;
        
        Console.WriteLine();
        Console.Write("Text : ");
        String description = "";
        
        do
        {
            string line = Console.ReadLine();
            if (line.Contains("uloz"))
            {
                break;
            }
            if(line != "")
                description += line + "\n";
        } while (true);
                
        diaryValue diaryInput = new diaryValue(dateInput,description);
        if(CheckDate(diaryInput.getDate()))
            _entries.AddLast(diaryInput);
    }
    
    public static void Delete()
    {
        _entries.Remove(_entries.ElementAt(index));
        index = 0;
    }

    public static void Close()
    {
        JsonService.SaveData(_entries);
        Environment.Exit(0);
    }

    public static int Count()
    {
        return _entries.Count();
    }
    
    public static string GetDate()
    {
        return _entries.ElementAt(index).getDate();
    }
    public static string GetDescription()
    {
        return _entries.ElementAt(index).getDescription();
    }
    
    public static bool CheckDate(string input)
    {
        DateTime date;
        if (DateTime.TryParse(input, out date))
        {
            return true;
        }
        else
        {
            Console.WriteLine("Neplatný formát data");
            return false;
        }
    }
    
    
}