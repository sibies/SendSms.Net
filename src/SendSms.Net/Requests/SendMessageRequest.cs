using SendSms.Net.Internal;

namespace SendSms.Net.Requests;

public class SendMessageRequest: RequestBase
{
    [Parameter("to")]
    public string To { get; set; }
    [Parameter("from")]
    public string From { get; set; }
    [Parameter("text")]
    public string Text { get; set; }
    [Parameter("report_mask")]
    public int ReportMask { get; set; }
    [Parameter("report_url")]
    public string ReportUrl { get; set; }
}