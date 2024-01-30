using System;
using SodaIOT.Protocol.Converter;

namespace SodaIOT.Protocol;

public static class IOTConvert
{
    public static IOTProtocolSetting Default = new();

    public static T? Serialize<T>(object? obj, IOTProtocolSetting? setting = null)
    {
        return (setting ?? Default).Converter.Write(obj, typeof(T)) is not T ? default : (T?)obj;
    }

    public static T? Deserialize<T>(object? data, IOTProtocolSetting? setting = null)
    {
        return (T?)(setting ?? Default).Converter.Read(data, typeof(T));
    }
}