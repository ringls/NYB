using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace INYBBLL.DBModels
{
    public class NYB_INP_SELTDETAIL
    {
         
        public string MDTRT_ID { get; set; }
         
        public string SETL_ID { get; set; }
         
        public string FUND_PAY_TYPE { get; set; }
         
        public decimal INSCP_SCP_AMT { get; set; }
         
        public decimal CRT_PAYB_LMT_AMT { get; set; }
         
        public decimal FUND_PAYAMT { get; set; }
         
        public string FUND_PAY_TYPE_NAME { get; set; }
         
        public string SETL_PROC_INFO { get; set; }
    }
}
