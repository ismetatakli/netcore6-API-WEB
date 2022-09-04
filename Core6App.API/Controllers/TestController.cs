using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core6App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = new List<int> { 1, 2, 3 };
            return Ok(data);
        }
    }
}
