using System.Text.Json;

namespace ServerGUI.Utilities.Config;

public class ConfigSystem
{
    public void Save<T>(T Data, string FilePath)
    {
        var Json = JsonSerializer.Serialize(Data);
        File.WriteAllText(FilePath, Json);
    }

    public T Load<T>(string FilePath)
    {
        var Json = File.ReadAllText(FilePath);
        return JsonSerializer.Deserialize<T>(Json);
    }
}