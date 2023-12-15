using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDO.Infrastructure.Sql.Models
{
	/// <summary>
	/// Contiene i dati anagrafici SDO relativi agli assistiti/pazienti
	/// </summary>
	internal class SDO_DATI_ANAGRAFICI
	{
		/// <summary>
		/// Identificativo univoco di tabella
		/// </summary>
		public int SDO_DATI_ANAG_ID { get; set; }

		/// <summary>
		/// Identificativo univoco da tabella CART_INPUT_SPEDIZIONI
		/// </summary>
		public int INSP_ID { get; set; }

		/// <summary>
		/// Codice istituto
		/// </summary>
		public string ISTITUTO { get; set; }

		/// <summary>
		/// Nosografico
		/// </summary>
		public int NOSOGRAF { get; set; }

		/// <summary>
		/// N.ro scheda di reparto
		/// </summary>
		public int NR_SCHED { get; set; }

		/// <summary>
		/// Identificativo univoco da tabella SDO_CART_INPUT_RICOVERI_ANAG
		/// </summary>
		public int SIRA_ID { get; set; }

		/// <summary>
		/// Cognome dell’assistito
		/// </summary>
		public string COG { get; set; }

		/// <summary>
		/// Nome dell’assistito
		/// </summary>
		public string NOME { get; set; }

		/// <summary>
		/// Cognome acquisito dell’assistito
		/// </summary>
		public string NOMEA { get; set; }

		/// <summary>
		/// Sesso dell’assistito
		/// </summary>
		public char SESSO { get; set; }

		/// <summary>
		/// DNASCITA
		/// </summary>
		public string DNASCITA { get; set; }

		/// <summary>
		/// Comune di nascita dell’assistito
		/// </summary>
		public string COM_NASC { get; set; }

		/// <summary>
		/// Stato civile dell’assistito
		/// </summary>
		public char S_CIVILE { get; set; }

		/// <summary>
		/// Comune di residenza dell’assistito
		/// </summary>
		public string COM_RES { get; set; }

		/// <summary>
		/// Cittadinanza dell’assistito
		/// </summary>
		public string C_CITT { get; set; }

		/// <summary>
		/// Codice sanitario dell’assistito
		/// </summary>
		public string? MATRICOL { get; set; }

		/// <summary>
		/// Codice fiscale dell’assistito
		/// </summary>
		public string FISCALE { get; set; }

		/// <summary>
		/// Regione di residenza dell’assistito
		/// </summary>
		public string REG_RES { get; set; }

		/// <summary>
		/// ASL di residenza dell’assistito
		/// </summary>
		public string ASL_RES { get; set; }

		/// <summary>
		/// Regione di assistenza del paziente
		/// </summary>
		public string? REG_ASS { get; set; }

		/// <summary>
		/// ASL di assistenza del paziente
		/// </summary>
		public string? ASL_ASS { get; set; }

		/// <summary>
		/// Descrizione del luogo di residenza del paziente estero
		/// </summary>
		public string? RES_EST { get; set; }

		/// <summary>
		/// Cassa malati estera che assiste il paziente estero
		/// </summary>
		public string? CAS_EST { get; set; }

		/// <summary>
		/// Indirizzo della cassa malati estera
		/// </summary>
		public string? I_CASEST { get; set; }

		/// <summary>
		/// CAP della cassa malati estera
		/// </summary>
		public string? C_CASEST { get; set; }

		/// <summary>
		/// Tipo identificativo utente
		/// </summary>
		public char TIPO_ID { get; set; }

		/// <summary>
		/// Codice identificativo utente
		/// </summary>
		public string COD_ID { get; set; }

		/// <summary>
		/// Numero identificazione TEAM
		/// </summary>
		public string? N_TEAM { get; set; }

		/// <summary>
		/// Codice dell’istituzione competente TEAM
		/// </summary>
		public string? COD_IST { get; set; }

		/// <summary>
		/// Acronimo dell’istituzione che ha rilasciato la TEAM
		/// </summary>
		public string? DEN_IST { get; set; }

		/// <summary>
		/// Stato estero che rilascia la TEAM
		/// </summary>
		public string? ST_ESTERO { get; set; }

		/// <summary>
		/// Tipo assistenza previsto dalla TEAM
		/// </summary>
		public string? TIPO_TEAM { get; set; }

		/// <summary>
		/// Data di scadenza della TEAM
		/// </summary>
		public string? DATA_SCAD { get; set; }

		/// <summary>
		/// Titolo di studio dell’assistito
		/// </summary>
		public char TITOLO { get; set; }

		/// <summary>
		/// Nosografico della puerpera
		/// </summary>
		public string? NOS_PUE { get; set; }

		/// <summary>
		/// Presenza del codice identificativo dell’assistito in banca dati / verifica validità
		/// </summary>
		public char PRES_COD_ID { get; set; }

		/// <summary>
		/// Matricola sanitaria (invertibile) del paziente crittografata
		/// </summary>
		public DateTime MATR_CRYPT { get; set; }
	}
}
