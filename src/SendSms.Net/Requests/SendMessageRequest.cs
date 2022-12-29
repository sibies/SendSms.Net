using System.ComponentModel.DataAnnotations;
using SendSms.Net.Internal;

namespace SendSms.Net.Requests;

public class SendMessageRequest: RequestBase
{
    /// <summary>
    /// A phone number in E.164 Format but without the + sign (eg. 40727363767)
    /// </summary>
    [Required]
    [Parameter("to")]
    public string To { get; set; }    
    /// <summary>
    /// The body of your message
    /// </summary>
    [Required]
    [Parameter("text")]
    public string Text { get; set; }
    /// <summary>
    /// Sending label
    /// </summary>
    [Parameter("from")]
    public string From { get; set; } = null;

    /// <summary>
    /// Delivery report request bitmask (see above)
    /// Which status messages you would like to receive
    ///
    /// To calculate the report mask, you need to pick the status codes you want to receive, and then add them together, voila! That’s your report mask.
    /// For example: I want to receive whether my message was delivered or failed. (1, 2 and 16).
    /// report_mask = 1 + 2 + 16 = 19
    /// So in your next request, send report_mask=19 and we’ll send you these status’ messages where applicable.
    /// Seems simple enough, what about getting some extra data in the request?
    /// We provide you with some extra fields which you can specify and we’ll replace them for you before we send the messages back to your server
    /// %d – the status code of the message
    /// In case ctype is greater than 1, ctype will be added to the DLR. This way you can differentiate Viber from SMS in the delivery report.
    /// </summary>
    [Parameter("report_mask")]
    public int ReportMask { get; set; } = 19;
    /// <summary>
    /// URL to call when delivery status changes (see above)
    /// The HTTP URL for us to request when the status changes
    /// </summary>
    [Parameter("report_url")]
    public string ReportUrl { get; set; } = null;
    /// <summary>
    /// : Character set to use
    /// </summary>
    [Parameter("charset")]
    public string Charset { get; set; } = "UTF-8";
    /// <summary>
    /// Data coding
    /// </summary>
    [Parameter("data_coding")]
    public int? DataCoding { get; set; } = null;
    /// <summary>
    /// Message class
    /// </summary>
    [Parameter("message_class")]
    public int MessageClass { get; set; } = -1;
    /// <summary>
    /// Auto detect the encoding and send appropriately (useful for sending arabic, hindi, unicode etc messages)
    /// 1 = on,
    /// 0 = off
    /// </summary>
    [Parameter("auto_detect_encoding")]
    public int AutoDetectEncoding { get; set; } = 0;
    /// <summary>
    /// The short parameter can have two forms
    /// 
    /// "string" Add sort url at the end of message or search for key {short} in message and replace with short url when parameter contain URL
    /// "boolean" Searches long url and replaces them with coresponding sort url when short parameter is "true".
    /// 
    ///  Please use only urls that start with https:// or http:// 
    /// </summary>
    [Parameter("short")]
    public string Short { get; set; } = null;
    /// <summary>
    /// 1 = SMS (Default),
    /// 2 = RCS - (not active yet),
    /// 3 = Viber (failover to SMS if undelivered)
    /// </summary>
    [Parameter("ctype")]
    public int Ctype { get; set; } = 1;
}