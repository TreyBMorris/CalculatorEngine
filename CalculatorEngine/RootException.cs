using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorEngine
{
	public class RootException : Exception
	{
		public RootException() { }
		public RootException(string message) : base(message) { }
		public RootException(string message, Exception innerException) : base(message, innerException) { }

	}
}
