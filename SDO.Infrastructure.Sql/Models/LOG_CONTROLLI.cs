using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SDO.Infrastructure.Sql.Models
{
	/// <summary>
	/// Contiene le informazioni di log in merito soltanto agli errori emersi rispetto ai controlli effettuati sui file SDO da acquisire, caricati tramite il portale della nuova web application.
	// Questa tabella deve consentire la comunicazione degli errori per i controlli eseguiti su un’intera spedizione
	/// </summary>
	internal class LOG_CONTROLLI
	{
		/// <summary>
		/// Identificativo univoco di tabella
		/// </summary>
		public int SLOC_ID {  get; set; }

		/// <summary>
		/// Identificativo univoco della spedizione
		/// </summary>
		public int SLOC_INSP_ID { get; set; }

		/// <summary>
		/// Identificativo univoco dell’associazione controllo-campo
		/// </summary>
		public int SLOC_CACN_ID {  get; set; }

		/// <summary>
		/// Identificativo univoco dell’eventuale scadenza invio file SDO
		/// </summary>
		public int SLOC_SCIF_ID { get; set; }

		/// <summary>
		/// Codice Istituto
		/// </summary>
		public string SLOC_ISTITUTO {  get; set; }

		/// <summary>
		/// Nosografico
		/// </summary>
		public int SLOC_NOSOGRAF {  get; set; }

		/// <summary>
		/// N.ro scheda reparto
		/// </summary>
		public int SLOC_NR_SCHED {  get; set; }

		/// <summary>
		/// Nome del campo controllato
		/// </summary>
		public string SLOC_CODICE_CAMPO_CONTROLLATO {  get; set; }

		/// <summary>
		/// Valore del campo controllato
		/// </summary>
		public string SLOC_VALORE_CAMPO_CONTROLLATO { get; set; }

		/// <summary>
		/// Descrizione composita di tutti i dati verificati nell’ambito del controllo effettuato
		/// </summary>
		public string SLOC_DESCRIZIONE_DATI_CONTROLLATI { get; set; }

		/// <summary>
		/// Descrizione completa dell’errore rispetto al controllo ed al campo interessato
		/// </summary>
		public string SLOC_DESCRIZIONE_ERRORE {  get; set; }

		/// <summary>
		/// Data ed ora di effettuazione del controllo
		/// </summary>
		public DateTime SLOC_DATA_CONTROLLO {  get; set; }
	}
}
