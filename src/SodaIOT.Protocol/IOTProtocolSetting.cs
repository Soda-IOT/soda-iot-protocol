using SodaIOT.Protocol.Converter;

namespace SodaIOT.Protocol;

public class IOTProtocolSetting
{
    public IIOTConverter Converter { get; set; } = new EmptyIOTConverter();
}
