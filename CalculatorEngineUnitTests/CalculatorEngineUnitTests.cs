using Microsoft.VisualBasic;

namespace CalculatorEngineUnitTests
{
	public class CalculatorEngineUnitTests
	{

		[Test]
		public void CalculatorEngine_AddTwoFloatingPoints_ReturnsSum()
		{
			//Arrange
			double firstNumber = 5.5;
			double secondNumber = -3.15;
			double Expected = 2.35;

			//Act
			CalculationResult result = CalculatorEngineMethods.Add(firstNumber, secondNumber);

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

			CalculationResult result = CalculatorEngineMethods.Subtract(firstNumber, secondNumber);

			Assert.That(result.Result.Equals(Expected));
			Assert.That(result.IsSuccess.Equals(true));
		}

		[Test]
		public void CalculatorEngine_MultiplyTwoFloatingPoints_ReturnsProduct()
		{
			double firstNumber = 5.0;
			double secondNumber = 7.1;
			double Expected = 35.5;

			CalculationResult result = CalculatorEngineMethods.Multiply(firstNumber, secondNumber);

			Assert.That(result.Result.Equals(Expected));
			Assert.That(result.IsSuccess.Equals(true));
		}

		[Test]
		public void CalculatorEngine_DivideTwoFloatingPoints_ReturnsQuotient()
		{
			double firstNumber = 3.0;
			double secondNumber = 9.0;
			double Expected = 3.0 / 9.0;

			CalculationResult result = CalculatorEngineMethods.Divide(firstNumber, secondNumber);

			Assert.That(result.Result.Equals(Expected));
			Assert.That(result.IsSuccess.Equals(true));
		}

		[Test]
		public void CalculatorEngine_DivideByZero_ThrowsException()
		{
			double firstNumber = 3.0;
			double secondNumber = 0.0;

			Assert.Throws<CalculatorEngine.DivisionByZeroException>(() => CalculatorEngineMethods.Divide(firstNumber, secondNumber));
		}

		[Test]
		public void CalculatorEngine_RaiseToPower_TwoFloatingPointNumbers()
		{
			double firstNumber = 2.0;
			double secondNumber = 3.0;
			double Expected = 8.0;

			CalculationResult result = CalculatorEngineMethods.Power(firstNumber, secondNumber);

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

			CalculationResult result = CalculatorEngineMethods.Logarithm(firstNumber, secondNumber);

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

			CalculationResult result = CalculatorEngineMethods.Logarithm(firstNumber, secondNumber);

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

			CalculationResult result = CalculatorEngineMethods.Logarithm(firstNumber, secondNumber);

			Assert.That(result.Result.Equals(0.0));
			Assert.That(result.Error.Equals(Error));
			Assert.That(result.IsSuccess.Equals(false));
		}
	}
}