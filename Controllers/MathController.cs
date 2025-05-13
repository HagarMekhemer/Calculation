using Microsoft.AspNetCore.Mvc;
using Calculation.DSL;
using Microsoft.Extensions.Logging;

namespace Calculation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        private readonly IMathApiClientService _apiClient;
        private readonly ILogger<MathController> _logger;

        public MathController(
            IMathApiClientService apiClient,
            ILogger<MathController> logger)
        {
            _apiClient = apiClient;
            _logger = logger;
        }

        [HttpGet("add")]
        public IActionResult Add([FromQuery] int number1, [FromQuery] int number2)
        {
            _logger.LogInformation($"Controller: Received ADD request");
            var result = _apiClient.Add(number1, number2);
            return Ok(result);
        }

        [HttpGet("subtract")]
        public IActionResult Subtract([FromQuery] int number1, [FromQuery] int number2)
        {
            _logger.LogInformation($"Controller: Received SUBTRACT request");
            var result = _apiClient.Subtract(number1, number2);
            return Ok(result);
        }
    }
}
