using Microsoft.AspNetCore.Mvc;

namespace MultiMediaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MultiMediaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPut("uploadfile/{file}")]
        public async Task<string> UploadFile(IFormFile file)
        {

            return "";
        }

    }
}
