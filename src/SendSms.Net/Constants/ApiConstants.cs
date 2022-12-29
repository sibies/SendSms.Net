namespace SendSms.Net.Constants;

public static class ApiConstants
{
    public const string Version = "1.0.0.0";
    public const string DefaultPhone = "40799999999";

    public const string BaseApiUrl = "https://hub.sendsms.ro"; //"https://api.sendsms.ro"
    public const string BaseApiPath = BaseApiUrl + "/json?action=";
    public const string BasePingApiPath = BaseApiPath + "ping";
    public const string BaseMessageSendApiPath = BaseApiPath + "message_send";

}