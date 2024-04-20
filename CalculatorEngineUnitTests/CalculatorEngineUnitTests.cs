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
			Assert.That(result.Result.Equals(result.Result));
		}
	}
}