using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using chs_fjs_standard_csharp.BusinessHandleModels;
using _180FrameWork.Common;
using System.IO;
using System.Net;
using System.Web;
using System.Net.Cache;
using System.Net.Security;

namespace chs_fjs_standard_csharp
{
    public class ChsFJSStandardHelper
    {
        public ChsFJSStandardHelper() { }

        private string fileDownloadUrl = "http://10.70.122.207/test/fsi/api/fileupload/download";
        /// <summary>
        /// 封装最终请求包
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="infno"></param>
        /// <param name="rq"></param>
        /// <returns></returns>
        private BaseBusinessHandleRequest<T> GetRequest<T>(string infno, T rq)
        {
            var brq = new BaseBusinessHandleRequest<T>()
            {
                infno = infno,
                msgid = "H35050300443" + DateTime.Now.ToString("yyyyMMddHHmmss") + "0001",
                mdtrtarea_admvs = "350500",
                insuplc_admdvs = "",
                recer_sys_code = "CSTEST",
                dev_no = "",
                dev_safe_info = "",
                cainfo = "",
                infver = "V1.0",
                opter_type = "1",
                opter = "LS3",
                opter_name = "林升",
                inf_time = DateTime.Now,
                fixmedins_code = "H35050300443",
                fixmedins_name = "联勤保障部队第910医院",
                sign_no = "",
                app_id = "",
                enc_type = "",
                signtype="",
                input = rq
            };
            return brq;
        }
        /// <summary>
        /// 【1101】人员基本信息获取
        /// </summary>
        /// <param name="rq"></param>
        /// <returns></returns>
        public BaseBusinessHandleResponse<Inf1101Rsp> Inf1101(Inf1101Rq rq)
        {
            var brq = GetRequest<Inf1101Rq>("1101",rq);
            var brsp = chs_fjs_standard.BusinessHandle(brq.ObjToJson());
            if (brsp.Result == 0)
            {
                return brsp.OutPutData.JsonToObj<BaseBusinessHandleResponse<Inf1101Rsp>>();
            }
            else
            {
                throw new Exception(brsp.ErrMsg);
            }
        }
        /// <summary>
        /// 【1301】西药中成药目录下载
        /// </summary>
        /// <param name="rq"></param>
        /// <returns></returns>
        public BaseBusinessHandleResponse<Inf1301Rsp> Inf1301(Inf1301Rq rq)
        {
            var brq = GetRequest<Inf1301Rq>("1301", rq);
            var brsp = chs_fjs_standard.BusinessHandle(brq.ObjToJson());
            if (brsp.Result == 0)
            {
                return brsp.OutPutData.JsonToObj<BaseBusinessHandleResponse<Inf1301Rsp>>();
            }
            else
            {
                throw new Exception(brsp.ErrMsg);
            }
        }
        /// <summary>
        /// 【9102】文件下载
        /// </summary>
        /// <param name="rq"></param>
        public void Inf9102(Inf9102Rq rq)
        {
            var brq = GetRequest<Inf9102Rq>("9102", rq);
            var s = DownloadFile(brq.ObjToJson());
            //保存到本地
            using (var fileStream = File.Create(@"C:\"+rq.fsDownloadIn.filename)) {
                s.Seek(0, SeekOrigin.Begin);
                s.CopyTo(fileStream);
            }
        }

        private Stream DownloadFile(string downInput)
        {
            HttpWebRequest req = null;
            req = (HttpWebRequest)WebRequest.Create(fileDownloadUrl);
            HttpRequestCachePolicy noCachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore);
            req.CachePolicy = noCachePolicy;
            req.ServicePoint.Expect100Continue = false;
            req.Method = "POST";
            req.KeepAlive = true;
            req.ContentType = "text/plain;charset=utf-8";

            byte[] postData = Encoding.UTF8.GetBytes(downInput);
            System.IO.Stream reqStream = req.GetRequestStream();
            reqStream.Write(postData, 0, postData.Length);
            reqStream.Close();

            HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();
            //Encoding encoding = Encoding.GetEncoding(rsp.CharacterSet);
            Encoding encoding = Encoding.UTF8;
            System.IO.Stream stream = null;
            BinaryReader reader = null;
            MemoryStream outputStream = new MemoryStream();
            try
            {
                // 以字符流的方式读取HTTP响应
                stream = rsp.GetResponseStream();
                reader = new BinaryReader(stream, encoding);
                byte[] buffer = new byte[1024];
                int bytesRead;
                do
                {
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    outputStream.Write(buffer, 0, bytesRead);
                }
                while (bytesRead != 0);
                outputStream.Position = 0;
                return outputStream;
            }
            finally
            {
                // 释放资源
                if (reader != null) reader.Close();
                if (stream != null) stream.Close();
                if (rsp != null) rsp.Close();
            }
        }
    }
}
