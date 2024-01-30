using System;
using SodaIOT.Protocol.Core;

namespace SodaIOT.Protocol.Converter;


public abstract class DefaultIOTConverter : IIOTConverter
{
    public abstract object? Read(object? value, Type objectType);

    public abstract object? Write(object? value, Type objectType);
}

internal class EmptyIOTConverter : IIOTConverter
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