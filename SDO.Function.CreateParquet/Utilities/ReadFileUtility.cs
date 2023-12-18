using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDO.Function.CreateParquet.Utilities
{
	internal static class ReadFileUtility
	{
		internal static List<string> FindFields(string inputString)
		{
			List<string> fields = new();
			string[] parts = inputString.Split(new[] { ' ' }, StringSplitOptions.None);

			foreach (string part in parts)
			{
				string[] subParts = part.Split(' ');

				//foreach (string subPart in subParts)
				//{
				//    if (string.IsNullOrWhiteSpace(part)) fields.Add(null);
				//    else fields.Add(part);
				//}

				foreach (string subPart in subParts)
				{
					if (string.IsNullOrWhiteSpace(subPart)) fields.Add(null);
					else fields.Add(subPart);
				}
			}

			return fields;
		}
	}
}
