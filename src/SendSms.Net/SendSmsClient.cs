using SendSms.Net.Constants;
using SendSms.Net.Contracts;
using SendSms.Net.Extensions;
using SendSms.Net.Internal;
using SendSms.Net.Requests;
using SendSms.Net.Responses;

namespace SendSms.Net;

public class SendSmsClient: JsonHttpClient, ISendSmsClient
{
    public async Task<ResponseBase> PingAsync()
    {
        var response = await GetAsync<ResponseBase>(ApiConstants.BasePingApiPath);
        return response;
    }

    /// <summary>
    /// https://www.sendsms.ro/api/?csharp#query-parameters
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public async Task<SendMessageResponse> SendMessageAsync(SendMessageRequest message)
     {
         var urlParams = message.ToParameters();
         var queryString = new QueryParamBuilder(urlParams).Build();

        var response = await GetAsync<SendMessageResponse>(ApiConstants.BaseMessageSendApiPath + queryString);
        return response;
    }
}