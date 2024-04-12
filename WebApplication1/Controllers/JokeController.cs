using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Requests;


namespace WebApplication1;

[ApiController]
[Route("[Controller]")]

public class JokeController : ControllerBase
{
    //Put this originally, as was autofilled for other controller, removed because im not actually grabbing anything. I think.
    //[HttpGet]
    public IActionResult Get()
    {
        var joke = new JokeInput();
        var response = joke;
        return Ok(response);
    }


}

