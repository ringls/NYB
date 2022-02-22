using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace INYBBLL.DBModels
{
    public class NYB_INP_DSCG_DISEINFO
    {
         
        public string MDTRT_ID { get; set; }
         
        public string PSN_NO { get; set; }
         
        public string DIAG_TYPE { get; set; }
         
        public string MAINDIAG_FLAG { get; set; }
         
        public int DIAG_SRT_NO { get; set; }
         
        public string DIAG_CODE { get; set; }
         
        public string DIAG_NAME { get; set; }
         
        public string DIAG_DEPT { get; set; }
         
        public string DISE_DOR_NO { get; set; }
         
        public string DISE_DOR_NAME { get; set; }
         
        public DateTime? DIAG_TIME { get; set; }
    }
}
