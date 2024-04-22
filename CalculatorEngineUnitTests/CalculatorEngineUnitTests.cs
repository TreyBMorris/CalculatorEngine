using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalculatorEngineUnitTests
{
	public class CalculatorEngineUnitTests
	{
		private ICalculatorEngineMethods _calculator;

		[SetUp]
		public void Setup()
		{
			_calculator = new CalculatorEngineMethods();
		}

		[Test]
		public void CalculatorEngine_AddTwoFloatingPoints_ReturnsSum()
		{
			//Arrange
			double firstNumber = 5.5;
			double secondNumber = -3.15;
			double Expected = 2.35;

			//Act
			CalculationResult result = _calculator.Add(firstNumber, secondNumber);

			//Assert
			Assert.That(result.Result.Equals(Expected));
			Assert.That(result.IsSuccess.Equals(true));
		}

		[Test]
		public void CalculatorEngine_SubtractTwoFloatingPoints_ReturnsDifference()
		{
			double firstNumber = 27.93;
			double secondNumber = 4.0;
			double Expected = 23.93;

			CalculationResult result = _calculator.Subtract(firstNumber, secondNumber);

			Assert.That(result.Result.Equals(Expected));
			Assert.That(result.IsSuccess.Equals(true));
		}

		[Test]
		public void CalculatorEngine_MultiplyTwoFloatingPoints_ReturnsProduct()
		{
			double firstNumber = 5.0;
			double secondNumber = 7.1;
			double Expected = 35.5;

			CalculationResult result = _calculator.Multiply(firstNumber, secondNumber);

			Assert.That(result.Result.Equals(Expected));
			Assert.That(result.IsSuccess.Equals(true));
		}

		[Test]
		public void CalculatorEngine_DivideTwoFloatingPoints_ReturnsQuotient()
		{
			double firstNumber = 3.0;
			double secondNumber = 9.0;
			double Expected = 3.0 / 9.0;

			CalculationResult result = _calculator.Divide(firstNumber, secondNumber);

			Assert.That(result.Result.Equals(Expected));
			Assert.That(result.IsSuccess.Equals(true));
		}

		[Test]
		public void CalculatorEngine_DivideByZero_ThrowsException()
		{
			double firstNumber = 3.0;
			double secondNumber = 0.0;
			string Error = "Not a number";

			CalculationResult result = _calculator.Divide(firstNumber, secondNumber);
			
			Assert.That(result.Result.Equals(0.0));
			Assert.That(result.Error.Equals(Error));
			Assert.That(result.IsSuccess.Equals(false));
		}

		[Test]
		public void CalculatorEngine_RaiseToPower_TwoFloatingPointNumbers()
		{
			double firstNumber = 2.0;
			double secondNumber = 3.0;
			double Expected = 8.0;

			CalculationResult result = _calculator.Power(firstNumber, secondNumber);

			Assert.That(result.Result.Equals(Expected));
			Assert.That(result.IsSuccess.Equals(true));

		}

		[Test]
		public void CalculatorEngine_LogarithmOf_TwoFloatingPointNumbers()
		{
			double firstNumber = 8.0;
			double secondNumber = 2.0;
			double Expected = 3.0;
			string Error = "";

			CalculationResult result = _calculator.Logarithm(firstNumber, secondNumber);

			Assert.That(result.Result.Equals(Expected));
			Assert.That(result.Error.Equals(Error));
			Assert.That(result.IsSuccess.Equals(true));
		}

		[Test]
		public void CalculatorEngine_Logarithm_WhereBaseAIsZero_ThrowsError()
		{
			double firstNumber = 0.0;
			double secondNumber = 2.0;
			string Error = "First number cannot be less than or equal to zero";

			CalculationResult result = _calculator.Logarithm(firstNumber, secondNumber);

			Assert.That(result.Result.Equals(0.0));
			Assert.That(result.Error.Equals(Error));
			Assert.That(result.IsSuccess.Equals(false));
		}

		[Test]
		public void CalculatorEngine_Logarithm_WhereBaseB_isZero_ThrowsError()
		{
			double firstNumber = 8.0;
			double secondNumber = 0.0;
			string Error = "Second number cannot be Zero";

			CalculationResult result = _calculator.Logarithm(firstNumber, secondNumber);

			Assert.That(result.Result.Equals(0.0));
			Assert.That(result.Error.Equals(Error));
			Assert.That(result.IsSuccess.Equals(false));
		}

		[Test]
		public void CalculatorEngine_NthRoot_OfTwoFloatingPointNumbers()
		{
			double firstNumber = 8.0;
			double secondNumber = 3.0;
			double Expected = 2.0;
			string Error = "";

			CalculationResult result = _calculator.Root(firstNumber, secondNumber);

			Assert.That(result.Result.Equals(Expected));
			Assert.That(result.Error.Equals(Error));
			Assert.That(result.IsSuccess.Equals(true));
		}

		[Test]
		public void CalculatorEngine_Root_WhereRootIsZero_ThrowsError()
		{
			double firstNumber = 8.0;
			double secondNumber = 0.0;
			string Error = "Second number cannot be zero";

			CalculationResult result = _calculator.Root(firstNumber, secondNumber);

			Assert.That(result.Result.Equals(0.0));
			Assert.That(result.Error.Equals(Error));
			Assert.That(result.IsSuccess.Equals(false));
		}

		[Test]
		public void CalculatorEngine_Factorial_OfZero_ReturnsOne()
		{
			double Number = 0.0;
			double Expected = 1.0;
			string Error = "";

			CalculationResult result = _calculator.Factorial(Number);

			Assert.That(result.Result.Equals(Expected));
			Assert.That(result.Error.Equals(Error));
			Assert.That(result.IsSuccess.Equals(true));
		}

		[Test]
		public void CalculatorEngine_Factorial_OfAFloatingPointNumber_ReturnsResult()
		{
			double Number = 5.0;
			double Expected = 120.0;
			string Error = "";

			CalculationResult result = _calculator.Factorial(Number);

			Assert.That(result.Result.Equals(Expected));
			Assert.That(result.Error.Equals(Error));
			Assert.That(result.IsSuccess.Equals(true));
		}

		[Test]
		public void CalculatorEngine_Reciprocal_OfAFloatingPointNumber_ReturnsResult()
		{
			double Number = 8.0;
			double Expected = 0.125;
			string Error = "";

			CalculationResult result = _calculator.Reciprocal(Number);

			Assert.That(result.Result.Equals(Expected));
			Assert.That(result.Error.Equals(Error));
			Assert.That(result.IsSuccess.Equals(true));
		}
	}
}