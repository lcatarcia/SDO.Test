using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SDO.Infrastructure.Sql.Models
{
	/// <summary>
	/// Contiene i dati clinici degli assistiti relativamente al flusso SDO, provenienti dalla bronze zone.	La tabella è presente nel modello dati AS IS
	/// </summary>
	internal class CART_INPUT_RICOVERI_CLIN
	{
		/// <summary>
		/// Identificativo univoco di tabella
		/// </summary>
		public int SIRC_ID { get; set; }

		/// <summary>
		/// Identificativo della spedizione
		/// </summary>
		public int SIRC_INSP_ID { get; set; }

		/// <summary>
		/// Regime di ricovero A
		/// </summary>
		public char SIRC_REGRIC { get; set; }

		/// <summary>
		/// Nosografico
		/// </summary>
		public int SIRC_NOSOGRAF { get; set; }

		/// <summary>
		/// N.ro scheda di reparto
		/// </summary>
		public int SIRC_NR_SCHED { get; set; }

		/// <summary>
		/// Data del ricovero in ospedale
		/// </summary>
		public string SIRC_D_RICOSP { get; set; }

		/// <summary>
		/// Unità operativa di ammissione
		/// </summary>
		public string SIRC_REP_AMM { get; set; }

		/// <summary>
		/// Unità operativa di ricovero fisico per la lungodegenza post acuta
		/// </summary>
		public string SIRC_REP_LUNG { get; set; }

		/// <summary>
		/// Onere della degenza
		/// </summary>
		public char SIRC_ONER_DEG { get; set; }

		/// <summary>
		/// Provenienza del paziente
		/// </summary>
		public char SIRC_PROVENIE { get; set; }

		/// <summary>
		/// Tipo di ricovero
		/// </summary>
		public char SIRC_TIPO_RIC { get; set; }

		/// <summary>
		/// Motivo del ricovero in regime diurno
		/// </summary>
		public char? SIRC_MOTIV_DH { get; set; }

		/// <summary>
		/// Data del ricovero nell'unità operativa
		/// </summary>
		public string SIRC_D_RICREP { get; set; }

		/// <summary>
		/// Giorni di permesso del reparto
		/// </summary>
		public string? SIRC_GGPERM { get; set; }

		/// <summary>
		/// Traumatismi e intossicazioni
		/// </summary>
		public char? SIRC_TRAUMATI { get; set; }

		/// <summary>
		/// Diagnosi principale di reparto
		/// </summary>
		public string SIRC_DIAG_REP { get; set; }

		/// <summary>
		/// Prima diagnosi concomitante di reparto
		/// </summary>
		public string? SIRC_C_DIAG1 { get; set; }

		/// <summary>
		/// Seconda diagnosi concomitante di reparto
		/// </summary>
		public string? SIRC_C_DIAG2 { get; set; }

		/// <summary>
		/// Terza diagnosi concomitante di reparto
		/// </summary>
		public string? SIRC_C_DIAG3 { get; set; }

		/// <summary>
		/// Quarta diagnosi concomitante di reparto
		/// </summary>
		public string? SIRC_C_DIAG4 { get; set; }

		/// <summary>
		/// Quinta diagnosi concomitante di reparto
		/// </summary>
		public string? SIRC_C_DIAG5 { get; set; }

		/// <summary>
		/// Data dell'intervento chirurgico principale di reparto
		/// </summary>
		public string? SIRC_DINTCP_R { get; set; }

		/// <summary>
		/// Intervento chirurgico principale di reparto
		/// </summary>
		public string? SIRC_CINTCP_R { get; set; }

		/// <summary>
		/// Tipo di struttura erogatrice esterna di effettuazione dell'intervento chirurgico principale
		/// </summary>
		public char? SIRC_SINTCP_R { get; set; }

		/// <summary>
		/// Codice della struttura erogatrice esterna di effettuazionedell'intervento chirurgico principale
		/// </summary>
		public string? SIRC_CSINTCPR { get; set; }

		/// <summary>
		/// Data altro intervento chirurgico secondario direparto
		/// </summary>
		public string? SIRC_DINTC1_R { get; set; }

		/// <summary>
		/// Altro intervento chirurgico secondario 1 di reparto
		/// </summary>
		public string? SIRC_CINTC1_R { get; set; }

		/// <summary>
		/// Tipo di struttura erogatrice esterna di effettuazionedell'intervento chirurgico secondario 1 di reparto
		/// </summary>
		public char? SIRC_SINTC1_R { get; set; }

		/// <summary>
		/// Codice della struttura erogatrice esterna di effettuazionedell'intervento chirurgico secondario 1 di reparto
		/// </summary>
		public string? SIRC_CSINTC1R { get; set; }

		/// <summary>
		/// Data altro intervento chirurgico secondario 2 di reparto
		/// </summary>
		public string? SIRC_DINTC2_R { get; set; }

		/// <summary>
		/// Altro intervento chirurgico secondario 2 di reparto
		/// </summary>
		public string? SIRC_CINTC2_R { get; set; }

		/// <summary>
		/// Tipo di struttura erogatrice esterna di effettuazione dell'intervento chirurgico secondario 2 di reparto
		/// </summary>
		public char? SIRC_SINTC2_R { get; set; }

		/// <summary>
		/// Codice della struttura erogatrice esterna di effettuazione dell'intervento chirurgico secondario 2 di reparto
		/// </summary>
		public string? SIRC_CSINTC2R { get; set; }

		/// <summary>
		/// Data altro intervento chirurgico secondario 3 di reparto
		/// </summary>
		public string? SIRC_DINTC3_R { get; set; }

		/// <summary>
		/// Altro intervento chirurgico secondario 3 di reparto
		/// </summary>
		public string? SIRC_CINTC3_R { get; set; }

		/// <summary>
		/// Tipo di struttura erogatrice esterna di effettuazione dell'intervento chirurgico secondario 3 di reparto	A
		/// </summary>
		public char? SIRC_SINTC3_R { get; set; }

		/// <summary>
		/// Codice della struttura erogatrice esterna di effettuazione dell'intervento chirurgico secondario 3 di reparto
		/// </summary>
		public string? SIRC_CSINTC3R { get; set; }

		/// <summary>
		/// Data altro intervento chirurgico secondario 4 di reparto
		/// </summary>
		public string? SIRC_DINTC4_R { get; set; }

		/// <summary>
		/// Altro intervento chirurgico secondario 4 di reparto
		/// </summary>
		public string? SIRC_CINTC4_R { get; set; }

		/// <summary>
		/// Tipo di struttura erogatrice esterna di effettuazione dell'intervento chirurgico secondario 4 di reparto
		/// </summary>
		public char? SIRC_SINTC4_R { get; set; }

		/// <summary>
		/// Codice della struttura erogatrice esterna di effettuazione dell'intervento chirurgico secondario 4 di reparto
		/// </summary>
		public string? SIRC_CSINTC4R { get; set; }

		/// <summary>
		/// Data altro intervento chirurgico secondario 5 di reparto
		/// </summary>
		public string? SIRC_DINTC5_R { get; set; }

		/// <summary>
		/// Altro intervento chirurgico secondario 5 di reparto
		/// </summary>
		public string? SIRC_CINTC5_R { get; set; }

		/// <summary>
		/// Tipo di struttura erogatrice esterna di effettuazione dell'intervento chirurgico secondario 5 di reparto
		/// </summary>
		public char? SIRC_SINTC5_R { get; set; }

		/// <summary>
		/// Codice della struttura erogatrice esterna di effettuazione dell'intervento chirurgico secondario 5 di reparto
		/// </summary>
		public string? SIRC_CSINTC5R { get; set; }

		/// <summary>
		/// Numero di accessi complessivi in regime diurno
		/// </summary>
		public string? SIRC_GGANNODH { get; set; }

		/// <summary>
		/// Unità operativa di dimissione
		/// </summary>
		public string SIRC_REPARTO { get; set; }

		/// <summary>
		/// Modalità di dimissione
		/// </summary>
		public string SIRC_MOD_DIM { get; set; }

		/// <summary>
		/// Data di uscita dall'unità operativa
		/// </summary>
		public string SIRC_D_DIMREP { get; set; }

		/// <summary>
		/// Data di dimissione o morte
		/// </summary>
		public string SIRC_D_DIMOSP { get; set; }

		/// <summary>
		/// Diagnosi principale di dimissione dall'ospedale
		/// </summary>
		public string SIRC_DIAG_OSP { get; set; }

		/// <summary>
		/// Prima diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_C_DIAG1_O { get; set; }

		/// <summary>
		/// Seconda diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_C_DIAG2_O { get; set; }

		/// <summary>
		/// Terza diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_C_DIAG3_O { get; set; }

		/// <summary>
		/// Quarta diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_C_DIAG4_O { get; set; }

		/// <summary>
		/// Quinta diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_C_DIAG5_O { get; set; }

		/// <summary>
		/// Data dell'intervento chirurgico principale di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_DINTCP_O { get; set; }

		/// <summary>
		/// Intervento chirurgico principale di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_CINTCP_O { get; set; }

		/// <summary>
		/// Altro intervento chirurgico 1 di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_CINTC1_O { get; set; }

		/// <summary>
		/// Altro intervento chirurgico 2 di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_CINTC2_O { get; set; }

		/// <summary>
		/// Altro intervento chirurgico 3 di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_CINTC3_O { get; set; }

		/// <summary>
		/// Altro intervento chirurgico 4 di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_CINTC4_O { get; set; }

		/// <summary>
		/// Altro intervento chirurgico 5 di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_CINTC5_O { get; set; }

		/// <summary>
		/// Riscontro autoptico
		/// </summary>
		public char? SIRC_R_AUTOPT { get; set; }

		/// <summary>
		/// Tipo di medico proponente il ricovero
		/// </summary>
		public char? SIRC_TIP_PROP { get; set; }

		/// <summary>
		/// Codice del medico proponente il ricovero
		/// </summary>
		public string? SIRC_MED_PROP { get; set; }

		/// <summary>
		/// Giornate di degenza derogate
		/// </summary>
		public string? SIRC_GGDEROGA { get; set; }

		/// <summary>
		/// Peso del neonato alla nascita
		/// </summary>
		public string? SIRC_PESO { get; set; }

		/// <summary>
		/// Data di prenotazione del ricovero
		/// </summary>
		public string? SIRC_D_PRENOT { get; set; }

		/// <summary>
		/// Tipo esenzione
		/// </summary>
		public char? SIRC_TP_ESENZ { get; set; }

		/// <summary>
		/// Codice esenzione
		/// </summary>
		public string? SIRC_CD_ESENZ { get; set; }

		/// <summary>
		/// Importo del ticket di ricovero
		/// </summary>
		public string? SIRC_I_TICKET { get; set; }

		/// <summary>
		/// Classe
		/// </summary>
		public char SIRC_CLASSE { get; set; }

		/// <summary>
		/// Giornate di degenza in classe
		/// </summary>
		public string? SIRC_GGCLASSE { get; set; }

		/// <summary>
		/// Classe di priorità
		/// </summary>
		public char? SIRC_CL_PRIORITA { get; set; }

		/// <summary>
		/// Classe ASA(rischio anestesiologico)
		/// </summary>
		public char? SIRC_CL_ASA { get; set; }

		/// <summary>
		/// Pianificazione della dimissione
		/// </summary>
		public char? SIRC_DIM_PROT { get; set; }

		/// <summary>
		/// Grado di necessità di supporto post ricovero
		/// </summary>
		public char? SIRC_GRADO_DIM_PROT { get; set; }

		/// <summary>
		/// Causa esterna dei traumatismi, degli avvelenamenti e di altri effetti avversi
		/// </summary>
		public string? SIRC_CAU_EST { get; set; }

		/// <summary>
		/// Visita anestesiologica
		/// </summary>
		public char SIRC_VISITA_ANEST { get; set; }

		/// <summary>
		/// Data trasferimento a struttura erogatrice esterna, relativa a intervento chirurgico principale di reparto
		/// </summary>
		public string? SIRC_D_TR_ST_INTCPR { get; set; }

		/// <summary>
		/// Codice istituto
		/// </summary>
		public string SIRC_ISTITUTO { get; set; }

		/// <summary>
		/// Reparto nella struttura esterna erogatrice della prestazione relativa a intervento chirurgico principale di reparto
		/// </summary>
		public string? SIRC_REP_ST_INTCPR { get; set; }

		/// <summary>
		/// Data di rientro da struttura erogatrice esterna, relativa a intervento chirurgico principale di reparto
		/// </summary>
		public string? SIRC_D_RIEN_ST_INTCPR { get; set; }

		/// <summary>
		/// Data trasferimento a struttura erogatrice esterna, relativa ad altro intervento chirurgico 1 di reparto
		/// </summary>
		public string? SIRC_D_TR_ST_INTC1R { get; set; }

		/// <summary>
		/// Reparto nella struttura esterna erogatrice della prestazione relativa ad altro intervento chirurgico 1 di reparto
		/// </summary>
		public string? SIRC_REP_ST_INTC1R { get; set; }

		/// <summary>
		/// Data di rientro da struttura erogatrice esterna, relativa ad altro intervento chirurgico 1 di reparto
		/// </summary>
		public string? SIRC_D_RIEN_ST_INTC1R { get; set; }

		/// <summary>
		/// Data trasferimento a struttura erogatrice esterna, relativa ad altro intervento chirurgico 2 di reparto
		/// </summary>
		public string? SIRC_D_TR_ST_INTC2R { get; set; }

		/// <summary>
		/// Reparto nella struttura esterna erogatrice della prestazione relativa ad altro intervento chirurgico 2 di reparto
		/// </summary>
		public string? SIRC_REP_ST_INTC2R { get; set; }

		/// <summary>
		///  Data di rientro da struttura erogatrice esterna, relativa ad altro intervento chirurgico 2 di reparto
		/// </summary>
		public string? SIRC_D_RIEN_ST_INTC2R { get; set; }

		/// <summary>
		/// Data trasferimento a struttura erogatrice esterna, relativa ad altro intervento chirurgico 3 di reparto
		/// </summary>
		public string? SIRC_D_TR_ST_INTC3R { get; set; }

		/// <summary>
		/// Reparto nella struttura esterna erogatrice della prestazione relativa ad altro intervento chirurgico 3 di reparto
		/// </summary>
		public string? SIRC_REP_ST_INTC3R { get; set; }

		/// <summary>
		/// Data di rientro da struttura erogatrice esterna, relativa ad altro intervento chirurgico 3 di reparto
		/// </summary>
		public string? SIRC_D_RIEN_ST_INTC3R { get; set; }

		/// <summary>
		/// Data trasferimento a struttura erogatrice esterna, relativa ad altro intervento chirurgico 4 di reparto
		/// </summary>
		public string? SIRC_D_TR_ST_INTC4R { get; set; }

		/// <summary>
		/// Reparto nella struttura esterna erogatrice della prestazione relativa ad altro intervento chirurgico 4 di reparto
		/// </summary>
		public string? SIRC_REP_ST_INTC4R { get; set; }

		/// <summary>
		/// Data di rientro da struttura erogatrice esterna, relativa ad altro intervento chirurgico 4 di reparto
		/// </summary>
		public string? SIRC_D_RIEN_ST_INTC4R { get; set; }

		/// <summary>
		/// Data trasferimento a struttura erogatrice esterna, relativa ad altro intervento chirurgico 5 di reparto
		/// </summary>
		public string? SIRC_D_TR_ST_INTC5R { get; set; }

		/// <summary>
		/// Reparto nella struttura esterna erogatrice della prestazione relativa ad altro intervento chirurgico 5 di reparto
		/// </summary>
		public string? SIRC_REP_ST_INTC5R { get; set; }

		/// <summary>
		/// Data di rientro da struttura erogatrice esterna, relativa ad altro intervento chirurgico 5 di reparto
		/// </summary>
		public string? SIRC_D_RIEN_ST_INTC5R { get; set; }

		/// <summary>
		/// Diagnosi principale di dimissione dall'ospedale presente al ricovero
		/// </summary>
		public char SIRC_DIAG_OSP_PRES { get; set; }

		/// <summary>
		/// Lateralità Diagnosi principale di dimissione dall'ospedale
		/// </summary>
		public char? SIRC_DIAG_OSP_LAT { get; set; }

		/// <summary>
		/// Prima diagnosi concomitante di dimissione dall'ospedale presente al ricovero
		/// </summary>
		public char? SIRC_CDIAG1_O_PRES { get; set; }

		/// <summary>
		/// Lateralità prima diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public char? SIRC_CDIAG1_O_LAT { get; set; }

		/// <summary>
		/// Seconda diagnosi concomitante di dimissione dall'ospedale presente al ricovero
		/// </summary>
		public char? SIRC_CDIAG2_O_PRES { get; set; }

		/// <summary>
		/// Lateralità seconda diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public char? SIRC_CDIAG2_O_LAT { get; set; }

		/// <summary>
		/// Terza diagnosi concomitante di dimissione dall'ospedale presente al ricovero
		/// </summary>
		public char? SIRC_CDIAG3_O_PRES { get; set; }

		/// <summary>
		/// Lateralità terza diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public char? SIRC_CDIAG3_O_LAT { get; set; }

		/// <summary>
		/// Quarta diagnosi concomitante di dimissione dall'ospedale presente al ricovero
		/// </summary>
		public char? SIRC_CDIAG4_O_PRES { get; set; }

		/// <summary>
		/// Lateralità quarta diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public char? SIRC_CDIAG4_O_LAT { get; set; }

		/// <summary>
		/// Quinta diagnosi concomitante di dimissione dall'ospedale presente al ricovero
		/// </summary>
		public char? SIRC_CDIAG5_O_PRES { get; set; }

		/// <summary>
		/// Lateralità quinta diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public char? SIRC_CDIAG5_O_LAT { get; set; }

		/// <summary>
		/// Ora intervento chirurgico principale
		/// </summary>
		public string? SIRC_HINTCP_O { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 intervento chirurgico principale di dimissione
		/// </summary>
		public string? SIRC_CINTCP_O_CH1 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 intervento chirurgico principale di dimissione
		/// </summary>
		public string? SIRC_CINTCP_O_CH2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 intervento chirurgico principale di dimissione
		/// </summary>
		public string? SIRC_CINTCP_O_CH3 { get; set; }

		/// <summary>
		/// Identificativo Anestesista dell'intervento chirurgico principale di dimissione
		/// </summary>
		public string? SIRC_CINTCP_O_ANEST { get; set; }

		/// <summary>
		/// Check List sala operatoria intervento chirurgico principale di dimissione
		/// </summary>
		public char? SIRC_CINTCP_O_CHKLST { get; set; }

		/// <summary>
		/// Lateralità dell'intervento chirurgico principale di dimissione dall'ospedale
		/// </summary>
		public char? SIRC_CINTCP_O_LAT { get; set; }

		/// <summary>
		/// Data dell'altro intervento chirurgico 1 di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_DINTC1_O { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 1 di dimissione
		/// </summary>
		public string? SIRC_CINTC1_O_CH1 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 1 di dimissione
		/// </summary>
		public string? SIRC_CINTC1_O_CH2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 1 di dimissione
		/// </summary>
		public string? SIRC_CINTC1_O_CH3 { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 1 di dimissione
		/// </summary>
		public string? SIRC_CINTC1_O_ANEST { get; set; }

		/// <summary>
		/// Check List sala operatoria di altro intervento chirurgico 1 di dimissione
		/// </summary>
		public char? SIRC_CINTC1_O_CHKLST { get; set; }

		/// <summary>
		/// Lateralità altro intervento chirurgico 1 di dimissione dall'ospedale
		/// </summary>
		public char? SIRC_CINTC1_O_LAT { get; set; }

		/// <summary>
		/// Data dell'altro intervento chirurgico 2 di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_DINTC2_O { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 2 di dimissione
		/// </summary>
		public string? SIRC_CINTC2_O_CH1 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 2 di dimissione
		/// </summary>
		public string? SIRC_CINTC2_O_CH2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 2 di dimissione
		/// </summary>
		public string? SIRC_CINTC2_O_CH3 { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 2 di dimissione
		/// </summary>
		public string? SIRC_CINTC2_O_ANEST { get; set; }

		/// <summary>
		/// Check List sala operatoria di altro intervento chirurgico 2 di dimissione
		/// </summary>
		public char? SIRC_CINTC2_O_CHKLST { get; set; }

		/// <summary>
		/// Lateralità altro intervento chirurgico 2 di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_CINTC2_O_LAT { get; set; }

		/// <summary>
		/// Data dell'altro intervento chirurgico 3 di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_DINTC3_O { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 3 di dimissione
		/// </summary>
		public string? SIRC_CINTC3_O_CH1 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 3 di dimissione
		/// </summary>
		public string? SIRC_CINTC3_O_CH2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 3 di dimissione
		/// </summary>
		public string? SIRC_CINTC3_O_CH3 { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 3 di dimissione
		/// </summary>
		public string? SIRC_CINTC3_O_ANEST { get; set; }

		/// <summary>
		/// Check List sala operatoria di altro intervento chirurgico 3 di dimissione
		/// </summary>
		public char? SIRC_CINTC3_O_CHKLST { get; set; }

		/// <summary>
		/// Lateralità altro intervento chirurgico 3 di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_CINTC3_O_LAT { get; set; }

		/// <summary>
		/// Data dell'altro intervento chirurgico 4 di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_DINTC4_O { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 4 di dimissione
		/// </summary>
		public string? SIRC_CINTC4_O_CH1 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 4 di dimissione
		/// </summary>
		public string? SIRC_CINTC4_O_CH2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 4 di dimissione
		/// </summary>
		public string? SIRC_CINTC4_O_CH3 { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 4 di dimissione
		/// </summary>
		public string? SIRC_CINTC4_O_ANEST { get; set; }

		/// <summary>
		/// Check List sala operatoria di altro intervento chirurgico 4 di dimissione
		/// </summary>
		public char? SIRC_CINTC4_O_CHKLST { get; set; }

		/// <summary>
		/// Lateralità altro intervento chirurgico 4 di dimissione dall'ospedale
		/// </summary>
		public char? SIRC_CINTC4_O_LAT { get; set; }

		/// <summary>
		/// Data dell'altro intervento chirurgico 5 di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_DINTC5_O { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 5 di dimissione
		/// </summary>
		public string? SIRC_CINTC5_O_CH1 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 5 di dimissione
		/// </summary>
		public string? SIRC_CINTC5_O_CH2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 5 di dimissione
		/// </summary>
		public string? SIRC_CINTC5_O_CH3 { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 5 di dimissione
		/// </summary>
		public string? SIRC_CINTC5_O_ANEST { get; set; }

		/// <summary>
		/// Check List sala operatoria di altro intervento chirurgico 5 di dimissione
		/// </summary>
		public char? SIRC_CINTC5_O_CHKLST { get; set; }

		/// <summary>
		/// Lateralità altro intervento chirurgico 5 di dimissione dall'ospedale
		/// </summary>
		public char? SIRC_CINTC5_O_LAT { get; set; }

		/// <summary>
		/// Altro intervento chirurgico 6 di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_CINTC6_O { get; set; }

		/// <summary>
		/// Data dell'altro intervento chirurgico 6 di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_DINTC6_O { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 6 di dimissione
		/// </summary>
		public string? SIRC_CINTC6_O_CH1 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 6 di dimissione
		/// </summary>
		public string? SIRC_CINTC6_O_CH2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 6 di dimissione
		/// </summary>
		public string? SIRC_CINTC6_O_CH3 { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 6 di dimissione
		/// </summary>
		public string? SIRC_CINTC6_O_ANEST { get; set; }

		/// <summary>
		/// Check List sala operatoria di altro intervento chirurgico 6 di dimissione
		/// </summary>
		public char? SIRC_CINTC6_O_CHKLST { get; set; }

		/// <summary>
		/// Lateralità altro intervento chirurgico 6 di dimissione dall'ospedale
		/// </summary>
		public char? SIRC_CINTC6_O_LAT { get; set; }

		/// <summary>
		/// Altro intervento chirurgico 7 di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_CINTC7_O { get; set; }

		/// <summary>
		/// Data dell'altro intervento chirurgico 7 di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_DINTC7_O { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 7 di dimissione
		/// </summary>
		public string? SIRC_CINTC7_O_CH1 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 7 di dimissione
		/// </summary>
		public string? SIRC_CINTC7_O_CH2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 7 di dimissione
		/// </summary>
		public string? SIRC_CINTC7_O_CH3 { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 7 di dimissione
		/// </summary>
		public string? SIRC_CINTC7_O_ANEST { get; set; }

		/// <summary>
		/// Check List sala operatoria di altro intervento chirurgico 7 di dimissione
		/// </summary>
		public char? SIRC_CINTC7_O_CHKLST { get; set; }

		/// <summary>
		/// Lateralità altro intervento chirurgico 7 di dimissione dall'ospedale
		/// </summary>
		public char? SIRC_CINTC7_O_LAT { get; set; }

		/// <summary>
		/// Altro intervento chirurgico 8 di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_CINTC8_O { get; set; }

		/// <summary>
		/// Data dell'altro intervento chirurgico 8 di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_DINTC8_O { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 8 di dimissione
		/// </summary>
		public string? SIRC_CINTC8_O_CH1 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 8 di dimissione
		/// </summary>
		public string? SIRC_CINTC8_O_CH2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 8 di dimissione
		/// </summary>
		public string? SIRC_CINTC8_O_CH3 { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 8 di dimissione
		/// </summary>
		public string? SIRC_CINTC8_O_ANEST { get; set; }

		/// <summary>
		/// Check List sala operatoria di altro intervento chirurgico 8 di dimissione
		/// </summary>
		public char? SIRC_CINTC8_O_CHKLST { get; set; }

		/// <summary>
		/// Lateralità altro intervento chirurgico 8 di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_CINTC8_O_LAT { get; set; }

		/// <summary>
		/// Altro intervento chirurgico 9 di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_CINTC9_O { get; set; }

		/// <summary>
		/// Data dell'altro intervento chirurgico 9 di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_DINTC9_O { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 9 di dimissione
		/// </summary>
		public string? SIRC_CINTC9_O_CH1 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 9 di dimissione 
		/// </summary>
		public string? SIRC_CINTC9_O_CH2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 9 di dimissione
		/// </summary>
		public string? SIRC_CINTC9_O_CH3 { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 9 di dimissione
		/// </summary>
		public string? SIRC_CINTC9_O_ANEST { get; set; }

		/// <summary>
		/// Check List sala operatoria di altro intervento chirurgico 9 di dimissione
		/// </summary>
		public char? SIRC_CINTC9_O_CHKLST { get; set; }

		/// <summary>
		/// Lateralità altro intervento chirurgico 9 di dimissione dall'ospedale
		/// </summary>
		public char? SIRC_CINTC9_O_LAT { get; set; }

		/// <summary>
		/// Altro intervento chirurgico 10 di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_CINTC10_O { get; set; }

		/// <summary>
		/// Data dell'altro intervento chirurgico 10 di dimissione dall'ospedale
		/// </summary>
		public string? SIRC_DINTC10_O { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 1 di altro intervento chirurgico 10 di dimissione
		/// </summary>
		public string? SIRC_CINTC10_O_CH1 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 2 di altro intervento chirurgico 10 di dimissione
		/// </summary>
		public string? SIRC_CINTC10_O_CH2 { get; set; }

		/// <summary>
		/// Identificativo Chirurgo 3 di altro intervento chirurgico 10 di dimissione
		/// </summary>
		public string? SIRC_CINTC10_O_CH3 { get; set; }

		/// <summary>
		/// Identificativo Anestesista di altro intervento chirurgico 10 di dimissione
		/// </summary>
		public string? SIRC_CINTC10_O_ANEST { get; set; }

		/// <summary>
		/// Check List sala operatoria di altro intervento chirurgico 10 di dimissione
		/// </summary>
		public char? SIRC_CINTC10_O_CHKLS { get; set; }

		/// <summary>
		/// Lateralità altro intervento chirurgico 10 di dimissione dall'ospedale
		/// </summary>
		public char? SIRC_CINTC10_O_LAT { get; set; }

		/// <summary>
		/// Rilevazione del dolore
		/// </summary>
		public char SIRC_DOLORE { get; set; }

		/// <summary>
		/// Stadiazione condensata della Diagnosi principale di dimissione dall'ospedale
		/// </summary>
		public char? SIRC_DIAG_OSP_STCND { get; set; }

		/// <summary>
		/// Stadiazione condensata della prima Diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public char? SIRC_CDIAG1_O_STCND { get; set; }

		/// <summary>
		/// Stadiazione condensata della seconda Diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public char? SIRC_CDIAG2_O_STCND { get; set; }

		/// <summary>
		/// Stadiazione condensata della terza Diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public char? SIRC_CDIAG3_O_STCND { get; set; }

		/// <summary>
		/// Stadiazione condensata della quarta Diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public char? SIRC_CDIAG4_O_STCND { get; set; }

		/// <summary>
		/// Stadiazione condensata della quinta Diagnosi concomitante di dimissione dall'ospedale
		/// </summary>
		public char? SIRC_CDIAG5_O_STCND { get; set; }

		/// <summary>
		/// Pressione arteriosa sistolica
		/// </summary>
		public string? SIRC_PRESS_ART { get; set; }

		/// <summary>
		/// Creatinina serica
		/// </summary>
		public string? SIRC_CREAT { get; set; }

		/// <summary>
		/// Frazione di eiezione
		/// </summary>
		public string? SIRC_FRAZ_EI { get; set; }

		/// <summary>
		/// Contiene il numero di errori quando la spedizione passa dallo stato 0 allo stato 1
		/// </summary>
		public int SIRC_CHECK_ERR { get; set; }

		/// <summary>
		/// Contenuto della singola riga del singolo file
		/// </summary>
		public string SIRC_RIGA_IMPORT { get; set; }

		/// <summary>
		/// Data importazione
		/// </summary>
		public DateTime SIRC_DATA_IMPORT { get; set; }
	}
}
