using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorEngine
{
	public class LogarithmZeroException : Exception
	{
		public LogarithmZeroException() { }
		public LogarithmZeroException(string message) : base(message) { }
		public LogarithmZeroException(string message, Exception innerException) : base(message, innerException) { }

	}
}
