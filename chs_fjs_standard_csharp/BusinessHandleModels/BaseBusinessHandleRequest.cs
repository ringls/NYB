using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chs_fjs_standard_csharp.BusinessHandleModels
{
    /// <summary>
    /// 基本请求
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseBusinessHandleRequest<T>
    {
        public BaseBusinessHandleRequest() { }
        /// <summary>
        /// 交易编号
        /// 必填
        /// </summary>
        public string infno { get; set; }
        /// <summary>
        /// 发送方报文ID
        /// 必填
        /// 定点医药机构编号(12)+时间(14)+顺序号(4)
        /// 时间格式：yyyyMMddHHmmss
        /// </summary>
        public string msgid { get; set; }
        /// <summary>
        /// 就医地医保区划
        /// 必填
        /// </summary>
        public string mdtrtarea_admvs { get; set; }
        /// <summary>
        /// 参保地医保区划
        /// 如果交易输入中含有人员编号，此项必填，可通过【1101】人员信息获取交易取得
        /// </summary>
        public string insuplc_admdvs { get; set; }
        /// <summary>
        /// 接收方系统代码
        /// 必填
        /// 用于多套系统接入，区分不同系统使用
        /// </summary>
        public string recer_sys_code { get; set; }
        /// <summary>
        /// 设备编号
        /// </summary>
        public string dev_no { get; set; }
        /// <summary>
        /// 设备安全信息
        /// </summary>
        public string dev_safe_info { get; set; }
        /// <summary>
        /// 数字签名信息
        /// </summary>
        public string cainfo { get; set; }
        /// <summary>
        /// 签名类型
        /// 建议使用SM2、SM3
        /// </summary>
        public string signtype { get; set; }
        /// <summary>
        /// 接口版本号
        /// 必填
        /// 例如：“V1.0”，版本号由医保下发通知。
        /// </summary>
        public string infver { get; set; }
        /// <summary>
        /// 经办人类别
        /// 必填
        /// 1-经办人；2-自助终端；3-移动终端
        /// </summary>
        public string opter_type { get; set; }
        /// <summary>
        /// 经办人
        /// 必填
        /// 按地方要求传入经办人/终端编号
        /// </summary>
        public string opter { get; set; }
        /// <summary>
        /// 经办人姓名
        /// 必填
        /// 按地方要求传入经办人姓名/终端名称
        /// </summary>
        public string opter_name { get; set; }
        /// <summary>
        /// 交易时间
        /// 必填
        /// </summary>
        public DateTime inf_time { get; set; }
        /// <summary>
        /// 定点医药机构编号
        /// 必填
        /// </summary>
        public string fixmedins_code { get; set; }
        /// <summary>
        /// 定点医药机构名称
        /// 必填
        /// </summary>
        public string fixmedins_name { get; set; }
        /// <summary>
        /// 交易签到流水号
        /// 通过签到【9001】交易获取
        /// </summary>
        public string sign_no { get; set; }
        /// <summary>
        /// 渠道id
        /// </summary>
        public string app_id { get; set; }
        /// <summary>
        /// 加密方式
        /// 不加密传空，加密传SM4
        /// </summary>
        public string enc_type { get; set; }

        private T _input = default(T);
        /// <summary>
        /// 交易输入
        /// </summary>
        public T input
        {
            get
            {
                return this._input;
            }
            set
            {
                this._input = value;
            }
        }
    }
}
