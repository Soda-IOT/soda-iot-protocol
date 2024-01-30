using Newtonsoft.Json;
using SodaIOT.Protocol.Converter;

namespace SodaIOT.Protocol.Json;

public class JsonProtocolConverter : IIOTConverter
{
    public object? Read(object? value, Type objectType)
    {
        return JsonConvert.SerializeObject(value);
    }

    public object? Write(object? value, Type objectType)
    {
        if (value is string jsonString)
        {
            return JsonConvert.DeserializeObject(jsonString, objectType);
        }
        throw new ArgumentException("value is not a json string");
    }
}
