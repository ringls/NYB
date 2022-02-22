using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chs_fjs_standard_csharp.BaseModels
{
    public class ReadCardInfoResponse
    {
        /// <summary>
        /// 调用结果
        /// </summary>
        public int Result { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string CardNum { get; set; }
        /// <summary>
        /// 卡SN
        /// </summary>
        public string CardCode { get; set; }
        /// <summary>
        /// 身份证
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string NAME { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrMsg { get; set; }
    }
}
