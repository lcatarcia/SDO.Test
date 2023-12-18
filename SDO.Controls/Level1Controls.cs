using SDO.Infrastructure.Sql.Interfaces;
using SDO.Infrastructure.Sql.Models;
using System;
using System.IO;
using System.Reflection;

namespace SDO.Controls
{
	public class Level1Controls
	{
		private SDO_DATI_ANAGRAFICI _bioRecords;
		private SDO_DATI_CLINICI _clinicalRecords;
		private LOG_CONTROLLI _logControlli;

		public Level1Controls()
		{

		}

		public Level1Controls(IFileModel fileModel)
		{
			if (fileModel is SDO_DATI_ANAGRAFICI)
			{
				_bioRecords = (SDO_DATI_ANAGRAFICI)fileModel;
			}
			else if (fileModel is SDO_DATI_CLINICI)
			{
				_clinicalRecords = (SDO_DATI_CLINICI)fileModel;
			}
			_logControlli = new LOG_CONTROLLI();
		}

		public bool MakeControls()
		{
			if (_bioRecords != null)
				return MakeBiographicalControls();
			else if (_clinicalRecords != null)
				return MakeClinicalControls();
			return false;
		}

		private bool MakeBiographicalControls()
		{
			PropertyInfo[] properties = _bioRecords.GetType().GetProperties();
			foreach (PropertyInfo property in properties)
			{
#warning - meglio così...
				if (property.Name == "ISTITUTO")
				{

				}

			}

			bool result = false;
#warning - ...o così?
			if (!string.IsNullOrEmpty(_bioRecords.ISTITUTO))
			{
				_logControlli.SLOC_ISTITUTO = _bioRecords.ISTITUTO;
				if (_bioRecords.ISTITUTO.Length > 0 && _bioRecords.ISTITUTO.Length <= 8)
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			else
			{
				result = false;
				// errore, impossibile continuare
			}
			return result;
		}

		private bool MakeClinicalControls()
		{
			bool result = false;

			return result;
		}
	}
}
