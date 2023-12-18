using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDO.Infrastructure.Sql.Models
{
	public class CART_INPUT_RICOVERI_ANAG
	{
		/// <summary>
		/// Identificativo univoco di tabella
		/// </summary>
		public int SIRA_ID {  get; set; }

		/// <summary>
		/// Identificativo della spedizione
		/// </summary>
		public int SIRA_INSP_ID { get; set; }

		/// <summary>
		/// Codice istituto
		/// </summary>
		public string SIRA_ISTITUTO { get; set; }

		/// <summary>
		/// Nosografico
		/// </summary>
		public int SIRA_NOSOGRAF { get; set; }

		/// <summary>
		/// N.ro scheda di reparto
		/// </summary>
		public int SIRA_NR_SCHED {  get; set; }

		/// <summary>
		/// Cognome dell’assistito
		/// </summary>
		public string SIRA_COG {  get; set; }

		/// <summary>
		/// Nome dell’assistito
		/// </summary>
		public string SIRA_NOME {  get; set; }

		/// <summary>
		/// Cognome acquisito dell’assistito
		/// </summary>
		public string SIRA_NOMEA {  get; set; }

		/// <summary>
		/// Sesso dell’assistito
		/// </summary>
		public char SIRA_SESSO {  get; set; }

		/// <summary>
		/// SIRA_DNASCITA
		/// </summary>
		public string SIRA_DNASCITA {  get; set; }

		/// <summary>
		/// Comune di nascita dell’assistito
		/// </summary>
		public string SIRA_COM_NASC {  get; set; }

		/// <summary>
		/// Stato civile dell’assistito
		/// </summary>
		public char SIRA_S_CIVILE { get; set; }

		/// <summary>
		/// Comune di residenza dell’assistito
		/// </summary>
		public string SIRA_COM_RES {  get; set; }

		/// <summary>
		/// Cittadinanza dell’assistito
		/// </summary>
		public string SIRA_C_CITT {  get; set; }

		/// <summary>
		/// Codice sanitario dell’assistito
		/// </summary>
		public string? SIRA_MATRICOL {  get; set; }

		/// <summary>
		/// Codice fiscale dell’assistito
		/// </summary>
		public string SIRA_LIBRETTO { get; set; }

		/// <summary>
		/// Regione di residenza dell’assistito
		/// </summary>
		public string SIRA_REG_RES { get; set; }

		/// <summary>
		/// ASL di residenza dell’assistito
		/// </summary>
		public string SIRA_ASL_RES {  get; set; }

		/// <summary>
		/// Regione di assistenza del paziente
		/// </summary>
		public string? SIRA_REG_ASS {  get; set; }

		/// <summary>
		/// ASL di assistenza del paziente
		/// </summary>
		public string? SIRA_ASL_ASS { get; set; }

		/// <summary>
		/// Descrizione del luogo di residenza del paziente estero
		/// </summary>
		public string? SIRA_RES_EST { get; set; }

		/// <summary>
		/// Cassa malati estera che assiste il paziente estero
		/// </summary>
		public string? SIRA_CAS_EST { get; set; }

		/// <summary>
		/// Indirizzo della cassa malati estera
		/// </summary>
		public string? SIRA_I_CASEST { get; set; }

		/// <summary>
		/// CAP della cassa malati estera
		/// </summary>
		public string? SIRA_C_CASEST { get; set; }

		/// <summary>
		/// Tipo identificativo utente
		/// </summary>
		public char SIRA_TIPO_ID {  get; set; }

		/// <summary>
		/// Codice identificativo utente
		/// </summary>
		public string SIRA_COD_ID { get; set; }

		/// <summary>
		/// Numero identificazione TEAM
		/// </summary>
		public string? SIRA_N_TEAM {  get; set; }

		/// <summary>
		/// Codice dell’istituzione competente TEAM
		/// </summary>
		public string? SIRA_COD_IST {  get; set; }

		/// <summary>
		/// Acronimo dell’istituzione che ha rilasciato la TEAM
		/// </summary>
		public string? SIRA_DEN_IST { get; set; }

		/// <summary>
		/// Stato estero che rilascia la TEAM
		/// </summary>
		public string? SIRA_ST_ESTERO { get; set; }

		/// <summary>
		/// Tipo assistenza previsto dalla TEAM
		/// </summary>
		public string? SIRA_TIPO_TEAM { get; set; }

		/// <summary>
		/// Data di scadenza della TEAM
		/// </summary>
		public string? SIRA_DATA_SCAD { get; set; }

		/// <summary>
		/// Titolo di studio dell’assistito
		/// </summary>
		public char SIRA_TITOLO {  get; set; }

		/// <summary>
		/// Nosografico della puerpera
		/// </summary>
		public string? SIRA_NOS_PUE {  get; set; }

		/// <summary>
		/// Presenza del codice identificativo dell’assistito in banca dati / verifica validità
		/// </summary>
		public char SIRA_PRES_COD_ID { get; set; }

		/// <summary>
		/// Contenuto della singola riga del singolo file
		/// </summary>
		public string SIRA_RIGA_IMPORT {  get; set; }

		/// <summary>
		/// Data importazione
		/// </summary>
		public DateTime SIRA_DATA_IMPORT {  get; set; }
	}
}
