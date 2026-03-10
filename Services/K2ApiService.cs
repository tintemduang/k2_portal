using System.Text;
using System.Text.Json;
using K2Portal.Models;

namespace K2Portal.Services
{
    public class K2ApiService
    {
        private readonly HttpClient _httpClient;

        public K2ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("x-api-key", "abe341ac13b245b793b0fae755de773c");
        }

        public async Task<List<K2WorklistItem>> GetWorklist(string username)
        {
            var body = new
            {
                imperSonateUsername = username
            };

            var json = JsonSerializer.Serialize(body);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(
                "https://k2-app-prod.srisawadpower.com/Frappe_API/api/K2ProcessAPI/getworklist",
                content
            );

            if (!response.IsSuccessStatusCode)
            {
                return new List<K2WorklistItem>();
            }

            var result = await response.Content.ReadAsStringAsync();

            var worklist = JsonSerializer.Deserialize<List<K2WorklistItem>>(result,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            return worklist ?? new List<K2WorklistItem>();
        }
    }
}