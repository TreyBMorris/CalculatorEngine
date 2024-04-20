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
			result.Error = "";
			result.IsSuccess = true;
			result.Result= firstNumber - secondNumber;
			result.Operation = firstNumber + " - " + secondNumber + "= ";
			return result;
		}

	}
}
