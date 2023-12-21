using SDO.Controls.Models;
using SDO.Infrastructure.Sql.Interfaces;
using SDO.Infrastructure.Sql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SDO.Controls.Controls.Waterfall
{
	public class Starter
	{
		private SDO_DATI_ANAGRAFICI _bioRecords;
		private SDO_DATI_CLINICI _clinicalRecords;
		private LOG_CONTROLLI _controlLog;

		public Starter(IFileModel fileModel)
		{
			if (fileModel is SDO_DATI_ANAGRAFICI)
				_bioRecords = (SDO_DATI_ANAGRAFICI)fileModel;
			else if (fileModel is SDO_DATI_CLINICI)
				_clinicalRecords = (SDO_DATI_CLINICI)fileModel;

			_controlLog = new LOG_CONTROLLI();
		}

		public void Start()
		{
			if (_bioRecords is not null)
			{
				MakeBioControls();
			}
			else if (_clinicalRecords is not null)
			{
				MakeClinicalControls();
			}
		}

		private void MakeBioControls()
		{
			PropertyInfo[] properties = _bioRecords.GetType().GetProperties();
			ObliteratingMachine obliteratingMachine = new();
			foreach (PropertyInfo property in properties)
			{
				ControlTicket ticket = new()
				{
					FileType = Enums.FileType.Biographical,
					PropertyName = property.Name,
					IsValid = true
				};
				object? propertyValue = property.GetValue(_bioRecords);
				switch (property.Name)
				{
					case "ISTITUTO":
						// controllo obbligatorietà
						ticket.ControlType = Enums.ControlType.Mandatory;

						if (propertyValue is null)
							ticket.IsValid = false;
						obliteratingMachine.Print(ticket, _bioRecords);

						if (ticket.IsValid)
						{
							//controllo tipo e lunghezza
							ControlTicket typeAndLengthTicket = obliteratingMachine.Renew(Enums.ControlType.TypeAndLength);
							typeAndLengthTicket.IsValid = CheckStringLength(propertyValue, 8, Enums.Comparer.NOT_EQUAL);
							obliteratingMachine.Print(typeAndLengthTicket, _bioRecords);
						}

						// non ci sono altri controlli di livello 1 e 2 da eseguire
						break;

					case "MATRICOL":
						// controllo obbligatorietà
						ticket.ControlType = Enums.ControlType.Mandatory;

						bool mandatoryResult = true;
						if ((_bioRecords.TIPO_ID == '2' ||
							_bioRecords.TIPO_ID == '4' ||
							_bioRecords.TIPO_ID == '9' ||
							_bioRecords.TIPO_ID == 'Z') &&
							propertyValue is null)
							mandatoryResult = false;
						if (_bioRecords.TIPO_ID == '3' && !string.IsNullOrEmpty((string)propertyValue))
							mandatoryResult = false;

						ticket.IsValid = mandatoryResult;
						obliteratingMachine.Print(ticket, _bioRecords);

						// nessun altro controllo da eseguire
						break;

					case "RES_EST":
						// non obbligatorio, inizio con il controllo di tipo e lunghezza
						ticket.ControlType = Enums.ControlType.TypeAndLength;
						ticket.IsValid = CheckStringLength(propertyValue, 25, Enums.Comparer.GREATER, false);
						obliteratingMachine.Print(ticket, _bioRecords);

						if (ticket.IsValid)
						{
							// Controllo di business: Verifica del paese estero nel comune di residenza:
							// primi 3 caratteri di COM_RES uguali a 999 e successivi tre caratteri diversi da 997 e 999.

							ControlTicket businessTicket = obliteratingMachine.Renew(Enums.ControlType.Business);
							//TODO
							obliteratingMachine.Print(businessTicket, _bioRecords);
						}
						break;
				}
			}
			bool tripValidationResult = obliteratingMachine.Check();
		}
		private void MakeClinicalControls() { }


		private bool CheckStringLength(object propertyValue, int length, Enums.Comparer comparer, bool required = true)
		{
			if (propertyValue is not string)
				return false;
			else
			{
				if (propertyValue is not null)
				{
					if (comparer == Enums.Comparer.NOT_EQUAL)
					{
						if (((string)propertyValue).Length != length)
							return false;
					}
					else if (comparer == Enums.Comparer.GREATER && ((string)propertyValue).Length > length)
						return false;
				}
				else
				{
					if (required)
					{
#warning - qui si sta accavallando il controllo sull'obbligatorietà fatto nello step precedente
						return false;
					}
				}
			}
			return true;
		}
	}
}
