using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {

            var hello = new Hello
            {

                Greeting = "Hello World",

                Name = "Buddy"

            };

            var response = $"{hello.Greeting}\nHello {hello.Name}";

            return Ok(response);
        }
    }
}