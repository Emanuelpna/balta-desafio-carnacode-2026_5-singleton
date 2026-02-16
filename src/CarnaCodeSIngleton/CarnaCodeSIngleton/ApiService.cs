namespace CarnaCodeSingleton;

public class ApiService
{
    private readonly ConfigurationManager _config;

    public ApiService()
    {
        _config = ConfigurationManager.GetInstance();
    }

    public void MakeRequest()
    {
        var apiKey = _config.GetSetting("ApiKey");
        Console.WriteLine($"[ApiService] Fazendo requisição com API Key: {apiKey}");
    }
}