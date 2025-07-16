using GrupoVimar.ExternalModels;
using GrupoVimar.Services;
using Microsoft.AspNetCore.Mvc;

namespace GrupoVimar.Controllers
{
    public class PokemonesController : Controller
    {
        private readonly PokeApiService _pokeService;

        public PokemonesController(PokeApiService pokeService)
        {
            _pokeService = pokeService;
        }

        public async Task<IActionResult> Index()
        {
            Console.WriteLine("🔍 Entrando a PokemonesController.Index");

            var pokemones = await _pokeService.GetPokemonsAsync();

            Console.WriteLine($"🐱‍👤 Número de pokemones recibidos: {pokemones.Count}");

            return View(pokemones);
        }
    }
}
