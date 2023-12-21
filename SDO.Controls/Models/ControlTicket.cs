using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SDO.Controls.Models.Enums;

namespace SDO.Controls.Models
{
	internal class ControlTicket
	{
		public FileType FileType { get; set; }
		public string PropertyName { get; set; }
		//public string? PropertyValue { get; set; }
		public ControlType ControlType { get; set; }
		public bool IsValid { get; set; }
		public bool MustBlock { get; set; } = false;

		public ControlTicket CloneWithNewControl(ControlTicket oldTicket, Enums.ControlType controlType)
		{
			ControlTicket ticket = oldTicket;
			ticket.ControlType = controlType;
			ticket.IsValid = true;
			ticket.MustBlock = false;

			return ticket;
		}
	}
}
