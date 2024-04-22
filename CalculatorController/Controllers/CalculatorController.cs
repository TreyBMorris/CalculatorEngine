using CalculatorController.Model;
using CalculatorEngine;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorController.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CalculatorController : ControllerBase
	{
		private readonly ICalculatorEngineMethods engine;
		public CalculatorController(ICalculatorEngineMethods calculatorEngineMethods)
		{
			engine = calculatorEngineMethods;
		}

		[HttpPost("add")]
		public IActionResult Add([FromBody] CalculationRequest request)
		{
			var result = engine.Add(request.FirstNumber, request.SecondNumber);
			return Ok(result);
		}

		[HttpPost("subtract")]
		public IActionResult Subtract([FromBody] CalculationRequest request)
		{
			var result = engine.Subtract(request.FirstNumber, request.SecondNumber);
			return Ok(result);
		}

		[HttpPost("multiply")]
		public IActionResult Multiply([FromBody] CalculationRequest request)
		{
			var result = engine.Multiply(request.FirstNumber, request.SecondNumber);
			return Ok(result);
		}

		[HttpPost("divide")]
		public IActionResult Divide([FromBody] CalculationRequest request)
		{
			var result = engine.Divide(request.FirstNumber, request.SecondNumber);
			return Ok(result);
		}

		[HttpPost("power")]
		public IActionResult Power([FromBody] CalculationRequest request)
		{
			var result = engine.Power(request.FirstNumber, request.SecondNumber);
			return Ok(result);
		}

		[HttpPost("logarithm")]
		public IActionResult Logarithm([FromBody] CalculationRequest request)
		{
			var result = engine.Logarithm(request.FirstNumber, request.SecondNumber);
			return Ok(result);
		}

		[HttpPost("root")]
		public IActionResult Root([FromBody] CalculationRequest request)
		{
			var result = engine.Root(request.FirstNumber, request.SecondNumber);
			return Ok(result);
		}

		[HttpPost("factorial")]
		public IActionResult Factorial([FromBody] CalculationRequest request)
		{
			var result = engine.Factorial(request.FirstNumber);
			return Ok(result);
		}

		[HttpPost("reciprocal")]
		public IActionResult Reciprocal([FromBody] CalculationRequest request)
		{
			var result = engine.Reciprocal(request.FirstNumber);
			return Ok(result);
		}
	}
}