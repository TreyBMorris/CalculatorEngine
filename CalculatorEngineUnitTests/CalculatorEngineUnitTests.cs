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

			String Error = "Not a number";
			Assert.Throws<CalculatorEngine.DivisionByZeroException>(() => CalculatorEngineMethods.Divide(firstNumber, secondNumber));
		}
	}
}