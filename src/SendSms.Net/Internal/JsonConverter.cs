//using Newtonsoft.Json;
using System.Text.Json;
using SendSms.Net.Contracts;

namespace SendSms.Net.Internal;

public class JsonConverter: IJsonConverter
{
    public static JsonConverter Instance = new();

    public T DeserializeObject<T>(string value)
    {
        //return JsonConvert.DeserializeObject<T>(value); //Newtonsoft
        return JsonSerializer.Deserialize<T>(value);
    }

    public string SerializeObject<T>(T data)
    {
        //return JsonConvert.SerializeObject(data); //Newtonsoft

        //var options = new JsonSerializerOptions { WriteIndented = true };
        return JsonSerializer.Serialize(data);
    }
}