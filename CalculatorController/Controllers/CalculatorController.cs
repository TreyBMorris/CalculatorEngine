using CalculatorEngine;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorController.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CalculatorController : ControllerBase
	{
		private readonly CalculatorEngineMethods engine;
		public CalculatorController(CalculatorEngineMethods calculatorEngineMethods)
		{
			engine = calculatorEngineMethods;
		}

		[HttpGet("add")]
		public IActionResult Add(double firstNumber, double secondNumber)
		{
			var result = CalculatorEngineMethods.Add(firstNumber, secondNumber);
			return Ok(result);
		}

	}
}
