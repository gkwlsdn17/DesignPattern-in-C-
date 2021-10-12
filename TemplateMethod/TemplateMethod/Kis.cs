using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Kis : VanTemplate
    {

        protected override Response approval(DTOPayment dto)
        {
            Response res = new Response();
            res.RESULT = true;
            if (res.RESULT)
            {
                dto.AUTHNUM = CreateAuthnum();
            }

            MainWindow._instance.WriteTextbox(string.Format("Kis 단말기 결제 승인번호 : {0}", dto.AUTHNUM));
            return res;
            
        }

        public override bool connection()
        {
            MainWindow._instance.WriteTextbox("Kis 단말기 연동");
            return true;
        }

        protected override bool Isconnect()
        {
            MainWindow._instance.WriteTextbox("Kis 단말기 연결 확인");
            return true;
        }

        protected override void openCash()
        {
            MainWindow._instance.WriteTextbox("Kis 금전함 오픈");
        }

        protected override Response cancelApproval(DTOPayment dto)
        {
            Response res = new Response();
            res.RESULT = true;
            if (res.RESULT)
            {
                dto.AUTHNUM = CreateAuthnum();
            }
            MainWindow._instance.WriteTextbox(string.Format("Kis 단말기 결제 취소 원승인번호 : {0}, 취소승인번호 : {1}", dto.OLDAUTHNUM, dto.AUTHNUM));
            return res;
        }       
    }
}
