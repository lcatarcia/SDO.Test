using SDO.Controls.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDO.Controls.Controls.Waterfall
{
	internal class TicketBox
	{
		private List<ControlTicket> _ticketList;

		public TicketBox()
		{
			_ticketList = new();
		}

		public void Push(ControlTicket ticket)
		{
			_ticketList.Add(ticket);
		}

		public void Empty() { _ticketList.Clear(); }

		public List<ControlTicket> GetAll() { return _ticketList; }

		public ControlTicket GetTicket(string propertyName, Enums.ControlType controlType)
			=> _ticketList.FirstOrDefault(x => x.PropertyName == propertyName && x.ControlType == controlType);
	}
}
