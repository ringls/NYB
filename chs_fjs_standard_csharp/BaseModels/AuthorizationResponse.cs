using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chs_fjs_standard_csharp.BaseModels
{
    /// <summary>
    /// 用户授权
    /// </summary>
    public class AuthorizationResponse
    {
        /// <summary>
        /// 调用结果
        /// </summary>
        public int Result { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrMsg { get; set; }
    }
}
