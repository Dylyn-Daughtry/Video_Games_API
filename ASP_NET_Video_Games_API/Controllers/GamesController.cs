using ASP_NET_Video_Games_API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Video_Games_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GamesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetGames()
        {
            var videoGames = _context.VideoGames.ToList();


            return Ok(videoGames);
        }
        [HttpGet("{id}")] 
        public IActionResult GetGameByID(int id)
        {
            var videoGame = _context.VideoGames.Where(vg => vg.Id == id).FirstOrDefault();
            return Ok(videoGame);
        }

    }
}
