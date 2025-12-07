using System.IO;
using System.Text.Json;

public class JsonRepository
{
    private readonly string filePath;

    public JsonRepository(string path)
    {
        filePath = path;
    }

    public AppData Load()
    {
        if (!File.Exists(filePath))
            return new AppData();

        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<AppData>(json) ?? new AppData();
    }

    public void Save(AppData data)
    {
        var json = JsonSerializer.Serialize(data, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        File.WriteAllText(filePath, json);
    }
}
