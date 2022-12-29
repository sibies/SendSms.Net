using System.Text.Json.Serialization;

namespace SendSms.Net.Responses;

public class ResponseBase
{
    [JsonPropertyName("status")]
    public ResponseStatusCode Status { get; set; }
    [JsonPropertyName("message")]
    public string Message { get; set; }
}