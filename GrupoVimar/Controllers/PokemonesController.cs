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

            var pokemones = await _pokeService.GetPokemonsAsync();


            return View(pokemones);
        }
    }
}
