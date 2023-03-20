using Microsoft.AspNetCore.Mvc;

namespace MultiMediaApi.Controllers
{
    public class MultiMediaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
