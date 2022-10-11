using Newtonsoft.Json;
namespace TestLib;

public static class JsonUtils
{
    public static string ToJson(object obj)
    {
        return JsonConvert.SerializeObject(obj, Formatting.Indented);
    }
    
    public static T FromJson<T>(string json)
    {
        return JsonConvert.DeserializeObject<T>(json);
    }
}
