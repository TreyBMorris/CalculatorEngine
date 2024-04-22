using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorEngine
{
	public class DivideByZeroException : Exception
	{
        public DivideByZeroException() { }
        public DivideByZeroException(string message) : base(message) { }
        public DivideByZeroException(string message, Exception innerException) : base(message, innerException) { }
	}
}
