using System.ComponentModel.DataAnnotations;
using SendSms.Net.Internal;

namespace SendSms.Net.Requests;

public class RequestBase
{
    /// <summary>
    /// Your log-in username
    /// </summary>
    [Required]
    [Parameter("username")]
    public string UserName { get; internal set; }
    /// <summary>
    /// Your log-in password or API Key
    /// </summary>
    [Required]
    [Parameter("password")]
    public string Password { get; internal set; }
}