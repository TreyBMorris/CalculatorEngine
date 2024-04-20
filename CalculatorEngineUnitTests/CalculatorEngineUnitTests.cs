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
		}

		[Test]
		public void CalculatorEngine_SubtractTwoFloatingPoints_ReturnsDifference()
		{
			double firstNumber = 27.93;
			double secondNumber = 4.0;
			double Expected = 23.93;

			CalculationResult result = CalculatorEngineMethods.Subtract(firstNumber, secondNumber);

			Assert.That(result.Result.Equals(Expected));
		}
	}
}