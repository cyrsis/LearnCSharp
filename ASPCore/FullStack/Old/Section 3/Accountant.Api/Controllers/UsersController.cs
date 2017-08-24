using System;
using System.Linq;
using Accountant.Api.Filters;
using Accountant.Api.Models;
using Accountant.Api.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Accountant.Api.Controllers
{
    [Route("[controller]")]
    [ExceptionHandler]
    public class UsersController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IDistributedCache _cache;
        private readonly ILogger _logger;
        
        public UsersController(IUserRepository userRepository,
            IDistributedCache cache,
            ILogger<UsersController> logger)
        {
            _userRepository = userRepository;
            _cache = cache;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        => Json(_userRepository.GetAll().Select(x => x.Name));

        [HttpGet("{name}")]
        public IActionResult Get(string name)
        {
            User user = null;
            var key = $"user-{name}";
            _logger.LogInformation($"Fetch user by name: {name}.");
            var userString = _cache.GetString(key);
            if(userString == null)
            {
                _logger.LogInformation($"User {name} was not found in Redis cache.");
                user = _userRepository.Get(name);
                _cache.SetString(key, JsonConvert.SerializeObject(user), new DistributedCacheEntryOptions
                {
                    SlidingExpiration = TimeSpan.FromSeconds(10)
                });
            }
            else
            {
                user = JsonConvert.DeserializeObject<User>(userString);
                _logger.LogInformation($"User {name} was found in Redis cache.");
            }
            if(user == null)
            {
                return NotFound();
            }

            return Json(user);
        }
    }
}