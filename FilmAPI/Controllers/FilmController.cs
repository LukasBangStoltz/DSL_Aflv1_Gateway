using FilmAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class FilmController : ControllerBase
    {
        private static readonly List<Film> Films = new List<Film>
        {
            new Film{Id = 1, FilmName = "Tarzan"},
            new Film{Id = 2, FilmName = "Toy Story"},
            new Film{Id = 3, FilmName = "Bjørne Brødrene"}
        };

        private readonly ILogger<FilmController> _logger;

        public FilmController(ILogger<FilmController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetFilms")]
        public List<Film> Get()
        {
            return Films;
        }
    }
}