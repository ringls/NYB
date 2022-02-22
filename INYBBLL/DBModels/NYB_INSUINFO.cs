using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace INYBBLL.DBModels
{
    public class NYB_INSUINFO
    {
         
        public string PSN_NO { get; set; }
         
        public decimal BALC { get; set; }
         
        public string INSUTYPE { get; set; }
         
        public string PSN_TYPE { get; set; }
         
        public string PSN_INSU_STAS { get; set; }
         
        public DateTime? PSN_INSU_DATE { get; set; }
         
        public DateTime? PAUS_INSU_DATE { get; set; }
         
        public string CVLSERV_FLAG { get; set; }
         
        public string INSUPLC_ADMDVS { get; set; }
         
        public string EMP_NAME { get; set; }
         
        public int SERIALNO { get; set; }
    }
}
