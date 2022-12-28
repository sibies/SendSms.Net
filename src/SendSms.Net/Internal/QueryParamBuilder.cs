using System.Web;

namespace SendSms.Net.Internal;

public class QueryParamBuilder
{
    private readonly Dictionary<string, string> _fields = new();

    public QueryParamBuilder()
        : this(new Dictionary<string, string>())
    {
    }

    public QueryParamBuilder(Dictionary<string, string> fields)
    {
        _fields = fields;
    }
    public QueryParamBuilder Add(string key, string value)
    {
        _fields.Add(key, value);
        return this;
    }
    public string Build()
    {
        return $"&{string.Join("&", _fields.Select(pair => $"{HttpUtility.UrlEncode(pair.Key)}={HttpUtility.UrlEncode(pair.Value)}"))}";
    }
    public static QueryParamBuilder New => new();
}