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

        public async Task<List<PokemonItem>> GetPokemonsAsync(int limit = 12)
        {
            var response = await _httpClient.GetAsync($"https://pokeapi.co/api/v2/pokemon?limit={limit}");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                

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
