using Microsoft.Extensions.Options;
using wms_android.data.Models;

namespace wms_android.Services;

public class SmsService
{
    private readonly HttpClient _httpClient;
    private readonly SmsConfiguration _config;
    
    public SmsService(HttpClient httpClient, IOptions<SmsConfiguration> config)
    {
        _httpClient = httpClient;
        _config = config.Value;
        
        System.Diagnostics.Debug.WriteLine($"SmsService Initialized: UserId={_config.UserId}, ApiUrl={_config.ApiUrl}");
    }
    
    public async Task<string> SendSmsAsync(string phoneNumber, string message)
    {
        var payload = new MultipartFormDataContent
        {
            { new StringContent(_config.UserId), "userid" },
            { new StringContent(_config.Password), "password" },
            { new StringContent(phoneNumber), "mobile" },
            { new StringContent(_config.SenderId), "senderid" },
            { new StringContent(message), "msg" },
            { new StringContent("quick"), "sendMethod" },
            { new StringContent("text"), "msgType" },
            { new StringContent("json"), "output" }
        };

        var response = await _httpClient.PostAsync($"{_config.ApiUrl}/send", payload);
        return await response.Content.ReadAsStringAsync();
    }
}