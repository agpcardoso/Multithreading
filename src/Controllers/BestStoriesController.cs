using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SantanderTest.Services;

namespace SantanderTest.Controllers
{
    [ApiController]
    [Route("api/beststories")]
    public class BestStoriesController : ControllerBase
    {
        private readonly IBestStoriesService _service;


        public BestStoriesController(IBestStoriesService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<IActionResult> GetBestStories([FromQuery] int amount = 10)
        {
            if (amount <= 0) return BadRequest("amount must be greater than 0");
            var result = await _service.GetBestStoriesAsync(amount);
            return Ok(result);
        }
    }
}
