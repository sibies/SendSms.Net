using SendSms.Net.Requests;
using SendSms.Net.Responses;
using System.Text;

namespace SendSms.Net.Internal;

public class JsonHttpClient : HttpClient
{
    public static string MediaType => "application/json";

    protected async Task<T> GetAsync<T>(string uri) where T : ResponseBase
    {
        var response = await GetAsync(new Uri(uri));
        if (!response.IsSuccessStatusCode) return default;
        var result = await response.Content.ReadAsStringAsync();

        return !result.Contains("error")
            ? JsonConverter.Instance.DeserializeObject<T>(result)
            : default;
    }

    private async Task<IEnumerable<T>> GetListAsync<T>(string uri)
    {
        var response = await GetAsync(new Uri(uri));

        if (!response.IsSuccessStatusCode) return Enumerable.Empty<T>();
        var result = await response.Content.ReadAsStringAsync();

        return !result.Contains("error")
            ? JsonConverter.Instance.DeserializeObject<List<T>>(result)
            : Enumerable.Empty<T>();
    }

    private async Task<TR> PostAsync<T, TR>(string uri, T data) where T: RequestBase where TR : ResponseBase
    {
        var content = new StringContent(JsonConverter.Instance.SerializeObject(data), Encoding.UTF8, MediaType);

        var response = await PostAsync(new Uri(uri), content);
        if (!response.IsSuccessStatusCode) return default;

        var result = await response.Content.ReadAsStringAsync();
        if (result.Contains("error")) return default;

        var output = JsonConverter.Instance.DeserializeObject<TR>(result);
        return output;
    }
}