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
		public string INSP_ASL_ID { get; set; }

		/// <summary>
		/// identificativo univoco proveniente dalla tabella SDO_TIPI_SPEDIZIONE
		/// </summary>
		public string INSP_TISP_ID {  get; set; }

		/// <summary>
		/// impiegato per indicare che è stato eseguito il calcolo del DRG (INSP_STATUS = 3). Per gli altri valori, a parte il NULL, non è possibile specificare alcuna informazione
		/// </summary>
		public string INSP_STATUS {  get; set; }

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
		public DateTime INSP_DATA_AGGIOR {  get; set; }
	}
}
