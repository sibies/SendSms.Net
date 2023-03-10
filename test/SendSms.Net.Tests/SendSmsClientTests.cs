using FluentAssertions;
using SendSms.Net.Contracts;
using SendSms.Net.Requests;
using SendSms.Net.Responses;
using Xunit;

namespace SendSms.Net.Tests;


public class SendSmsClientTests
{
    private readonly ISendSmsClient _client;

    public SendSmsClientTests()
    {
        var config = new SendSmsConfigurations
        {
            Username = "",
            Password = "",
        };
        _client = new SendSmsClient(config);
    }
    [Fact]
    public async Task Test_Ping()
    {
        var response = await _client.PingAsync();
        response.Status.Should().Be(ResponseStatusCode.api_result_ok);
    }

    [Fact]
    public async Task Test_SendMessage()
    {
        var request = new SendMessageRequest
        {
            To = "",
            Text = "Sibies Soft"
        };

        var response = await _client.SendMessageAsync(request);
        response.Status.Should().Be(ResponseStatusCode.api_result_ok);
    }
}