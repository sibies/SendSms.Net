namespace SendSms.Net.Contracts;

public interface IJsonConverter
{
    T DeserializeObject<T>(string value);
    string SerializeObject<T>(T data);
}