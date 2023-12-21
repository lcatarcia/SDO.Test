using SDO.Controls.Models;
using SDO.Infrastructure.Sql.Interfaces;
using SDO.Infrastructure.Sql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDO.Controls.Controls.Waterfall
{
	internal class MandatoryControl : BaseControl
	{
		private SDO_DATI_ANAGRAFICI _bioRecords;
		private SDO_DATI_CLINICI _clinicalRecords;

		private ControlTicket _ticket;

		public MandatoryControl(ControlTicket controlTicket)
		{
			_ticket = controlTicket;
		}

		public override ControlTicket MakeControl(IFileModel fileModel)
		{
			throw new NotImplementedException();
		}

		private ControlTicket MakeBioControls()
		{
			ControlTicket controlTicket = new ControlTicket();

			return controlTicket;
		}
	}
}
