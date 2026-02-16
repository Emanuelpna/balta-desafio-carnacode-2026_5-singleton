namespace CarnaCodeSingleton;

public class DatabaseService
{
    private readonly ConfigurationManager _config;

    public DatabaseService()
    {
        _config = ConfigurationManager.GetInstance();
    }

    public void Connect()
    {
        var connectionString = _config.GetSetting("DatabaseConnection");
        Console.WriteLine($"[DatabaseService] Conectando ao banco: {connectionString}");
    }
}