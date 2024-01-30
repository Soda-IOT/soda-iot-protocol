using System;
using SodaIOT.Protocol.Core;

namespace SodaIOT.Protocol.Converter;

public interface IIOTConverter
{
    public object? Read(object? value, Type objectType);
    public object? Write(object? value, Type objectType);
}