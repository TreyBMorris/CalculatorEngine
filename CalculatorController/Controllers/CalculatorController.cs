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

		[HttpGet("add")]
		public IActionResult Add(double firstNumber, double secondNumber)
		{
			var result = engine.Add(firstNumber, secondNumber);
			return Ok(result);
		}

		[HttpGet("subtract")]
		public IActionResult Subtract(double firstNumber, double secondNumber)
		{
			var result = engine.Subtract(firstNumber, secondNumber);
			return Ok(result);
		}

		[HttpGet("multiply")]
		public IActionResult Multiply(double firstNumber, double secondNumber)
		{
			var result = engine.Multiply(firstNumber, secondNumber);
			return Ok(result);
		}

		[HttpGet("divide")]
		public IActionResult Divide(double firstNumber, double secondNumber)
		{
			var result = engine.Divide(firstNumber, secondNumber);
			return Ok(result);
		}

		[HttpGet("power")]
		public IActionResult Power(double firstNumber, double secondNumber)
		{
			var result = engine.Power(firstNumber, secondNumber);
			return Ok(result);
		}

		[HttpGet("logarithm")]
		public IActionResult Logarithm(double firstNumber, double secondNumber)
		{
			var result = engine.Logarithm(firstNumber, secondNumber);
			return Ok(result);
		}

		[HttpGet("root")]
		public IActionResult Root(double firstNumber, double secondNumber)
		{
			var result = engine.Root(firstNumber, secondNumber);
			return Ok(result);
		}

		[HttpGet("factorial")]
		public IActionResult Factorial(double firstNumber)
		{
			var result = engine.Factorial(firstNumber);
			return Ok(result);
		}

		[HttpGet("reciprocal")]
		public IActionResult Reciprocal(double firstNumber)
		{
			var result = engine.Reciprocal(firstNumber);
			return Ok(result);
		}
	}
}