using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chs_fjs_standard_csharp.BusinessHandleModels
{
    public class Inf1101RspInsuInfo
    {
        public string balc { get; set; }
        public string insutype { get; set; }
        public string psn_type { get; set; }
        public string psn_insu_stas { get; set; }
        public DateTime psn_insu_date { get; set; }
        public DateTime paus_insu_date { get; set; }
        public string cvlserv_flag { get; set; }
        public string insuplc_admdvs { get; set; }
        public string emp_name { get; set; }
    }
}
