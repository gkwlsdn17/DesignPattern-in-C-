using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class TPay : VanTemplate
    {
        protected override Response approval()
        {
            Response res = new Response();
            res.RESULT = true;
            MainWindow._instance.WriteTextbox("TPay 단말기 결제");
            return res;
        }

        protected override bool connection()
        {
            MainWindow._instance.WriteTextbox("TPay 단말기 연동");
            return true;
        }

        protected override void openCash()
        {
            MainWindow._instance.WriteTextbox("TPay 금전함 오픈");
        }

        protected override Response cancelApproval()
        {
            Response res = new Response();
            res.RESULT = true;
            MainWindow._instance.WriteTextbox("TPay 단말기 결제 취소");
            return res;
        }

        protected override Response cashApproval()
        {
            Response res = new Response();
            res.RESULT = true;
            MainWindow._instance.WriteTextbox("TPay 단말기 현금영수증 승인");
            return res;
        }
    }
}
