using SendSms.Net.Internal;

namespace SendSms.Net.Requests;

public class RequestBase
{
    [Parameter("username")]
    public string UserName { get; internal set; }
    [Parameter("password")]
    public string Password { get; internal set; }
}