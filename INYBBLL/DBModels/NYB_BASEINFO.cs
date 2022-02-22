using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace INYBBLL.DBModels
{
    public class NYB_BASEINFO
    {         
        public string PSN_CERT_TYPE { get; set; }
         
        public string CERTNO { get; set; }
         
        public string PSN_NAME { get; set; }
         
        public string PSN_NO { get; set; }
         
        public string GEND { get; set; }
         
        public string NATY { get; set; }
         
        public DateTime? BRDY { get; set; }
         
        public decimal AGE { get; set; }
         
        public string EXP_CONTENT { get; set; }
    }
}
