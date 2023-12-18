namespace SDO.Infrastructure.Sql.Models
{
    public class CART_INPUT_SPEDIZIONI
    {
		/// <summary>
		/// identificativo univoco numerico progressivo di tabella, che fa riferimento alla singola spedizione di file per un certo flusso
		/// </summary>
		public int INSP_ID {  get; set; }

		/// <summary>
		/// identificativo univoco proveniente dalla tabella STSA_ASL
		/// </summary>
		public int INSP_ASL_ID { get; set; }

		/// <summary>
		/// identificativo univoco del tipo di spedizione proveniente dalla tabella SDO_TIPI_SPEDIZIONE
		/// </summary>
		public int INSP_TISP_ID {  get; set; }

		/// <summary>
		/// Identificativo dello stato della spedizione
		/// </summary>
		public int INSP_STSP_ID { get; set; }

		/// <summary>
		/// per registrare il nome del file avente i dati anagrafici
		/// </summary>
		public string INSP_FILE_ANAG {  get; set; }

		/// <summary>
		/// per registrare il nome del file avente i dati clinici di ricovero
		/// </summary>
		public string INSP_FILE_CLIN {  get; set; }

		/// <summary>
		/// Descrizione del nome del file di log di controllo
		/// </summary>
		public string INSP_FILE_LOG {  get; set; }

		/// <summary>
		/// impiegato per indicare che è stato eseguito il calcolo del DRG (INSP_STATUS = 3). Per gli altri valori, a parte il NULL, non è possibile specificare alcuna informazione
		/// </summary>
		public int INSP_STATUS {  get; set; }

		/// <summary>
		/// Data di spedizione dei file
		/// </summary>
		public DateTime INSP_DATA_SPEDIZIONE { get; set; }

		/// <summary>
		/// Data e ora di caricamento della spedizione
		/// </summary>
		public DateTime INSP_DATA_ACQUISIZIONE { get; set; }

		/// <summary>
		/// Data ed ora di controllo della spedizione
		/// </summary>
		public DateTime INSP_DATA_ELABORAZIONE {  get; set; }

		/// <summary>
		/// Nome entità utente Azure che ha caricato la spedizione
		/// </summary>
		public string INSP_NOME_ENTITA_UTENTE {  get; set; }

		/// <summary>
		/// Flag per indicare se il DRG è stato calcolato ed aggiornato negli archivi definitivi.
		/// Valori possibili:•	0, DRG non calcolato,•	1, DRG calcolato.
		/// </summary>
		public int DRG_CALCOLATO {  get; set; }

		/// <summary>
		/// mai valorizzato
		/// </summary>
		public string? INSP_FILE_OLD { get; set; } = null;

		/// <summary>
		/// per tener traccia di chi ha modificato il singolo record
		/// </summary>
		public string INSP_UTENTE {  get; set; }

		/// <summary>
		/// per tener traccia di quando è avvenuto l'aggiornamento
		/// </summary>
		public DateTime INSP_DATA_AGGIOR { get; set; } = DateTime.UtcNow;
	}
}
