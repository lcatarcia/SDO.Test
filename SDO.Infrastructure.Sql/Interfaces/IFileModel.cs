using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDO.Infrastructure.Sql.Interfaces
{
	public interface IFileModel
	{
		public int SequenceNumber { get; }

		public void SetSequenceNumber(int sequenceNumber);
	}
}
