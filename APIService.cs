using global::Calculation.DSL;
using Microsoft.Extensions.Logging;

    namespace Calculation.DSL
    {
        public interface IMathApiClientService
        {
            int Add(int number1, int number2);
            int Subtract(int number1, int number2);
        }

        public class MathApiClientService : IMathApiClientService
        {
            private readonly AddService _addService;
            private readonly SubtractService _subtractService;
            private readonly ILogger<MathApiClientService> _logger;

            public MathApiClientService(
                AddService addService,
                SubtractService subtractService,
                ILogger<MathApiClientService> logger)
            {
                _addService = addService;
                _subtractService = subtractService;
                _logger = logger;
            }

            public int Add(int number1, int number2)
            {
                _logger.LogInformation($"API Client: Adding {number1} and {number2}");
                var result = _addService.Add(number1, number2);
                _logger.LogInformation($"API Client: Result = {result}");
                return result;
            }

            public int Subtract(int number1, int number2)
            {
                _logger.LogInformation($"API Client: Subtracting {number2} from {number1}");
                var result = _subtractService.Subtract(number1, number2);
                _logger.LogInformation($"API Client: Result = {result}");
                return result;
            }
    }
}

