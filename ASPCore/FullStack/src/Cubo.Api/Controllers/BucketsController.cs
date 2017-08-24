using System.Threading.Tasks;
using Cubo.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cubo.Api.Controllers
{
    [Route("api/[controller]")]
    
    public class BucketsController : Controller
    {
        private readonly IBucketService _bucketService;

        public BucketsController(IBucketService bucketService)
        {
            _bucketService = bucketService;
        }

        [HttpGet("")]
        public async Task<IActionResult> Get()
        {
            var buckets = await _bucketService.GetNamesAsync();

            return Json(buckets);
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> Get(string name)
        {
            var bucket = await _bucketService.GetAsync(name);
            if(bucket == null)
            {
                return NotFound();
            }

            return Json(bucket);
        }
    
        [HttpPost("{name}")]
        public async Task<IActionResult> Post(string name)
        {
            await _bucketService.AddAsync(name);
            
            return Created($"buckets/{name}", null);
        }

        [HttpDelete("{name}")]
        public async Task<IActionResult> Delete(string name)
        {
            await _bucketService.RemoveAsync(name);
            
            return NoContent();
        }
    }
}