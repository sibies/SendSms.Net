using SendSms.Net.Constants;
using SendSms.Net.Contracts;
using SendSms.Net.Extensions;
using SendSms.Net.Internal;
using SendSms.Net.Requests;
using SendSms.Net.Responses;

namespace SendSms.Net;

public class SendSmsClient: JsonHttpClient, ISendSmsClient
{
    private readonly SendSmsConfigurations _configurations;

    public SendSmsClient(SendSmsConfigurations configurations)
    {
        _configurations = configurations;
    }
    public async Task<ResponseBase> PingAsync()
    {
        var response = await GetAsync<ResponseBase>(ApiConstants.Other.PingApiPath);
        return response;
    }

    /// <summary>
    /// https://www.sendsms.ro/api/?csharp#query-parameters
    /// In the return result, if successful the details key will contain the message ID.
    /// When sending a message through sendSMS.ro, you have the option to track the delivery of these messages.
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public async Task<SendMessageResponse> SendMessageAsync(SendMessageRequest message)
    {
        message.UserName = _configurations.Username;
        message.Password = _configurations.Password;

        var urlParams = message.ToParameters();
        var queryString = new QueryParamBuilder(urlParams).Build();

        var response = await GetAsync<SendMessageResponse>(ApiConstants.Messages.MessageSendApiPath + queryString);
        return response;
    }
}