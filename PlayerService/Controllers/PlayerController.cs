using Microsoft.AspNetCore.Mvc;

namespace PlayerService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
    
        private readonly ILogger<PlayerController> _logger;

        public PlayerController(ILogger<PlayerController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public Player Get(string id)
        {
            return new Player
            {
                Id = id,
                Fullname = "Test Testoglu",
                Rank = 5,
                BetCount = 122,
                BetWon = 55,
            };
        }
    }

    public class Player
    {
        public string Id { get; set; }
        public string? Fullname { get; set; }
        public int Rank { get; set; }
        public int BetCount { get; set; }
        public int BetWon { get; set; }
    }
}
