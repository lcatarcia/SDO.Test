using SDO.Controls.Models;
using SDO.Infrastructure.Sql.Interfaces;
using SDO.Infrastructure.Sql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SDO.Controls.Controls.Level1
{
	public class TypeAndLengthControl : Level1BaseControl
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
			bool result = false;

			PropertyInfo[] properties = _bioRecords.GetType().GetProperties();
			foreach (PropertyInfo property in properties)
			{
				object? propertyValue = property.GetValue(_bioRecords);
				switch (property.Name)
				{
#warning - sono commentati i datetime poichè la loro lunghezza potrebbe non essere un problema. è un problema a monte nel momento in cui leggo il file e assegno un dato valore ad un datetime
					case "ISTITUTO":
						result = CheckStringLength(propertyValue, 8, Enums.Comparer.NOT_EQUAL);
						break;
					case "NOSOGRAF":
					case "NOS_PUE":
						result = CheckStringLength(propertyValue, 10, Enums.Comparer.NOT_EQUAL);
						break;
					case "NR_SCHED":
					//case "DNASCITA":
					//case "DATA_SCAD":
						result = CheckIntLength(propertyValue, 8, Enums.Comparer.NOT_EQUAL);
						break;
					case "COG":
					case "DEN_IST":
						result = CheckStringLength(propertyValue, 30, Enums.Comparer.GREATER);
						break;
					case "NOME":
					case "NOMEA":
						result = CheckStringLength(propertyValue, 20, Enums.Comparer.GREATER);
						break;
					case "SESSO":
					case "S_CIVILE":
					case "TITOLO":
					case "PRES_COD_ID":
						result = CheckIntLength(propertyValue, 1, Enums.Comparer.NOT_EQUAL);
						break;
					case "COM_NASC":
					case "COM_RES":
						result = CheckStringLength(propertyValue, 6, Enums.Comparer.GREATER);
						break;
					case "C_CITT":
					case "REG_RES":
					case "ASL_RES":
					case "REG_ASS":
					case "ASL_ASS":
						result = CheckStringLength(propertyValue, 3, Enums.Comparer.GREATER);
						break;
					case "MATRICOL":
						result = CheckStringLength(propertyValue, 16, Enums.Comparer.GREATER);
						break;
					case "RES_EST":
						result = CheckStringLength(propertyValue, 25, Enums.Comparer.GREATER, false);
						break;
					case "CAS_EST":
					case "I_CASEST":
						result = CheckStringLength(propertyValue, 40, Enums.Comparer.GREATER, false);
						break;
					case "C_CASET":
						result = CheckStringLength(propertyValue, 10, Enums.Comparer.GREATER, false);
						break;
					case "TIPO_ID":
						result = CheckStringLength(propertyValue, 1, Enums.Comparer.NOT_EQUAL);
						break;
					case "COD_ID":
						if (propertyValue is not string)
							return false;
						else
						{
							if (((string)propertyValue).Length != 16 ||
								((string)propertyValue).Length != 20)
								return false;
						}
						return true;
					case "ST_ESTERO":
						result = CheckStringLength(propertyValue, 2, Enums.Comparer.GREATER);
						break;
					case "TIPO_TEAM":
						result = CheckStringLength(propertyValue, 4, Enums.Comparer.GREATER);
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

		private bool CheckIntLength(object propertyValue, int length, Enums.Comparer comparer)
		{
			if (propertyValue is not int)
				return false;
			else
			{
				if (comparer == Enums.Comparer.NOT_EQUAL)
				{
					if (((string)propertyValue).Length != length)
						return false;
				}
				else if (comparer == Enums.Comparer.GREATER && ((string)propertyValue).Length > length)
					return false;
			}
			return true;
		}
	}
}
