using Microsoft.AspNetCore.Mvc;
using WebApplication1.calculator;
using WebApplication1.Models.Requests;

namespace WebApplication1;

[ApiController]
[Route("api/[controller]")] // Update route to have api in it. Helps distinguish between MVC and API controllers
// renamed to MathController. We follow the scheme of {Entity}Controller.
public class MathController(Calculation calculator) : ControllerBase
{
    private readonly Calculation _calculator = calculator;

    [HttpGet]
    public IActionResult Get([FromQuery] MathInput input)
    {
        // still could check in get if this is null. we also check for null first bc if it is we can get out quickly and no need for a nesting. basically meaning we get rid of an else.
        // TODO: Move this logic for math stuff into its own service. You could go either purely functional or make a calculator object that has the math operations as methods.
        if (input is null)
            return BadRequest("Invalid input provided.");

        if (input.Number1 == 69 && input.Number2 == 420)
            return Redirect($"~/Joke");

        //returns to html with result tacked onto end for use by html
        var result = _calculator.Calculate(input.Operation, input.Number1, input.Number2);
        return Redirect($"~/PosterGetter.html?result={result}");
    }


    [HttpPost]
    public IActionResult Post([FromBody] MathInput input)
    {
        if (input is null)
            return BadRequest("Invalid input provided.");

        var result = _calculator.Calculate(input.Operation, input.Number1, input.Number2);

        return Ok(result);
    }
}
