using System.Net.Http;

namespace AmazingEndemicSpeciesApi
{
    public class AmazingEndemicSpecies
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://aes.shenlu.me/api/v1/";
        public AmazingEndemicSpecies()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> GetRandomSpecies()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/random");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetAllSpecies()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/species");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetSpeciesCount()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/count");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetCountry()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/country");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetCountryCount()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/country/count");
            return await response.Content.ReadAsStringAsync();
        }
      
        public async Task<string> GetApiVersion()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/version");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
