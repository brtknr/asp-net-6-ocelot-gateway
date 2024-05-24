using Microsoft.AspNetCore.Mvc;

namespace BetService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BetController : ControllerBase
    {
        private readonly ILogger<BetController> _logger;

        public BetController(ILogger<BetController> logger)
        {
            _logger = logger;
        }

        [HttpGet("suggestions/{id}")]
        public IEnumerable<Bet> Get(string id)
        {
            var bets = new List<Bet>{
                new(){Id=1,HomeTeam = "BAR",AwayTeam = "RMA",Choice = "OVER 2,5" , Odd = 1.55},
                new(){Id=2,HomeTeam = "CHE",AwayTeam = "WHU",Choice = "UNDER 2,5" , Odd = 1.95},
                new(){Id=3,HomeTeam = "MCI",AwayTeam = "MIL",Choice = "1X2 1" , Odd = 1.30},
            };

            return bets;
        }

    }

    public class Bet
    {
        public int Id { get; set; }
        public string HomeTeam  { get; set; }
        public string AwayTeam { get; set; }
        public string Choice { get; set; }
        public double Odd { get; set; }
    }
}
