using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Requests;
namespace WebApplication1.Controllers;

    [ApiController]
    // we did not put the api part here as this is a controller that is not an API controller. It is a controller that returns a view.
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var hello = new HelloWorldInput();
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
