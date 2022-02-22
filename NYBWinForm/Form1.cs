using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using chs_fjs_standard_csharp;
using chs_fjs_standard_csharp.BusinessHandleModels;

namespace NYBWinForm
{
    public partial class Form1 : Form
    {
        ChsFJSStandardHelper helper = new ChsFJSStandardHelper();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chs_fjs_standard.Authorization("H35050300443", "888888");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var rsp = chs_fjs_standard.ReadCardInfo();
            this.txtCardCode.Text = rsp.CardCode;
            this.txtCardNum.Text = rsp.CardNum;
        }

    

        private void button4_Click(object sender, EventArgs e)
        {
          var rsp =  helper.Inf1101(new Inf1101Rq()
            {
                data = new Inf1101RqData()
                {
                     mdtrt_cert_type="03",
                     mdtrt_cert_no =    this.txtCardNum.Text,
                     card_sn = this.txtCardCode.Text ,
                     
                }
            });
          MessageBox.Show(rsp.err_msg);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var rsp = helper.Inf1301(new Inf1301Rq()
            {
                data = new Inf1301RqData()
                {
                    ver = "1"
                }
            });
            this.txtCardCode.Text = rsp.output.file_qury_no;
            this.txtCardNum.Text = rsp.output.filename;

        }
        private void button5_Click(object sender, EventArgs e)
        {
            helper.Inf9102(new Inf9102Rq()
            {
                 fsDownloadIn = new Inf9102RqFsDownloadIn()
                {
                    file_qury_no = this.txtCardCode.Text,
                    filename=this.txtCardNum.Text ,
                     fixmedins_code="plc"

                }
            });
        }
    }
}
