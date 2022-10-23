
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace project.Controllers
{
    [Route("[controller]")]
    public class Movies : Controller
    {
        private readonly ILogger<Movies> _logger;

        public Movies(ILogger<Movies> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}