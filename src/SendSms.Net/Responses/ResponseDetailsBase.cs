using System.Text.Json.Serialization;

namespace SendSms.Net.Responses;

public abstract class ResponseDetailsBase<T>: ResponseBase
{
    [JsonPropertyName("details")]
    public T Details { get; set; }
}