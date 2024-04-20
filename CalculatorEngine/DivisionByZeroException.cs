using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorEngine
{
	public class DivisionByZeroException : Exception
	{
        public DivisionByZeroException() { }
        public DivisionByZeroException(string message) : base(message) { }
        public DivisionByZeroException(string message, Exception innerException) : base(message, innerException) { }
	}
}
