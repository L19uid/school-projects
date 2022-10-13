using System.Text.Json;

namespace DefaultNamespace;

public class JsonService
{
    public static LinkedList<diaryValue> LoadData()
    {
        string json = "";
        using (var reader = new StreamReader("./diary.json"))
        {
             json = reader.ReadToEnd();
        }

        using (JsonDocument document = JsonDocument.Parse(json))
        {
            JsonElement root = document.RootElement;
            LinkedList<diaryValue> diaryValuesList = new LinkedList<diaryValue>();
            foreach (var el in root.EnumerateArray())
            {
                var date = el.GetProperty("date").GetString();
                var description = el.GetProperty("description").GetString();
                diaryValuesList.AddLast(new diaryValue(date, description));
            }
            return diaryValuesList;
        }
    }

    public static void SaveData(LinkedList<diaryValue> _entries)
    {
        using (FileStream fs = File.Open("./diary.json", FileMode.OpenOrCreate))
        {
            using (Utf8JsonWriter writer = new Utf8JsonWriter(fs))
            {
                writer.WriteStartArray();
                var ents = _entries.ToArray();
                for (int i = 0; i < ents.Length; i++)
                {
                    writer.WriteStartObject();
                    writer.WriteString("date", ents[i].getDate());
                    writer.WriteString("description", ents[i].getDescription());
                    writer.WriteEndObject();
                }
                writer.WriteEndArray();
            }
        }
    }
}