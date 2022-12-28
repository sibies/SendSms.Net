namespace SendSms.Net.Constants;

public static class ApiConsts
{
    public const string Version = "1.0.0.0";
    public const string DefaultPhone = "40799999999";

    public const string BaseApiUrl = "https://hub.sendsms.ro"; //"https://api.sendsms.ro"
    public const string BaseApiPath = BaseApiUrl + "/json?action=";
    public const string BasePingApiPath = BaseApiPath + "ping";
}