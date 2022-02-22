using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chs_fjs_standard_csharp.BusinessHandleModels
{
    /// <summary>
    /// 基本回应
    /// </summary>
    public class BaseBusinessHandleResponse
    {
        public BaseBusinessHandleResponse() { }
        /// <summary>
        /// 交易状态码
        /// </summary>
        public int infcode { get; set; }
        /// <summary>
        /// 接收方报文ID
        /// 接收方返回，接收方医保区划代码(6)+时间(14)+流水号(10)
        /// 时间格式：yyyyMMddHHmmss
        /// </summary>
        public string inf_refmsgid { get; set; }
        /// <summary>
        /// 接收报文时间
        /// 格式：yyyyMMddHHmmssSSS
        /// </summary>
        public string refmsg_time { get; set; }
        /// <summary>
        /// 响应报文时间
        /// 格式：yyyyMMddHHmmssSSS
        /// </summary>
        public string respond_time { get; set; }
        /// <summary>
        /// 错误信息
        /// 交易失败状态下，业务返回的错误信息
        /// </summary>
        public string err_msg { get; set; }
        /// <summary>
        /// 签名方式
        /// </summary>
        public string signtype { get; set; }
        /// <summary>
        /// 数字签名信息
        /// </summary>
        public string cainfo { get; set; }
        /// <summary>
        /// 渠道id
        /// </summary>
        public string app_id { get; set; }
        /// <summary>
        /// 加密方式
        /// 不加密传空，加密传SM4
        /// </summary>
        public string enc_type { get; set; }
    }
    /// <summary>
    /// 泛型基本回应
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseBusinessHandleResponse<T>
    {
        public BaseBusinessHandleResponse() { }
        /// <summary>
        /// 交易状态码
        /// </summary>
        public int infcode { get; set; }
        /// <summary>
        /// 接收方报文ID
        /// 接收方返回，接收方医保区划代码(6)+时间(14)+流水号(10)
        /// 时间格式：yyyyMMddHHmmss
        /// </summary>
        public string inf_refmsgid { get; set; }
        /// <summary>
        /// 接收报文时间
        /// 格式：yyyyMMddHHmmssSSS
        /// </summary>
        public string refmsg_time { get; set; }
        /// <summary>
        /// 响应报文时间
        /// 格式：yyyyMMddHHmmssSSS
        /// </summary>
        public string respond_time { get; set; }
        /// <summary>
        /// 错误信息
        /// 交易失败状态下，业务返回的错误信息
        /// </summary>
        public string err_msg { get; set; }
        /// <summary>
        /// 签名方式
        /// </summary>
        public string signtype { get; set; }
        /// <summary>
        /// 数字签名信息
        /// </summary>
        public string cainfo { get; set; }
        /// <summary>
        /// 渠道id
        /// </summary>
        public string app_id { get; set; }
        /// <summary>
        /// 加密方式
        /// 不加密传空，加密传SM4
        /// </summary>
        public string enc_type { get; set; }
 

        private T _output = default(T);
        /// <summary>
        /// 交易输出
        /// </summary>
        public T output
        {
            get
            {
                return this._output;
            }
            set
            {
                this._output = value;
            }
        }
    }
}
