using System.Threading.Tasks;
using Cubo.Core.DTO;
using Cubo.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cubo.Api.Controllers
{
    [Route("api/buckets/{bucketName}/items")]
    public class ItemsController : Controller
    {
        private readonly IItemService _itemService;

        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet("")]
        public async Task<IActionResult> Get(string bucketName)
        {
            var items = await _itemService.GetKeysAsync(bucketName);

            return Json(items);
        }

        [HttpGet("{key}")]
        public async Task<IActionResult> Get(string bucketName, string key)
        {
            var item = await _itemService.GetAsync(bucketName, key);
            if(item == null)
            {
                return NotFound();
            }

            return Json(item);
        }

        [HttpPost("")]
        public async Task<IActionResult> Post(string bucketName, [FromBody] ItemDTO item)
        {
            await _itemService.AddAsync(bucketName, item.Key, item.Value);
            
            return Created($"buckets/{bucketName}/items/{item.Key}", null);
        }

        [HttpDelete("{key}")]
        public async Task<IActionResult> Delete(string bucketName, string key)
        {
            await _itemService.RemoveAsync(bucketName, key);
            
            return NoContent();
        }                
    }
}