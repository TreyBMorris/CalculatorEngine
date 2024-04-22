using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace CalculatorEngine
{
	public class CalculatorEngineMethods : ICalculatorEngineMethods
	{
		public CalculationResult Add(double firstNumber, double secondNumber)
		{
			CalculationResult result = new CalculationResult();
			result.IsSuccess = true;
			result.Error = "";
			result.Result = firstNumber + secondNumber;
			result.Operation = firstNumber + " + " + secondNumber + " = ";
			return result;
		}
		
		public CalculationResult Subtract(double firstNumber, double secondNumber) 
		{
			CalculationResult result = new CalculationResult();
			result.IsSuccess = true;
			result.Error = "";
			result.Result= firstNumber - secondNumber;
			result.Operation = firstNumber + " - " + secondNumber + " = ";
			return result;
		}

		public CalculationResult Multiply(double firstNumber, double secondNumber) 
		{
			CalculationResult result = new CalculationResult();
			result.IsSuccess = true;
			result.Error = "";
			result.Result = firstNumber * secondNumber;
			result.Operation = firstNumber + " * " + secondNumber + " = ";
			return result;
		}
		public CalculationResult Divide(double firstNumber, double secondNumber)
		{
			CalculationResult result = new CalculationResult();
			result.Operation = firstNumber + " / " + secondNumber + " = ";
			try
			{
				if(secondNumber == 0)
				{
					throw new DivideByZeroException("Not a number");
				}
				result.Result = firstNumber/ secondNumber;
				result.IsSuccess = true;
				result.Error = "";
			}
			catch(DivideByZeroException e)
			{
				result.Result = 0.0;
				result.IsSuccess = false;
				result.Error = e.Message;
			}
			return result;
		}

		public CalculationResult Power(double firstNumber, double secondNumber) 
		{
			CalculationResult result = new CalculationResult();
			result.Operation = firstNumber + " ^ " + secondNumber + " = ";
			result.IsSuccess = true;
			result.Error = "";
			result.Result = Math.Pow(firstNumber, secondNumber);
			return result;
		}
		
		public CalculationResult Logarithm(double firstNumber, double secondNumber) 
		{
			CalculationResult result = new CalculationResult();
			result.Operation = firstNumber + " log " + secondNumber + " = ";
			try
			{
				if(firstNumber==0)
				{
					throw new LogarithmZeroException("First number cannot be less than or equal to zero");
				}
				if(secondNumber == 0)
				{
					throw new LogarithmZeroException("Second number cannot be Zero");
				}
				double logResult = Math.Log(firstNumber) / Math.Log(secondNumber);
				result.Result = logResult;
				result.IsSuccess = true;
				result.Error = "";
			}
			catch(LogarithmZeroException e)
			{
				result.Result = 0.0;
				result.IsSuccess = false;
				result.Error = e.Message;
			}
			return result;
		}

		public CalculationResult Root(double firstNumber, double secondNumber)
		{
			CalculationResult result = new CalculationResult();
			result.Operation = secondNumber + " √ " + firstNumber + " = ";
			try
			{
				if(secondNumber == 0)
				{
					throw new RootException("Second number cannot be zero");
				}
				double rootResult = Math.Round(Math.Pow(firstNumber, 1.0 / secondNumber));
				result.Result = rootResult;
				result.IsSuccess = true;
				result.Error = "";
			}
			catch (RootException e) 
			{
				result.Result = 0.0;
				result.IsSuccess = false;
				result.Error= e.Message;
			}
			return result;
		}

		public CalculationResult Factorial(double firstNumber)
		{
			CalculationResult result = new CalculationResult();
			result.Operation = firstNumber + "! = ";
			if (firstNumber == 0)
			{
				result.IsSuccess = true;
				result.Error = "";
				result.Result = 1;
			}
			else
			{
				int factorialNum = 1;
				for (int i = 1; i <= firstNumber; i++)
				{
					factorialNum *= i;
				}

				result.IsSuccess = true;
				result.Error = "";
				result.Result = factorialNum;
			}

			return result;
		}


		public CalculationResult Reciprocal(double firstNumber)
		{
			CalculationResult result = new CalculationResult();
			result.Operation = "1/" + firstNumber + " = ";

			try
			{
				if (firstNumber == 0)
				{
					throw new DivideByZeroException("Not a number");
				}

				result.IsSuccess = true;
				result.Error = "";
				result.Result = (1 / firstNumber);
			}
			catch (DivideByZeroException e)
			{
				result.Result = 0.0;
				result.Error = e.Message;
				result.IsSuccess = false;
			}
			return result;
		}
	}
}
