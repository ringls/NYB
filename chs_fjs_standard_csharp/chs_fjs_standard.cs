using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using chs_fjs_standard_csharp.BaseModels;
using _180FrameWork.Common;

namespace chs_fjs_standard_csharp
{
    public class chs_fjs_standard
    {
        [DllImport("chs_fjs_standard.dll")]
        private static extern IntPtr authorization(string usr, string pwd, StringBuilder errmsg);

        [DllImport("chs_fjs_standard.dll")]
        private static extern IntPtr business_handle(string inputvalue, int outputlen, ref byte outputdata, ref byte errmsg);

        [DllImport("chs_fjs_standard.dll")]
        private static extern IntPtr read_cardnum(StringBuilder cardnum, StringBuilder errmsg);

        [DllImport("chs_fjs_standard.dll")]
        private static extern IntPtr read_cardinfo(StringBuilder cardnum, StringBuilder cardCode, StringBuilder id, StringBuilder name, StringBuilder errmsg);

        [DllImport("chs_fjs_standard.dll")]
        private static extern IntPtr ec_decode(string inputvalue, StringBuilder outputDate, StringBuilder errmsg);

        /// <summary>
        /// 用户授权
        /// </summary>
        /// <param name="usr"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static AuthorizationResponse Authorization(string usr, string pwd)
        {
            var rsp = new AuthorizationResponse();
            try
            {
                var errmsg = new StringBuilder();
                rsp.Result = (int)authorization(usr, pwd, errmsg);
                rsp.ErrMsg = errmsg.ToStr().Trim();
            }
            catch (Exception ex)
            {
                rsp.Result = -1;
                rsp.ErrMsg = ex.Message;
            }
            return rsp;
        }
        /// <summary>
        /// 通用业务交互
        /// </summary>
        /// <param name="inputvalue"></param>
        /// <returns></returns>
        public static BusinessHandleResponse BusinessHandle(string inputvalue)
        {
            var rsp = new BusinessHandleResponse();
            try
            {
                int outputlen = 1024 * 100;
                byte[] outputdata = new byte[outputlen];
                byte[] errmsg = new byte[1024];
                rsp.Result = (int)business_handle(inputvalue, outputlen, ref outputdata[0], ref errmsg[0]);
                rsp.ErrMsg = System.Text.Encoding.Default.GetString(errmsg, 0, errmsg.Length).Replace("\0", "").Trim();
                rsp.OutPutData = System.Text.Encoding.Default.GetString(outputdata, 0, outputlen).Replace("\0", "").Trim();
            }
            catch (Exception ex)
            {
                rsp.Result = -1;
                rsp.ErrMsg = ex.Message;
            }
            return rsp;
        }
        /// <summary>
        /// 读卡
        /// </summary>
        /// <returns></returns>
        public static ReadCardNumResponse ReadCardNum()
        {
            var rsp = new ReadCardNumResponse();
            try
            {
                var cardnum = new StringBuilder();
                var errmsg = new StringBuilder();
                rsp.Result = (int)read_cardnum(cardnum, errmsg);
                rsp.ErrMsg = errmsg.ToStr().Trim();
                rsp.CardNum = cardnum.ToStr().Trim();
            }
            catch (Exception ex)
            {
                rsp.Result = -1;
                rsp.ErrMsg = ex.Message;
            }
            return rsp;
        }

        public static ReadCardInfoResponse ReadCardInfo()
        {
            var rsp = new ReadCardInfoResponse();
            try
            {
                var cardnum = new StringBuilder();
                var cardCode = new StringBuilder();
                var id = new StringBuilder();
                var name = new StringBuilder();
                var errmsg = new StringBuilder();

                rsp.Result = (int)read_cardinfo(cardnum,cardCode,id,name,errmsg);
                rsp.ErrMsg = errmsg.ToStr().Trim();
                rsp.CardNum = cardnum.ToStr().Trim();
                rsp.CardCode = cardCode.ToStr().Trim();
                rsp.ID = id.ToStr().Trim();
                rsp.NAME = name.ToStr().Trim();              
            }
            catch (Exception ex)
            {
                rsp.Result = -1;
                rsp.ErrMsg = ex.Message;
            }
            return rsp;
        }

        /// <summary>
        /// 电子凭证解析
        /// </summary>
        /// <param name="inputvalue"></param>
        /// <returns></returns>
        public static EcDecordResponse EcDecord(string inputvalue)
        {
            var rsp = new EcDecordResponse();
            try
            {
                var outputdata = new StringBuilder();
                var errmsg = new StringBuilder();
                rsp.Result = (int)ec_decode(inputvalue, outputdata, errmsg);
                rsp.ErrMsg = errmsg.ToStr().Trim();
                rsp.OutPutData = outputdata.ToStr().Trim();
            }
            catch (Exception ex)
            {
                rsp.Result = -1;
                rsp.ErrMsg = ex.Message;
            } return rsp;
        }
    }
}
