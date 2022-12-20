using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class NumberValidator : INumberValidator
    {
		private int? _value;

		public static int Precision = 2; // NumberOfDigits

		public NumberValidator()
		{

		}

		public NumberValidator(int precision)
		{
			Precision = precision;
		}

		public int Value
		{
			get
			{
				if (_value == null) throw new InvalidOperationException();
				return (int)_value;
			}
			set
			{
				if (Math.Abs(value).ToString().Length > Precision) // if(value > -999 && value > 999)
				{
					_value = null;
					return;
				}
				_value = value;
			}
		}

	}
}
