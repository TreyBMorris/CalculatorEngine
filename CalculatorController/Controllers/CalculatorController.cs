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

		/// <summary>
		/// Does Addition
		/// </summary>
		[HttpPost("add")]
		public IActionResult Add([FromBody] CalculationRequest request)
		{
			var result = engine.Add(request.FirstNumber, request.SecondNumber);
			return Ok(result);
		}

		/// <summary>
		/// Does Subtraction
		/// </summary>
		[HttpPost("subtract")]
		public IActionResult Subtract([FromBody] CalculationRequest request)
		{
			var result = engine.Subtract(request.FirstNumber, request.SecondNumber);
			return Ok(result);
		}


		/// <summary>
		/// Does Multiplication
		/// </summary>
		[HttpPost("multiply")]
		public IActionResult Multiply([FromBody] CalculationRequest request)
		{
			var result = engine.Multiply(request.FirstNumber, request.SecondNumber);
			return Ok(result);
		}


		/// <summary>
		/// Does Division
		/// </summary>
		[HttpPost("divide")]
		public IActionResult Divide([FromBody] CalculationRequest request)
		{
			var result = engine.Divide(request.FirstNumber, request.SecondNumber);
			return Ok(result);
		}

		/// <summary>
		/// Gets the power to the nth of a number
		/// </summary>
		[HttpPost("power")]
		public IActionResult Power([FromBody] CalculationRequest request)
		{
			var result = engine.Power(request.FirstNumber, request.SecondNumber);
			return Ok(result);
		}

		/// <summary>
		/// Gets the logarithm 
		/// </summary>
		[HttpPost("logarithm")]
		public IActionResult Logarithm([FromBody] CalculationRequest request)
		{
			var result = engine.Logarithm(request.FirstNumber, request.SecondNumber);
			return Ok(result);
		}

		/// <summary>
		/// Gets the nth root of a number
		/// </summary>
		[HttpPost("root")]
		public IActionResult Root([FromBody] CalculationRequest request)
		{
			var result = engine.Root(request.FirstNumber, request.SecondNumber);
			return Ok(result);
		}
		/// <summary>
		/// Gets the factorial of a number
		/// </summary>
		[HttpPost("factorial")]
		public IActionResult Factorial([FromBody] CalculationRequest request)
		{
			var result = engine.Factorial(request.FirstNumber);
			return Ok(result);
		}

		/// <summary>
		/// Gets the reciprocal of a number
		/// </summary>
		[HttpPost("reciprocal")]
		public IActionResult Reciprocal([FromBody] CalculationRequest request)
		{
			var result = engine.Reciprocal(request.FirstNumber);
			return Ok(result);
		}
	}
}