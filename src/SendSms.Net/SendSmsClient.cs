using SendSms.Net.Constants;
using SendSms.Net.Contracts;
using SendSms.Net.Internal;
using SendSms.Net.Responses;

namespace SendSms.Net;

public class SendSmsClient: JsonHttpClient, ISendSmsClient
{
    public async Task<ResponseBase> PingAsync()
    {
        var response = await GetAsync<ResponseBase>(ApiConsts.BasePingApiPath);
        return response;
    }

}