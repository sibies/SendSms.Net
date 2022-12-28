namespace SendSms.Net;

/// <summary>
/// https://www.sendsms.ro/How_to_create_API_Keys_in_sendSMS.pdf
/// </summary>
public class SendSmsConfigurations
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string From { get; set; }
    public bool Simulation { get; set; }
    public string SimulationPhone { get; set; }
}