using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDO.Infrastructure.Sql.Models
{
	/// <summary>
	/// Contiene i dati clinici SDO relativi agli assistiti/pazienti
	/// </summary>
	internal class SDO_DATI_CLINICI
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
		/// Regime di ricovero A
		/// </summary>
		public char REGRIC { get; set; }

		/// <summary>
		/// Nosografico
		/// </summary>
		public int NOSOGRAF { get; set; }

		/// <summary>
		/// N.ro scheda di reparto
		/// </summary>
		public int NR_SCHED { get; set; }

		/// <summary>
		/// Identificativo univoco da tabella SDO_CART_INPUT_RICOVERI_CLIN
		/// </summary>
		public int SIRC_ID { get; set; }

		/// <summary>
		/// Data del ricovero in ospedale
		/// </summary>
		public string D_RICOSP { get; set; }

		/// <summary>
		/// Unità operativa di ammissione
		/// </summary>
		public string REP_AMM { get; set; }

		/// <summary>
		/// Unità operativa di ricovero fisico per la lungodegenza post acuta
		/// </summary>
		public string REP_LUNG { get; set; }

		/// <summary>
		/// Onere della degenza
		/// </summary>
		public char ONER_DEG { get; set; }

		/// <summary>
		/// Provenienza del paziente
		/// </summary>
		public char PROVENIE { get; set; }

		/// <summary>
		/// Tipo di ricovero
		/// </summary>
		public char TIPO_RIC { get; set; }

		/// <summary>
		/// Motivo del ricovero in regime diurno
		/// </summary>
		public char? MOTIV_DH { get; set; }

		/// <summary>
		/// Data del ricovero nell'unità operativa
		/// </summary>
		public string D_RICREP { get; set; }

		/// <summary>
		/// Giorni di permesso del reparto
		/// </summary>
		public int? GGPERM { get; set; }

		/// <summary>
		/// Traumatismi e intossicazioni
		/// </summary>
		public char? TRAUMATI { get; set; }

		/// <summary>
		/// Diagnosi principale di reparto
		/// </summary>
		public string DIAG_REP { get; set; }

		/// <summary>
		/// Prima diagnosi concomitante di reparto
		/// </summary>
		public string? C_DIAG1 { get; set; }

		/// <summary>
		/// Seconda diagnosi concomitante di reparto
		/// </summary>
		public string? C_DIAG2 { get; set; }

		/// <summary>
		/// Terza diagnosi concomitante di reparto
		/// </summary>
		public string? C_DIAG3 { get; set; }

		/// <summary>
		/// Quarta diagnosi concomitante di reparto
		/// </summary>
		public string? C_DIAG4 { get; set; }

		/// <summary>
		/// Quinta diagnosi concomitante di reparto
		/// </summary>
		public string? C_DIAG5 { get; set; }

		/// <summary>
		/// Data dell'intervento chirurgico principale di reparto
		/// </summary>
		public string? DINTCP_R { get; set; }

		/// <summary>
		/// Intervento chirurgico principale di reparto
		/// </summary>
		public string? CINTCP_R { get; set; }

		/// <summary>
		/// Tipo di struttura erogatrice esterna di effettuazione dell'intervento chirurgico principale
		/// </summary>
		public char? SINTCP_R { get; set; }

		/// <summary>
		/// Codice della struttura erogatrice esterna di effettuazionedell'intervento chirurgico principale
		/// </summary>
		public string? CSINTCPR { get; set; }

		/// <summary>
		/// Data altro intervento chirurgico secondario direparto
		/// </summary>
		public string? DINTC1_R { get; set; }

		/// <summary>
		/// Altro intervento chirurgico secondario 1 di reparto
		/// </summary>
		public string? CINTC1_R { get; set; }

		/// <summary>
		/// Tipo di struttura erogatrice esterna di effettuazionedell'intervento chirurgico secondario 1 di reparto
		/// </summary>
		public char? SINTC1_R { get; set; }

		/// <summary>
		/// Codice della struttura erogatrice esterna di effettuazionedell'intervento chirurgico secondario 1 di reparto
		/// </summary>
		public string? CSINTC1R { get; set; }

		/// <summary>
		/// Data altro intervento chirurgico secondario 2 di reparto
		/// </summary>
		public string? DINTC2_R { get; set; }

		/// <summary>
		/// Altro intervento chirurgico secondario 2 di reparto
		/// </summary>
		public string? CINTC2_R { get; set; }

		/// <summary>
		/// Tipo di struttura erogatrice esterna di effettuazione dell'intervento chirurgico secondario 2 di reparto
		/// </summary>
		public char? SINTC2_R { get; set; }

		/// <summary>
		/// Codice della struttura erogatrice esterna di effettuazione dell'intervento chirurgico secondario 2 di reparto
		/// </summary>
		public string? CSINTC2R { get; set; }

		/// <summary>
		/// Data altro intervento chirurgico secondario 3 di reparto
		/// </summary>
		public string? DINTC3_R { get; set; }

		/// <summary>
		/// Altro intervento chirurgico secondario 3 di reparto
		/// </summary>
		public string? CINTC3_R { get; set; }

		/// <summary>
		/// Tipo di struttura erogatrice esterna di effettuazione dell'intervento chirurgico secondario 3 di reparto	A
		/// </summary>
		public char? SINTC3_R { get; set; }

		/// <summary>
		/// Codice della struttura erogatrice esterna di effettuazione dell'intervento chirurgico secondario 3 di reparto
		/// </summary>
		public string? CSINTC3R { get; set; }

		/// <summary>
		/// Data altro intervento chirurgico secondario 4 di reparto
		/// </summary>
		public string? DINTC4_R { get; set; }

		/// <summary>
		/// Altro intervento chirurgico secondario 4 di reparto
		/// </summary>
		public string? CINTC4_R { get; set; }

		/// <summary>
		/// Tipo di struttura erogatrice esterna di effettuazione dell'intervento chirurgico secondario 4 di reparto
		/// </summary>
		public char? SINTC4_R { get; set; }

		/// <summary>
		/// Codice della struttura erogatrice esterna di effettuazione dell'intervento chirurgico secondario 4 di reparto
		/// </summary>
		public string? CSINTC4R { get; set; }

		/// <summary>
		/// Data altro intervento chirurgico secondario 5 di reparto
		/// </summary>
		public string? DINTC5_R { get; set; }

		/// <summary>
		/// Altro intervento chirurgico secondario 5 di reparto
		/// </summary>
		public string? CINTC5_R { get; set; }

		/// <summary>
		/// Tipo di struttura erogatrice esterna di effettuazione dell'intervento chirurgico secondario 5 di reparto
		/// </summary>
		public char? SINTC5_R { get; set; }

		/// <summary>
		/// Codice della struttura erogatrice esterna di effettuazione dell'intervento chirurgico secondario 5 di reparto
		/// </summary>
		public string? CSINTC5R { get; set; }

		/// <summary>
		/// Numero di accessi complessivi in regime diurno
		/// </summary>
		public string? GGANNODH { get; set; }

		/// <summary>
		/// Unità operativa di dimissione
		/// </summary>
		public string REPARTO { get; set; }

		/// <summary>
		/// Modalità di dimissione
		/// </summary>
		public string MOD_DIM { get; set; }

		/// <summary>
		/// Data di uscita dall'unità operativa
		/// </summary>
		public string D_DIMREP { get; set; }

		/// <summary>
		/// Data di dimissione o morte
		/// </summary>
		public string D_DIMOSP { get; set; }

		/// <summary>
		/// Diagnosi principale di dimissione dall'ospedale
		/// </summary>
		public string DIAG_OSP { get; set; }

		/// <summary>
		/// Prima diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public string? C_DIAG1_O { get; set; }

		/// <summary>
		/// Seconda diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public string? C_DIAG2_O { get; set; }

		/// <summary>
		/// Terza diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public string? C_DIAG3_O { get; set; }

		/// <summary>
		/// Quarta diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public string? C_DIAG4_O { get; set; }

		/// <summary>
		/// Quinta diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public string? C_DIAG5_O { get; set; }

		/// <summary>
		/// Data dell'intervento chirurgico principale di dimissione dall'ospedale
		/// </summary>
		public string? DINTCP_O { get; set; }

		/// <summary>
		/// Intervento chirurgico principale di dimissione dall'ospedale
		/// </summary>
		public string? CINTCP_O { get; set; }

		/// <summary>
		/// Altro intervento chirurgico 1 di dimissione dall'ospedale
		/// </summary>
		public string? CINTC1_O { get; set; }

		/// <summary>
		/// Altro intervento chirurgico 2 di dimissione dall'ospedale
		/// </summary>
		public string? CINTC2_O { get; set; }

		/// <summary>
		/// Altro intervento chirurgico 3 di dimissione dall'ospedale
		/// </summary>
		public string? CINTC3_O { get; set; }

		/// <summary>
		/// Altro intervento chirurgico 4 di dimissione dall'ospedale
		/// </summary>
		public string? CINTC4_O { get; set; }

		/// <summary>
		/// Altro intervento chirurgico 5 di dimissione dall'ospedale
		/// </summary>
		public string? CINTC5_O { get; set; }

		/// <summary>
		/// Riscontro autoptico
		/// </summary>
		public char? R_AUTOPT { get; set; }

		/// <summary>
		/// Tipo di medico proponente il ricovero
		/// </summary>
		public char? TIP_PROP { get; set; }

		/// <summary>
		/// Codice del medico proponente il ricovero
		/// </summary>
		public string? MED_PROP { get; set; }

		/// <summary>
		/// Giornate di degenza derogate
		/// </summary>
		public string? GGDEROGA { get; set; }

		/// <summary>
		/// Peso del neonato alla nascita
		/// </summary>
		public string? PESO { get; set; }

		/// <summary>
		/// Data di prenotazione del ricovero
		/// </summary>
		public string? D_PRENOT { get; set; }

		/// <summary>
		/// Tipo esenzione
		/// </summary>
		public char? TP_ESENZ { get; set; }

		/// <summary>
		/// Codice esenzione
		/// </summary>
		public string? CD_ESENZ { get; set; }

		/// <summary>
		/// Importo del ticket di ricovero
		/// </summary>
		public string? I_TICKET { get; set; }

		/// <summary>
		/// Classe
		/// </summary>
		public char CLASSE { get; set; }

		/// <summary>
		/// Giornate di degenza in classe
		/// </summary>
		public string? GGCLASSE { get; set; }

		/// <summary>
		/// Classe di priorità
		/// </summary>
		public char? CL_PRIORITA { get; set; }

		/// <summary>
		/// Classe ASA(rischio anestesiologico)
		/// </summary>
		public char? CL_ASA { get; set; }

		/// <summary>
		/// Codice Categoria diagnostica principale
		/// </summary>
		public string? MDC { get; set; }

		/// <summary>
		/// Codice Diagnosis Related Groups
		/// </summary>
		public string? DRG { get; set; }

		/// <summary>
		/// Tipo Diagnosis Related Groups
		/// </summary>
		public int? DRG_TIPO { get; set; }

		/// <summary>
		/// DRG specifico APR
		/// </summary>
		public string? APR_DRG { get; set; }

		/// <summary>
		/// APR - Tipo
		/// </summary>
		public int? APR_TIPO { get; set; }

		/// <summary>
		/// MDC specifico APR
		/// </summary>
		public string? APR_MDC { get; set; }

		/// <summary>
		/// APR - Severità malattia
		/// </summary>
		public char? APR_SOI { get; set; }

		/// <summary>
		/// APR - Rischio di morte
		/// </summary>
		public char? APR_ROM { get; set; }

		/// <summary>
		/// Tariffa provinciale DRG in Euro
		/// </summary>
		public int? TARPRO_E { get; set; }

		/// <summary>
		/// Tariffa nazionale DRG in Euro
		/// </summary>
		public int? TARNAZ_E { get; set; }

		/// <summary>
		/// Tariffa indiretta DRG in Euro
		/// </summary>
		public string? TARIND_E { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public int? PESO_DRG { get; set; }

		/// <summary>
		/// Giorni soglia
		/// </summary>
		public int? GGSOGLIA { get; set; }

		/// <summary>
		/// Durata della degenza nell'unità operativa
		/// </summary>
		public int? DEG_UO { get; set; }

		/// <summary>
		/// Durata della degenza in ospedale
		/// </summary>
		public int? DEG_OSP { get; set; }

		/// <summary>
		/// Giorni di permesso totali (somma delle giornate di permesso associate al nosografico)
		/// </summary>
		public int? GGPERTOT { get; set; }

		/// <summary>
		/// Importo fattura
		/// </summary>
		public int? IMP_TICKET { get; set; }

		/// <summary>
		/// Pianificazione della dimissione
		/// </summary>
		public char? DIM_PROT { get; set; }

		/// <summary>
		/// Grado di necessità di supporto post ricovero
		/// </summary>
		public char? GRADO_DIM_PROT { get; set; }

		/// <summary>
		/// Causa esterna dei traumatismi, degli avvelenamenti e di altri effetti avversi
		/// </summary>
		public string? CAU_EST { get; set; }

		/// <summary>
		/// Visita anestesiologica
		/// </summary>
		public char VISITA_ANEST { get; set; }

		/// <summary>
		/// Data trasferimento a struttura erogatrice esterna, relativa a intervento chirurgico principale di reparto
		/// </summary>
		public string? D_TR_ST_INTCPR { get; set; }


		/// <summary>
		/// Reparto nella struttura esterna erogatrice della prestazione relativa a intervento chirurgico principale di reparto
		/// </summary>
		public string? REP_ST_INTCPR { get; set; }

		/// <summary>
		/// Data di rientro da struttura erogatrice esterna, relativa a intervento chirurgico principale di reparto
		/// </summary>
		public string? D_RIEN_ST_INTCPR { get; set; }

		/// <summary>
		/// Data trasferimento a struttura erogatrice esterna, relativa ad altro intervento chirurgico 1 di reparto
		/// </summary>
		public string? D_TR_ST_INTC1R { get; set; }

		/// <summary>
		/// Reparto nella struttura esterna erogatrice della prestazione relativa ad altro intervento chirurgico 1 di reparto
		/// </summary>
		public string? REP_ST_INTC1R { get; set; }

		/// <summary>
		/// Data di rientro da struttura erogatrice esterna, relativa ad altro intervento chirurgico 1 di reparto
		/// </summary>
		public string? D_RIEN_ST_INTC1R { get; set; }

		/// <summary>
		/// Data trasferimento a struttura erogatrice esterna, relativa ad altro intervento chirurgico 2 di reparto
		/// </summary>
		public string? D_TR_ST_INTC2R { get; set; }

		/// <summary>
		/// Reparto nella struttura esterna erogatrice della prestazione relativa ad altro intervento chirurgico 2 di reparto
		/// </summary>
		public string? REP_ST_INTC2R { get; set; }

		/// <summary>
		///  Data di rientro da struttura erogatrice esterna, relativa ad altro intervento chirurgico 2 di reparto
		/// </summary>
		public string? D_RIEN_ST_INTC2R { get; set; }

		/// <summary>
		/// Data trasferimento a struttura erogatrice esterna, relativa ad altro intervento chirurgico 3 di reparto
		/// </summary>
		public string? D_TR_ST_INTC3R { get; set; }

		/// <summary>
		/// Reparto nella struttura esterna erogatrice della prestazione relativa ad altro intervento chirurgico 3 di reparto
		/// </summary>
		public string? REP_ST_INTC3R { get; set; }

		/// <summary>
		/// Data di rientro da struttura erogatrice esterna, relativa ad altro intervento chirurgico 3 di reparto
		/// </summary>
		public string? D_RIEN_ST_INTC3R { get; set; }

		/// <summary>
		/// Data trasferimento a struttura erogatrice esterna, relativa ad altro intervento chirurgico 4 di reparto
		/// </summary>
		public string? D_TR_ST_INTC4R { get; set; }

		/// <summary>
		/// Reparto nella struttura esterna erogatrice della prestazione relativa ad altro intervento chirurgico 4 di reparto
		/// </summary>
		public string? REP_ST_INTC4R { get; set; }

		/// <summary>
		/// Data di rientro da struttura erogatrice esterna, relativa ad altro intervento chirurgico 4 di reparto
		/// </summary>
		public string? D_RIEN_ST_INTC4R { get; set; }

		/// <summary>
		/// Data trasferimento a struttura erogatrice esterna, relativa ad altro intervento chirurgico 5 di reparto
		/// </summary>
		public string? D_TR_ST_INTC5R { get; set; }

		/// <summary>
		/// Reparto nella struttura esterna erogatrice della prestazione relativa ad altro intervento chirurgico 5 di reparto
		/// </summary>
		public string? REP_ST_INTC5R { get; set; }

		/// <summary>
		/// Data di rientro da struttura erogatrice esterna, relativa ad altro intervento chirurgico 5 di reparto
		/// </summary>
		public string? D_RIEN_ST_INTC5R { get; set; }

		/// <summary>
		/// Diagnosi principale di dimissione dall'ospedale presente al ricovero
		/// </summary>
		public char DIAG_OSP_PRES { get; set; }

		/// <summary>
		/// Lateralità Diagnosi principale di dimissione dall'ospedale
		/// </summary>
		public char? DIAG_OSP_LAT { get; set; }

		/// <summary>
		/// Prima diagnosi concomitante di dimissione dall'ospedale presente al ricovero
		/// </summary>
		public char? CDIAG1_O_PRES { get; set; }

		/// <summary>
		/// Lateralità prima diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public char? CDIAG1_O_LAT { get; set; }

		/// <summary>
		/// Seconda diagnosi concomitante di dimissione dall'ospedale presente al ricovero
		/// </summary>
		public char? CDIAG2_O_PRES { get; set; }

		/// <summary>
		/// Lateralità seconda diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public char? CDIAG2_O_LAT { get; set; }

		/// <summary>
		/// Terza diagnosi concomitante di dimissione dall'ospedale presente al ricovero
		/// </summary>
		public char? CDIAG3_O_PRES { get; set; }

		/// <summary>
		/// Lateralità terza diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public char? CDIAG3_O_LAT { get; set; }

		/// <summary>
		/// Quarta diagnosi concomitante di dimissione dall'ospedale presente al ricovero
		/// </summary>
		public char? CDIAG4_O_PRES { get; set; }

		/// <summary>
		/// Lateralità quarta diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public char? CDIAG4_O_LAT { get; set; }

		/// <summary>
		/// Quinta diagnosi concomitante di dimissione dall'ospedale presente al ricovero
		/// </summary>
		public char? CDIAG5_O_PRES { get; set; }

		/// <summary>
		/// Lateralità quinta diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public char? CDIAG5_O_LAT { get; set; }

		/// <summary>
		/// Ora intervento chirurgico principale
		/// </summary>
		public string? HINTCP_O { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 intervento chirurgico principale di dimissione
		/// </summary>
		public string? CINTCP_O_CH1 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 intervento chirurgico principale di dimissione (crittografato)
		/// </summary>
		public string? CINTCP_O_CH1_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 intervento chirurgico principale di dimissione
		/// </summary>
		public string? CINTCP_O_CH2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 intervento chirurgico principale di dimissione (crittografato)
		/// </summary>
		public string? CINTCP_O_CH2_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 intervento chirurgico principale di dimissione
		/// </summary>
		public string? CINTCP_O_CH3 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 intervento chirurgico principale di dimissione (crittografato)
		/// </summary>
		public string? CINTCP_O_CH3_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Anestesista dell'intervento chirurgico principale di dimissione
		/// </summary>
		public string? CINTCP_O_ANEST { get; set; }

		/// <summary>
		/// Identificativo Anestesista dell'intervento chirurgico principale di dimissione (crittografato)
		/// </summary>
		public string? CINTCP_O_ANEST_SHA2 { get; set; }

		/// <summary>
		/// Check List sala operatoria intervento chirurgico principale di dimissione
		/// </summary>
		public char? CINTCP_O_CHKLST { get; set; }

		/// <summary>
		/// Lateralità dell'intervento chirurgico principale di dimissione dall'ospedale
		/// </summary>
		public char? CINTCP_O_LAT { get; set; }

		/// <summary>
		/// Data dell'altro intervento chirurgico 1 di dimissione dall'ospedale
		/// </summary>
		public string? DINTC1_O { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 1 di dimissione
		/// </summary>
		public string? CINTC1_O_CH1 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 1 di dimissione (crittografato)
		/// </summary>
		public string? CINTC1_O_CH1_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 1 di dimissione
		/// </summary>
		public string? CINTC1_O_CH2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 1 di dimissione (crittografato)
		/// </summary>
		public string? CINTC1_O_CH2_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 1 di dimissione
		/// </summary>
		public string? CINTC1_O_CH3 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 1 di dimissione (crittografato)
		/// </summary>
		public string? CINTC1_O_CH3_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 1 di dimissione
		/// </summary>
		public string? CINTC1_O_ANEST { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 1 di dimissione (crittografato)
		/// </summary>
		public string? CINTC1_O_ANEST_SHA2 { get; set; }

		/// <summary>
		/// Check List sala operatoria di altro intervento chirurgico 1 di dimissione
		/// </summary>
		public char? CINTC1_O_CHKLST { get; set; }

		/// <summary>
		/// Lateralità altro intervento chirurgico 1 di dimissione dall'ospedale
		/// </summary>
		public char? CINTC1_O_LAT { get; set; }

		/// <summary>
		/// Data dell'altro intervento chirurgico 2 di dimissione dall'ospedale
		/// </summary>
		public string? DINTC2_O { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 2 di dimissione
		/// </summary>
		public string? CINTC2_O_CH1 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 2 di dimissione
		/// </summary>
		public string? CINTC2_O_CH1_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 2 di dimissione
		/// </summary>
		public string? CINTC2_O_CH2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 2 di dimissione (crittografato)
		/// </summary>
		public string? CINTC2_O_CH2_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 2 di dimissione
		/// </summary>
		public string? CINTC2_O_CH3 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 2 di dimissione (crittografato)
		/// </summary>
		public string? CINTC2_O_CH3_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 2 di dimissione
		/// </summary>
		public string? CINTC2_O_ANEST { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 2 di dimissione (crittografato)
		/// </summary>
		public string? CINTC2_O_ANEST_SHA2 { get; set; }

		/// <summary>
		/// Check List sala operatoria di altro intervento chirurgico 2 di dimissione
		/// </summary>
		public char? CINTC2_O_CHKLST { get; set; }

		/// <summary>
		/// Lateralità altro intervento chirurgico 2 di dimissione dall'ospedale
		/// </summary>
		public string? CINTC2_O_LAT { get; set; }

		/// <summary>
		/// Data dell'altro intervento chirurgico 3 di dimissione dall'ospedale
		/// </summary>
		public string? DINTC3_O { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 3 di dimissione
		/// </summary>
		public string? CINTC3_O_CH1 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 3 di dimissione (crittografato)
		/// </summary>
		public string? CINTC3_O_CH1_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 3 di dimissione
		/// </summary>
		public string? CINTC3_O_CH2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 3 di dimissione (crittografato)
		/// </summary>
		public string? CINTC3_O_CH2_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 3 di dimissione
		/// </summary>
		public string? CINTC3_O_CH3 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 3 di dimissione (crittografato)
		/// </summary>
		public string? CINTC3_O_CH3_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 3 di dimissione
		/// </summary>
		public string? CINTC3_O_ANEST { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 3 di dimissione (crittografato)
		/// </summary>
		public string? CINTC3_O_ANEST_SHA2 { get; set; }

		/// <summary>
		/// Check List sala operatoria di altro intervento chirurgico 3 di dimissione
		/// </summary>
		public char? CINTC3_O_CHKLST { get; set; }

		/// <summary>
		/// Lateralità altro intervento chirurgico 3 di dimissione dall'ospedale
		/// </summary>
		public string? CINTC3_O_LAT { get; set; }

		/// <summary>
		/// Data dell'altro intervento chirurgico 4 di dimissione dall'ospedale
		/// </summary>
		public string? DINTC4_O { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 4 di dimissione
		/// </summary>
		public string? CINTC4_O_CH1 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 4 di dimissione (crittografato)
		/// </summary>
		public string? CINTC4_O_CH1_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 4 di dimissione
		/// </summary>
		public string? CINTC4_O_CH2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 4 di dimissione (crittografato)
		/// </summary>
		public string? CINTC4_O_CH2_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 4 di dimissione
		/// </summary>
		public string? CINTC4_O_CH3 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 4 di dimissione (crittografato)
		/// </summary>
		public string? CINTC4_O_CH3_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 4 di dimissione
		/// </summary>
		public string? CINTC4_O_ANEST { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 4 di dimissione (crittografato)
		/// </summary>
		public string? CINTC4_O_ANEST_SHA2 { get; set; }

		/// <summary>
		/// Check List sala operatoria di altro intervento chirurgico 4 di dimissione
		/// </summary>
		public char? CINTC4_O_CHKLST { get; set; }

		/// <summary>
		/// Lateralità altro intervento chirurgico 4 di dimissione dall'ospedale
		/// </summary>
		public char? CINTC4_O_LAT { get; set; }

		/// <summary>
		/// Data dell'altro intervento chirurgico 5 di dimissione dall'ospedale
		/// </summary>
		public string? DINTC5_O { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 5 di dimissione
		/// </summary>
		public string? CINTC5_O_CH1 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 5 di dimissione
		/// </summary>
		public string? CINTC5_O_CH1_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 5 di dimissione
		/// </summary>
		public string? CINTC5_O_CH2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 5 di dimissione (crittografato)
		/// </summary>
		public string? CINTC5_O_CH2_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 5 di dimissione
		/// </summary>
		public string? CINTC5_O_CH3 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 5 di dimissione (crittografato)
		/// </summary>
		public string? CINTC5_O_CH3_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 5 di dimissione
		/// </summary>
		public string? CINTC5_O_ANEST { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 5 di dimissione (crittografato)
		/// </summary>
		public string? CINTC5_O_ANEST_SHA2 { get; set; }

		/// <summary>
		/// Check List sala operatoria di altro intervento chirurgico 5 di dimissione
		/// </summary>
		public char? CINTC5_O_CHKLST { get; set; }

		/// <summary>
		/// Lateralità altro intervento chirurgico 5 di dimissione dall'ospedale
		/// </summary>
		public char? CINTC5_O_LAT { get; set; }

		/// <summary>
		/// Altro intervento chirurgico 6 di dimissione dall'ospedale
		/// </summary>
		public string? CINTC6_O { get; set; }

		/// <summary>
		/// Data dell'altro intervento chirurgico 6 di dimissione dall'ospedale
		/// </summary>
		public string? DINTC6_O { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 6 di dimissione
		/// </summary>
		public string? CINTC6_O_CH1 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 6 di dimissione (crittografato)
		/// </summary>
		public string? CINTC6_O_CH1_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 6 di dimissione
		/// </summary>
		public string? CINTC6_O_CH2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 6 di dimissione (crittografato)
		/// </summary>
		public string? CINTC6_O_CH2_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 6 di dimissione
		/// </summary>
		public string? CINTC6_O_CH3 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 6 di dimissione (crittografato)
		/// </summary>
		public string? CINTC6_O_CH3_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 6 di dimissione
		/// </summary>
		public string? CINTC6_O_ANEST { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 6 di dimissione (crittografato)
		/// </summary>
		public string? CINTC6_O_ANEST_SHA2 { get; set; }

		/// <summary>
		/// Check List sala operatoria di altro intervento chirurgico 6 di dimissione
		/// </summary>
		public char? CINTC6_O_CHKLST { get; set; }

		/// <summary>
		/// Lateralità altro intervento chirurgico 6 di dimissione dall'ospedale
		/// </summary>
		public char? CINTC6_O_LAT { get; set; }

		/// <summary>
		/// Altro intervento chirurgico 7 di dimissione dall'ospedale
		/// </summary>
		public string? CINTC7_O { get; set; }

		/// <summary>
		/// Data dell'altro intervento chirurgico 7 di dimissione dall'ospedale
		/// </summary>
		public string? DINTC7_O { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 7 di dimissione
		/// </summary>
		public string? CINTC7_O_CH1 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 7 di dimissione (crittografato)
		/// </summary>
		public string? CINTC7_O_CH1_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 7 di dimissione
		/// </summary>
		public string? CINTC7_O_CH2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 7 di dimissione (crittografato)
		/// </summary>
		public string? CINTC7_O_CH2_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 7 di dimissione
		/// </summary>
		public string? CINTC7_O_CH3 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 7 di dimissione (crittografato)
		/// </summary>
		public string? CINTC7_O_CH3_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 7 di dimissione
		/// </summary>
		public string? CINTC7_O_ANEST { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 7 di dimissione (crittografato)
		/// </summary>
		public string? CINTC7_O_ANEST_SHA2 { get; set; }

		/// <summary>
		/// Check List sala operatoria di altro intervento chirurgico 7 di dimissione
		/// </summary>
		public char? CINTC7_O_CHKLST { get; set; }

		/// <summary>
		/// Lateralità altro intervento chirurgico 7 di dimissione dall'ospedale
		/// </summary>
		public char? CINTC7_O_LAT { get; set; }

		/// <summary>
		/// Altro intervento chirurgico 8 di dimissione dall'ospedale
		/// </summary>
		public string? CINTC8_O { get; set; }

		/// <summary>
		/// Data dell'altro intervento chirurgico 8 di dimissione dall'ospedale
		/// </summary>
		public string? DINTC8_O { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 8 di dimissione
		/// </summary>
		public string? CINTC8_O_CH1 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 8 di dimissione (crittografato)
		/// </summary>
		public string? CINTC8_O_CH1_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 8 di dimissione
		/// </summary>
		public string? CINTC8_O_CH2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 8 di dimissione (crittografato)
		/// </summary>
		public string? CINTC8_O_CH2_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 8 di dimissione
		/// </summary>
		public string? CINTC8_O_CH3 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 8 di dimissione (crittografato)
		/// </summary>
		public string? CINTC8_O_CH3_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 8 di dimissione
		/// </summary>
		public string? CINTC8_O_ANEST { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 8 di dimissione (crittografato)
		/// </summary>
		public string? CINTC8_O_ANEST_SHA2 { get; set; }

		/// <summary>
		/// Check List sala operatoria di altro intervento chirurgico 8 di dimissione
		/// </summary>
		public char? CINTC8_O_CHKLST { get; set; }

		/// <summary>
		/// Lateralità altro intervento chirurgico 8 di dimissione dall'ospedale
		/// </summary>
		public string? CINTC8_O_LAT { get; set; }

		/// <summary>
		/// Altro intervento chirurgico 9 di dimissione dall'ospedale
		/// </summary>
		public string? CINTC9_O { get; set; }

		/// <summary>
		/// Data dell'altro intervento chirurgico 9 di dimissione dall'ospedale
		/// </summary>
		public string? DINTC9_O { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 9 di dimissione
		/// </summary>
		public string? CINTC9_O_CH1 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 9 di dimissione (crittografato)
		/// </summary>
		public string? CINTC9_O_CH1_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 9 di dimissione 
		/// </summary>
		public string? CINTC9_O_CH2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 9 di dimissione (crittografato)
		/// </summary>
		public string? CINTC9_O_CH2_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 9 di dimissione
		/// </summary>
		public string? CINTC9_O_CH3 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 9 di dimissione (crittografato)
		/// </summary>
		public string? CINTC9_O_CH3_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 9 di dimissione
		/// </summary>
		public string? CINTC9_O_ANEST { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 9 di dimissione (crittografato)
		/// </summary>
		public string? CINTC9_O_ANEST_SHA2 { get; set; }

		/// <summary>
		/// Check List sala operatoria di altro intervento chirurgico 9 di dimissione
		/// </summary>
		public char? CINTC9_O_CHKLST { get; set; }

		/// <summary>
		/// Lateralità altro intervento chirurgico 9 di dimissione dall'ospedale
		/// </summary>
		public char? CINTC9_O_LAT { get; set; }

		/// <summary>
		/// Altro intervento chirurgico 10 di dimissione dall'ospedale
		/// </summary>
		public string? CINTC10_O { get; set; }

		/// <summary>
		/// Data dell'altro intervento chirurgico 10 di dimissione dall'ospedale
		/// </summary>
		public string? DINTC10_O { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 10 di dimissione
		/// </summary>
		public string? CINTC10_O_CH1 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 10 di dimissione (crittografato)
		/// </summary>
		public string? CINTC10_O_CH1_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 10 di dimissione
		/// </summary>
		public string? CINTC10_O_CH2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 10 di dimissione (crittografato)
		/// </summary>
		public string? CINTC10_O_CH2_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 10 di dimissione
		/// </summary>
		public string? CINTC10_O_CH3 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 10 di dimissione (crittografato)
		/// </summary>
		public string? CINTC10_O_CH3_SHA2 { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 10 di dimissione
		/// </summary>
		public string? CINTC10_O_ANEST { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 10 di dimissione (crittografato)
		/// </summary>
		public string? CINTC10_O_ANEST_SHA2 { get; set; }

		/// <summary>
		/// Check List sala operatoria di altro intervento chirurgico 10 di dimissione
		/// </summary>
		public char? CINTC10_O_CHKLS { get; set; }

		/// <summary>
		/// Lateralità altro intervento chirurgico 10 di dimissione dall'ospedale
		/// </summary>
		public char? CINTC10_O_LAT { get; set; }

		/// <summary>
		/// Rilevazione del dolore
		/// </summary>
		public char DOLORE { get; set; }

		/// <summary>
		/// Stadiazione condensata della Diagnosi principale di dimissione dall'ospedale
		/// </summary>
		public char? DIAG_OSP_STCND { get; set; }

		/// <summary>
		/// Stadiazione condensata della prima Diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public char? CDIAG1_O_STCND { get; set; }

		/// <summary>
		/// Stadiazione condensata della seconda Diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public char? CDIAG2_O_STCND { get; set; }

		/// <summary>
		/// Stadiazione condensata della terza Diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public char? CDIAG3_O_STCND { get; set; }

		/// <summary>
		/// Stadiazione condensata della quarta Diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public char? CDIAG4_O_STCND { get; set; }

		/// <summary>
		/// Stadiazione condensata della quinta Diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public char? CDIAG5_O_STCND { get; set; }

		/// <summary>
		/// Pressione arteriosa sistolica
		/// </summary>
		public string? PRESS_ART { get; set; }

		/// <summary>
		/// Creatinina serica
		/// </summary>
		public string? CREAT { get; set; }

		/// <summary>
		/// Frazione di eiezione
		/// </summary>
		public string? FRAZ_EI { get; set; }
	}
}
