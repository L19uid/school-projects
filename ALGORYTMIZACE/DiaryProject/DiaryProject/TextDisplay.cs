namespace DefaultNamespace;

public class TextDisplay
{
    public void Info()
    {
        Console.WriteLine("<------------------------------------------------>");
        Console.WriteLine("Deník se ovládá pomocí následujícími příkazy:");
        Console.WriteLine("predchozi - zobrazí předchozí záznam");
        Console.WriteLine("dalsi - zobrazí další záznam");
        Console.WriteLine("novy - přidá nový záznam");
        Console.WriteLine("uloz - uloží záznam");
        Console.WriteLine("smaz - smaže záznam");
        Console.WriteLine("zavri - ukončí program");
        Console.WriteLine("<------------------------------------------------>");
    }

    public void WriteOutDiary()
    {
        Console.WriteLine("Počet záznamů : " + Diary.Count());
        if (Diary.Count() == 0)
            return;
        Console.WriteLine("<------------------------------------------------>");
        Console.WriteLine("Záznam číslo: " + (Diary.index + 1));
        Console.WriteLine("Datum : " + Diary.GetDate());
        Console.WriteLine("Text : " + Diary.GetDescription());
    }
}