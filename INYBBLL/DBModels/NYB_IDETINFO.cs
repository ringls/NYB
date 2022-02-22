using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace INYBBLL.DBModels
{
    public class NYB_IDETINFO
    {
         
        public string PSN_NO { get; set; }
         
        public string PSN_IDET_TYPE { get; set; }
         
        public string PSN_TYPE_LV { get; set; }
         
        public string MEMO { get; set; }
         
        public DateTime? BEGNTIME { get; set; }
         
        public DateTime? ENDTIME { get; set; }
         
        public int SERIALNO { get; set; }
    }
}
