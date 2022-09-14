using Microsoft.AspNetCore.Mvc;
using RatingAPI.Models;

namespace RatingAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class RatingController : ControllerBase
    {
        public static readonly List<Rating> Ratings = new List<Rating>
        {
            new Rating{Id = 1, FilmRating = "8.3"},
            new Rating{Id = 2, FilmRating = "8.0"},
            new Rating{Id = 2, FilmRating = "7.8"}
        };

        private readonly ILogger<RatingController> _logger;

        public RatingController(ILogger<RatingController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetRatings")]
        public List<Rating> Get()
        {
            return Ratings;
        }
    }
}