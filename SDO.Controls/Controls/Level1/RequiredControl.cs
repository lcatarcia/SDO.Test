using SDO.Infrastructure.Sql.Interfaces;
using SDO.Infrastructure.Sql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SDO.Controls.Controls.Level1
{
	public class RequiredControl : Level1BaseControl
	{
		private SDO_DATI_ANAGRAFICI _bioRecords;
		private SDO_DATI_CLINICI _clinicalRecords;
		public override bool MakeControl(IFileModel fileModel)
		{
			bool result = false;
			if (fileModel is SDO_DATI_ANAGRAFICI)
			{
				_bioRecords = (SDO_DATI_ANAGRAFICI)fileModel;
				result = MakeBioControls(_bioRecords);
			}
			else if (fileModel is SDO_DATI_CLINICI)
			{
				_clinicalRecords = (SDO_DATI_CLINICI)fileModel;
				result = MakeClinicalControls(_clinicalRecords);
			}



			if (NextControl != null)
			{
				return NextControl.MakeControl(fileModel);
			}
			return true;
		}

		private bool MakeBioControls(SDO_DATI_ANAGRAFICI biographicalFile)
		{
			bool result = true;
			PropertyInfo[] properties = _bioRecords.GetType().GetProperties();
			foreach (PropertyInfo property in properties)
			{
				object? propertyValue = property.GetValue(_bioRecords);
				switch (property.Name)
				{
					case "ISTITUTO":
					case "NOSOGRAF":
					case "NR_SCHED":
					case "COG":
					case "NOME":
					case "SESSO":
					case "DNASCITA":
					case "COM_NASC":
					case "S_CIVILE":
					case "COM_RES":
					case "C_CITT":
					case "REG_RES":
					case "ASL_RES":
					case "TIPO_ID":
					case "COD_ID":
					case "TITOLO":
					case "PRES_COD_ID":
						if (propertyValue is null)
							result = false;
						break;
					case "MATRICOL":
						if ((_bioRecords.TIPO_ID == '2' ||
							_bioRecords.TIPO_ID == '4' ||
							_bioRecords.TIPO_ID == '9' ||
							_bioRecords.TIPO_ID == 'Z') &&
							propertyValue is null)
							result = false;
						if (_bioRecords.TIPO_ID == '3' && !string.IsNullOrEmpty((string)propertyValue))
							result = false;
						break;
					case "REG_ASS":
					case "ASL_ASS":
						if ((!_bioRecords.COM_RES.StartsWith("999") ||
							_bioRecords.COM_RES == "999997") &&
							propertyValue is null)
							result = false;
						break;
					case "N_TEAM":
					case "COD_IST":
					case "DEN_IST":
					case "ST_ESTERO":
					case "TIPO_TEAM":
						if (_bioRecords.TIPO_ID == '4' && propertyValue is null)
							result = false;
						break;
					case "DATA_SCAD":
						if ((_bioRecords.TIPO_ID == '4' ||
							_bioRecords.TIPO_ID == 'X') && propertyValue is null)
							result = false;
						break;
					case "NOS_PUE":
						//Da compilare in caso di SDO relativa a evento nascita
						break;
					default:
						break;
				}
			}
			return result;
		}

		private bool MakeClinicalControls(SDO_DATI_CLINICI clinicalFile)
		{
			bool result = false;

			return result;
		}
	}
}
