using SendSms.Net.Internal;

namespace SendSms.Net.Extensions;

public static class StringExtensions
{
    public static KeyValuePair<string, string>? ToParameter(this string value)
    {
        var fi = value.GetType().GetField(value);

        if (fi != null && fi.GetCustomAttributes(typeof(ParameterAttribute), false) is ParameterAttribute[] attributes && attributes.Any())
        {
            return new KeyValuePair<string, string>(attributes.First().Name, value);
        }

        return null;
    }

    public static Dictionary<string, string> ToParameters(this object obj)
    {
        if (obj == null) return new Dictionary<string, string>();

        var t = obj.GetType();
        var props = t.GetProperties();

        var dict = new Dictionary<string, string>();
        foreach (var prp in props)
        {
            if (prp.GetCustomAttributes(typeof(ParameterAttribute), false) is not ParameterAttribute[] attributes ||
                !attributes.Any()) continue;
            var value = prp.GetValue(obj, new object[] { });
            if (value != null)
            {
                dict.Add(attributes.First().Name, value.ToString());
            }
        }
        return dict;

    }
}