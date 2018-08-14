using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HelloWorldAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        readonly ILogger _logger;
        readonly IHelloWorldService _helloWorldService;

        protected HelloWorldController(IHelloWorldService helloWorldService, ILogger logger)
        {
            _helloWorldService = helloWorldService;
            _logger = logger;
        }

        // GET api/HelloWorld
        [HttpGet]
        public string Get()
        {
            return _helloWorldService.RetrieveHelloWorld();
        }
    }
}
