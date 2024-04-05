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

            var hello = new Hello();

            var response = $"{hello.Greeting}\nHello {hello.Name}";

            try
            {
                return Redirect("~/PosterGetter.html");
            }
            catch
            {
                return Ok(response);
            }
        }
    }
}