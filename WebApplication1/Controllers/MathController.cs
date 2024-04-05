using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Requests;

namespace WebApplication1;

[ApiController]
[Route("api/[controller]")] // Update route to have api in it. Helps distinguish between MVC and API controllers
public class MathController : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] MathInput input)
    {
        // still could check in get if this is null. we also check for null first bc if it is we can get out quickly and no need for a nesting. basically meaning we get rid of an else.
        // TODO: Move this logic for math stuff into its own service. You could go either purely functional or make a calculator object that has the math operations as methods.
        if (input is null)
            return BadRequest("Invalid input provided.");

        var result = input.Operation switch
        {
            "add" => input.Num1 + input.Num2,
            "subtract" => input.Num1 - input.Num2,
            "multiply" => input.Num1 * input.Num2,
            "divide" => input.Num1 / input.Num2,
            _ => throw new ArgumentException("Invalid operation provided. Have some pi instead. 🥧")
        };
        return Ok(result);
    }

    [HttpPost]
    public IActionResult Post([FromBody] MathInput input)
    {
        if (input is null)
            return BadRequest("Invalid input provided.");

        var result = input.Operation switch
        {
            "add" => input.Num1 + input.Num2,
            "subtract" => input.Num1 - input.Num2,
            "multiply" => input.Num1 * input.Num2,
            "divide" => input.Num1 / input.Num2,
            _ => throw new ArgumentException("Invalid operation provided. Have some pi instead. 🥧")
        };

        return Ok(result);
    }
}
