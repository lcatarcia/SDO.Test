using SDO.Controls;
using SDO.Infrastructure.Sql.Models;

SDO_DATI_ANAGRAFICI bioRecords = new();
SDO_DATI_CLINICI clinicalRecords = new();

// inserimento di un nuovo record nella tabella di spedizioni con un nuovo identificativo di spedizione (INSP_ID) e stato di spedizione uguale a 0.
// Tra i dati da registrare vi saranno i nomi dei 2 file di testo
CART_INPUT_SPEDIZIONI newShipping = new()
{
	INSP_ID = 1,
	INSP_STATUS = 0,
	INSP_FILE_ANAG = "mmorettiadm_25072023_152005_N_BZ_041001_20230720_SDO_ANA.txt",
	INSP_FILE_CLIN = "mmorettiadm_25072023_152005_N_BZ_041001_20230720_SDO_CLI.txt",
	INSP_TISP_ID = 1,
	DRG_CALCOLATO = 0,
	INSP_ASL_ID = 1,
	INSP_DATA_ACQUISIZIONE = DateTime.UtcNow,
	INSP_DATA_AGGIOR = DateTime.UtcNow,
	INSP_DATA_ELABORAZIONE = DateTime.UtcNow,
	INSP_DATA_SPEDIZIONE = DateTime.UtcNow,
	INSP_FILE_LOG = "esempiolog.txt",
	INSP_FILE_OLD = string.Empty,
	INSP_NOME_ENTITA_UTENTE = "me@siag.it",
	INSP_STSP_ID = 0,
	INSP_UTENTE = "me medesimo"
};

// inserire i dati anagrafici (tracciato A) nella tabella stg.SDO_CART_INPUT_RICOVERI_ANAG, registrando il nuovo identificativo di spedizione
CART_INPUT_RICOVERI_ANAG inputRicoveriAnagr = new();
CART_INPUT_RICOVERI_CLIN inputRicoveriClin = new();

// start controlli

//----------- LIVELLO 1
// controlli su singolo campo per singolo file (tracciato)

// controlli livello 1 dati anagrafici
Level1Controls level1Controls = new(bioRecords);
bool level1Result = level1Controls.MakeControls();

// controlli livello 1 dati clinici

//----------- LIVELLO 2
// controlli su singolo campo rispetto ad altri campi dello stesso file (tracciato)


// controlli livello 2 dati anagrafici


// controlli livello 2 dati clinici


//----------- LIVELLO 3
// 3.	controlli su singolo campo di un file/tracciato rispetto ad altri campi relativi ai file (tracciati) da considerare insieme

