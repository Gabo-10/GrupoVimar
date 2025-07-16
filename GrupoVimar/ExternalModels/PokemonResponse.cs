using System.Collections.Generic;

namespace GrupoVimar.ExternalModels
{
    public class PokemonResponse
    {
        public  List<PokemonItem> Results { get; set; }
    }

    public class PokemonItem
    {
        public string  Name { get; set; }
        public string Url { get; set; }

        public int Id
        {
            get
            {
                var parts = Url.TrimEnd('/').Split('/');
                return int.Parse(parts.Last());
            }
        }
        public string ImageUrl => $"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/{Id}.png";
    }
}
