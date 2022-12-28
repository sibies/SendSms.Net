namespace SendSms.Net.Responses;

public class ResponseBase
{
    public ResponseStatusCode Status { get; set; }
    public string Message { get; set; }
}