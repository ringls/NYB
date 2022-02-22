using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chs_fjs_standard_csharp.BusinessHandleModels
{
    public class Inf1101Rsp
    {
        public Inf1101RspBaseInfo baseinfo { get; set; }
        public IList<Inf1101RspInsuInfo> insuinfo { get; set; }
        public IList<Inf1101RspIdetInfo> idetinfo { get; set; }
    }
}
