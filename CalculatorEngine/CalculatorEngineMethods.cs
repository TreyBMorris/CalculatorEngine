using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorEngine
{
	public class CalculatorEngineMethods
	{
		public static CalculationResult Add(double firstNumber, double secondNumber)
		{
			CalculationResult result = new CalculationResult();
			result.IsSuccess = true;
			result.Error = "";
			result.Result = firstNumber + secondNumber;
			result.Operation = firstNumber + " + " + secondNumber + "= ";
			return result;
		}
		
		public static CalculationResult Subtract(double firstNumber, double secondNumber) 
		{
			CalculationResult result = new CalculationResult();
			result.IsSuccess = true;
			result.Error = "";
			result.Result= firstNumber - secondNumber;
			result.Operation = firstNumber + " - " + secondNumber + "= ";
			return result;
		}

		public static CalculationResult Multiply(double firstNumber, double secondNumber) 
		{
			CalculationResult result = new CalculationResult();
			result.IsSuccess = true;
			result.Error = "";
			result.Result = firstNumber * secondNumber;
			result.Operation = firstNumber + " * " + secondNumber + "= ";
			return result;
		}
		public static CalculationResult Divide(double firstNumber, double secondNumber)
		{
			CalculationResult result = new CalculationResult();
			result.Operation = firstNumber + " / " + secondNumber + "= ";
			try
			{
				if(secondNumber == 0)
				{
					throw new DivisionByZeroException("Not a number");
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
	}
}
