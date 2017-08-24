using System;
using System.Linq;
using Accountant.Api.Filters;
using Accountant.Api.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Accountant.Api.Controllers
{
    [Route("[controller]")]
    [ExceptionHandler]
    public class UsersController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger _logger;
        
        public UsersController(IUserRepository userRepository,
            ILogger<UsersController> logger)
        {
            _userRepository = userRepository;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        => Json(_userRepository.GetAll().Select(x => x.Name));

        [HttpGet("{name}")]
        public IActionResult Get(string name)
        {
            throw new Exception("Ooops...");
            _logger.LogInformation($"Fetch user by name: {name}.");
            var user = _userRepository.Get(name);
            if(user == null)
            {
                return NotFound();
            }

            return Json(user);
        }
    }
}