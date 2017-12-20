using Newtonsoft.Json;
using System.IO;

namespace ServerGUI.Utilities.Config
{
    public class ConfigSystem
    {
        public void Save<T>(T Data, string FilePath)
        {
            string Json = JsonConvert.SerializeObject(Data);
            File.WriteAllText(FilePath, Json);
        }

        public T Load<T>(string FilePath)
        {
            string Json = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<T>(Json);
        }
    }
}