using FluentAssertions;
using SendSms.Net.Responses;

namespace SendSms.Net.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public async Task Test_Ping()
    {
        var c = new SendSmsClient();
        var r = await c.PingAsync();
        r.Status.Should().Be(ResponseStatusCode.api_result_ok);
    }
}