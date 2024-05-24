using Microsoft.AspNetCore.Mvc;

namespace PromotionService.Controllers
{
 
        [ApiController]
        [Route("[controller]")]
        public class ApplierController : ControllerBase
        {
            private readonly ILogger<ApplierController> _logger;

            public ApplierController(ILogger<ApplierController> logger)
            {
                _logger = logger;
            }


            [HttpPost]
            public IActionResult SetPromotion(Code promoCode)
            {
                return Ok($"{promoCode.No} no'lu  {promoCode.Duration} gün süreli promosyon kullanýcý hesabýna tanýmlanmýþtýr");
            }
        }

        public class Code
        {
            public string No { get; set; }
            public int Duration { get; set; }
            public int PlayerId { get; set; }
        }
}
