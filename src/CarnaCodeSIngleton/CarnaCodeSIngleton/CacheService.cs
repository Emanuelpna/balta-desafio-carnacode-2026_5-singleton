namespace CarnaCodeSingleton;

public class CacheService
{
    private readonly ConfigurationManager _config;

    public CacheService()
    {
        // Problema: Mais uma instância duplicada
        _config = ConfigurationManager.GetInstance();
    }

    public void Connect()
    {
        var cacheServer = _config.GetSetting("CacheServer");
        Console.WriteLine($"[CacheService] Conectando ao cache: {cacheServer}");
    }
}