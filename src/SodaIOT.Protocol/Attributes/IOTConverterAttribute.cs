using System;
using SodaIOT.Protocol.Converter;
using SodaIOT.Protocol.Core;

namespace SodaIOT.Protocol.Attributes;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public abstract class IOTConverterAttribute : Attribute, IIOTConverter
{

    public object? Read(object? value, Type objectType)
    {
        throw new NotImplementedException();
    }

    public object? Write(object? value, Type objectType)
    {
        throw new NotImplementedException();
    }
}