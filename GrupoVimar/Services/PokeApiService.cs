using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using GrupoVimar.ExternalModels;

namespace GrupoVimar.Services
{
    public class PokeApiService
    {
        private readonly HttpClient _httpClient;

        public PokeApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<PokemonItem>> GetPokemonsAsync(int limit = 10)
        {
            var response = await _httpClient.GetAsync($"https://pokeapi.co/api/v2/pokemon?limit={limit}");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                Console.WriteLine("📦 JSON recibido de la API:");
                Console.WriteLine(json); // ← Asegúrate de que se imprima algo aquí

                var result = JsonSerializer.Deserialize<PokemonResponse>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return result.Results;
            }

            return new List<PokemonItem>();
        }
    }

}
