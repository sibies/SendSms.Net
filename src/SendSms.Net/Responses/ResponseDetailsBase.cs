namespace SendSms.Net.Responses;

public abstract class ResponseDetailsBase<T>: ResponseBase
{
    public T Details { get; set; }
}