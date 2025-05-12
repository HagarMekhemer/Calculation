using Microsoft.AspNetCore.Mvc;
using Calculation.DSL;

namespace Calculation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        private readonly AddService _addService;
        private readonly SubtractService _subtractService;

        public MathController(AddService addService, SubtractService subtractService)
        {
            _addService = addService;
            _subtractService = subtractService;
        }

        // Endpoint for Addition
        [HttpGet("add")]
        public IActionResult Add([FromQuery] int number1, [FromQuery] int number2)
        {
            var result = number1 + number2;
            return Ok(result); // Return the sum
        }

        // Endpoint for Subtraction
        [HttpGet("subtract")]
        public IActionResult Subtract([FromQuery] int number1, [FromQuery] int number2)
        {
            var result = number1 - number2;
            return Ok(result); // Return the difference
        }
    }
}
