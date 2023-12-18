using SDO.Infrastructure.Sql.Interfaces;
using SDO.Infrastructure.Sql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDO.Controls.Controls
{
	public class RequiredControl : BaseControl
	{
		private SDO_DATI_ANAGRAFICI _bioRecords;
		public override bool MakeControl(IFileModel fileModel)
		{
			if(fileModel is SDO_DATI_ANAGRAFICI)
				_bioRecords = (SDO_DATI_ANAGRAFICI)fileModel;

			if (!string.IsNullOrEmpty(_bioRecords.ISTITUTO))
			{
				return true;
			}
			else
			{
				return false;
			}

			if(NextControl!= null)
			{
				return NextControl.MakeControl(fileModel);
			}
			return true;
		}
	}
}
