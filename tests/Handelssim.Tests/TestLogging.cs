using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Logging;
public static class TestLogging
{
    public static ILogger<T> CreateLogger<T>()
    {
        var factory = LoggerFactory.Create(builder => builder.AddConsole());
        return factory.CreateLogger<T>();
    }
}