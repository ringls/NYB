using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace INYBBLL.DBModels
{
    public class NYB_OUTP_FEEDETAIL
    {
         
        public string MDTRT_ID { get; set; }
         
        public string FEEDETL_SN { get; set; }
         
        public string PSN_NO { get; set; }
         
        public string CHRG_BCHNO { get; set; }
         
        public string DISE_CODG { get; set; }
         
        public string RXNO { get; set; }
         
        public string RX_CIRC_FLAG { get; set; }
         
        public DateTime? FEE_OCUR_TIME { get; set; }
         
        public string MED_LIST_CODG { get; set; }
         
        public string MEDINS_LIST_CODG { get; set; }
         
        public decimal DET_ITEM_FEE_SUMAMT { get; set; }
         
        public decimal CNT { get; set; }
         
        public decimal PRIC { get; set; }
         
        public string SIN_DOS_DSCR { get; set; }
         
        public string USED_FRQU_DSCR { get; set; }
         
        public decimal PRD_DAYS { get; set; }
         
        public string MEDC_WAY_DSCR { get; set; }
         
        public string BILG_DEPT_CODG { get; set; }
         
        public string BILG_DEPT_NAME { get; set; }
         
        public string BILG_DR_CODG { get; set; }
         
        public string BILG_DR_NAME { get; set; }
         
        public string ACORD_DEPT_CODG { get; set; }
         
        public string ACORD_DEPT_NAME { get; set; }
         
        public string ORDERS_DR_CODE { get; set; }
         
        public string ORDERS_DR_NAME { get; set; }
         
        public string HOSP_APPR_FLAG { get; set; }
         
        public string TCMDRUG_USED_WAY { get; set; }
         
        public string ETIP_FLAG { get; set; }
         
        public string ETIP_HOSP_CODE { get; set; }
         
        public string DSCG_TKDRUG_FLAG { get; set; }
         
        public string MATN_FEE_FLAG { get; set; }
         
        public string COMB_NO { get; set; }
         
        public string EXP_CONTENT { get; set; }
         
        public decimal PRIC_UPLMT_AMT { get; set; }
         
        public decimal SELFPAY_PROP { get; set; }
         
        public decimal FULAMT_OWNPAY_AMT { get; set; }
         
        public decimal OVERLMT_AMT { get; set; }
         
        public decimal PRESELFPAY_AMT { get; set; }
         
        public decimal INSCP_SCP_AMT { get; set; }
         
        public string CHRGITM_LV { get; set; }
         
        public string MED_CHRGITM_TYPE { get; set; }
         
        public string BAS_MEDN_FLAG { get; set; }
         
        public string HI_NEGO_DRUG_FLAG { get; set; }
         
        public string CHLD_MEDC_FLAG { get; set; }
         
        public string LIST_SP_ITEM_FLAG { get; set; }
         
        public string LMT_USED_FLAG { get; set; }
         
        public string DRT_REIM_FLAG { get; set; }
         
        public string MEMO { get; set; }

        public string STATUS { get; set; }

        public DateTime? CANCEL_DATE { get; set; }
    }
}
