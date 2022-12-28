namespace SendSms.Net.Internal;

[AttributeUsage(AttributeTargets.Property)]
public class ParameterAttribute : Attribute
{
    public ParameterAttribute(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

}