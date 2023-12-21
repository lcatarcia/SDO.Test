using SDO.Controls.Models;
using SDO.Infrastructure.Sql.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDO.Controls.Controls.Waterfall
{
	internal class ObliteratingMachine
	{
		private ControlTicket _currentTicket;
		private TicketBox _ticketBox;

		public ObliteratingMachine()
		{
			_ticketBox = new TicketBox();
		}

		public ControlTicket Print(ControlTicket controlTicket, IFileModel fileModel)
		{
			_ticketBox.Push(controlTicket);
			_currentTicket = controlTicket;
			return _currentTicket;
		}

		public ControlTicket Renew(Enums.ControlType controlType)
		{
			ControlTicket ticket = _currentTicket.CloneWithNewControl(_currentTicket, controlType);
			//_ticketBox.Push(ticket);
			//_currentTicket = ticket;
			return ticket;
		}

		public ControlTicket GetCurrentTicket()
			=> _currentTicket;

		/// <summary>
		/// Il check totale va fatto al termine di tutti i controlli del record, prima di passare ai successivi livelli di controllo (2-3)
		/// </summary>
		/// <param name="controlTicket"></param>
		/// <param name="fileModel"></param>
		/// <returns></returns>
		public bool Check() 
			=> _ticketBox.GetAll().FirstOrDefault(x => x.MustBlock) != null;
	}
}
