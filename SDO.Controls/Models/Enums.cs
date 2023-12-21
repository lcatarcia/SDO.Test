using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDO.Controls.Models
{
	internal class Enums
	{
		public enum Comparer
		{
			EQUAL,
			NOT_EQUAL,
			LESS,
			GREATER,
			GREATER_EQUAL,
			LESS_EQUAL
		}

		public enum FileType
		{
			Biographical,
			Clinical
		}

		public enum ControlType
		{
			Mandatory,
			TypeAndLength,
			Format,
			Domain,
			Business
		}
	}
}
