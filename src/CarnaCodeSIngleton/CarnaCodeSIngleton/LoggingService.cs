namespace CarnaCodeSingleton;

public class LoggingService
{
    private readonly ConfigurationManager _config;

    public LoggingService()
    {
        _config = ConfigurationManager.GetInstance();
    }

    public void Log(string message)
    {
        var logLevel = _config.GetSetting("LogLevel");
        Console.WriteLine($"[LoggingService] [{logLevel}] {message}");
    }
}