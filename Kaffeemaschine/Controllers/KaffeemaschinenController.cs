using Microsoft.AspNetCore.Mvc;

namespace Kaffeemaschine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KaffeemaschinenController : ControllerBase
    {

        public static KaffeemaschieneClass kaffemaschine = new KaffeemaschieneClass();
        private readonly ILogger<KaffeemaschinenController> _logger;
        
        public KaffeemaschinenController(ILogger<KaffeemaschinenController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("getWasser")]
        public double GetWasser()
        {
            return kaffemaschine.Wasser;
        }

        [HttpGet]
        [Route("getBohnen")]
        public double GetBohnen()
        {
            return kaffemaschine.Wasser;
        }

        [HttpPost]
        [Route("wasserAuffuellen/{menge:double}")]
        public double SetWasser(double menge)
        {
            kaffemaschine.wasserAuffuellen(menge);
            return kaffemaschine.Wasser;
        }

        [HttpPost]
        [Route("bohnenAuffuellen/{menge:double}")]
        public double SetBohnen(double menge)
        {
            kaffemaschine.bohnenAuffuellen(menge);
            return kaffemaschine.Bohnen;
        }

        [HttpPost]
        [Route("kaffeeMachen/")]
        public bool KaffeeMachen(decimal menge, decimal verhaeltnisWasserBohnen)
        {
            return kaffemaschine.macheKaffee(menge, verhaeltnisWasserBohnen);
        }
    }
}