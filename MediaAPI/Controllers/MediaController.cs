using Microsoft.AspNetCore.Mvc;

namespace MediaAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MediaController : Controller
    {
      [HttpPut("uploadfile/{file}")]
        public async Task<string> UploadFile(IFormFile file)
        {

            return "jfdsfoij hiofsiuofuohuiofsbuishfsfgfdngdvgfdvgbfd";
        }
    }
}
