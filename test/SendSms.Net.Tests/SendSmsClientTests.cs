using FluentAssertions;
using SendSms.Net.Requests;
using SendSms.Net.Responses;

namespace SendSms.Net.Tests;

[TestClass]
public class SendSmsClientTests
{
    [TestMethod]
    public async Task Test_Ping()
    {
        var client = new SendSmsClient();
        var response = await client.PingAsync();
        response.Status.Should().Be(ResponseStatusCode.api_result_ok);
    }


    [TestMethod]
    public async Task Test_SendMessage()
    {
        var client = new SendSmsClient();
        var request = new SendMessageRequest
        {
            To = "",
            Text = "test"
        };

        var response = await client.SendMessageAsync(request);
        response.Status.Should().Be(ResponseStatusCode.api_result_ok);
    }
}