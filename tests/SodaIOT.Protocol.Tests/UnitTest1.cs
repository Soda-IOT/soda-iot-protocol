namespace SodaIOT.Protocol.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // var setting = new IOTProtocolSetting();
        // setting.Converters.Add(new UserConverter());
        // var protocol = new IOTProtocol(setting);
        // var writer = new ProtocolWriter();
        // var reader = new ProtocolReader();
        // var user = new User("test", 10);
        // protocol.Write(writer, user);
        // var result = protocol.Read<User>(reader);
        // Assert.Equal(user.Name, result.Name);
        // Assert.Equal(user.Age, result.Age);
    }
}

public class User
{
    public string Name { get; set; }
    public int Age { get; set; }

    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }
}