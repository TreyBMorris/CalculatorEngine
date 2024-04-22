namespace CalculatorEngine;

public interface ICalculatorEngineMethods
{
	public CalculationResult Add(double firstNumber, double secondNumber);

	public CalculationResult Subtract(double firstNumber, double secondNumber);

	public CalculationResult Multiply(double firstNumber, double secondNumber);
	public CalculationResult Divide(double firstNumber, double secondNumber);

	public CalculationResult Power(double firstNumber, double secondNumber);

	public CalculationResult Logarithm(double firstNumber, double secondNumber);

	public CalculationResult Root(double firstNumber, double secondNumber);
	public CalculationResult Factorial(double firstNumber);
	public CalculationResult Reciprocal(double firstNumber);

}