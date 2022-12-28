using SendSms.Net.Requests;
using SendSms.Net.Responses;

namespace SendSms.Net.Contracts;

public interface ISendSmsClient
{
    Task<ResponseBase> PingAsync();
    Task<SendMessageResponse> SendMessageAsync(SendMessageRequest message);
}