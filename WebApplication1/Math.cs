using Microsoft.AspNetCore.Mvc;

namespace WebApplication1
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] MathInput input)
        {

             double result = 
             input.Oper == "add" ? input.Num1 + input.Num2 :
             input.Oper == "subtract" ? input.Num1 - input.Num2 :
             input.Oper == "multiply" ? input.Num1 * input.Num2 :
             input.Oper == "divide" ? input.Num1 / input.Num2 :
             3.14;
            return Ok(result);

        }

        [HttpPost]
        public IActionResult Post([FromBody] MathInput input)
        {
            if (input != null)
            {
                double result =
                input.Oper == "add" ? input.Num1 + input.Num2 :
                input.Oper == "subtract" ? input.Num1 - input.Num2 :
                input.Oper == "multiply" ? input.Num1 * input.Num2 :
                input.Oper == "divide" ? input.Num1 / input.Num2 :
                3.14;
                return Ok(result);
            }
            else
            {
                return BadRequest("Invalid input provided.");
            }
        }

    }

    public class MathInput
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public required string Oper { get; set; }
    }
}
