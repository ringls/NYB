using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace INYBBLL.DBModels
{
    public class NYB_OUTP_MDTRTINFO
    {
         
        public string MDTRT_ID { get; set; }
         
        public string PSN_NO { get; set; }
         
        public string MED_TYPE { get; set; }
         
        public DateTime? BEGNTIME { get; set; }
         
        public string MAIN_COND_DSCR { get; set; }
         
        public string DISE_CODG { get; set; }
         
        public string DISE_NAME { get; set; }
         
        public string BIRCTRL_TYPE { get; set; }
         
        public DateTime? BIRCTRL_MATN_DATE { get; set; }
         
        public string MATN_TYPE { get; set; }
         
        public int GESO_VAL { get; set; }
         
        public string EXP_CONTENT { get; set; }
    }
}
