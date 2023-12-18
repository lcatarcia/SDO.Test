using SDO.Infrastructure.Sql.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDO.Controls.Controls
{
	public abstract class BaseControl
	{
		protected BaseControl NextControl { get; private set; }

		public void SetNextControl(BaseControl next) 
			=> NextControl = next;

		public abstract bool MakeControl(IFileModel fileModel);
	}
}
