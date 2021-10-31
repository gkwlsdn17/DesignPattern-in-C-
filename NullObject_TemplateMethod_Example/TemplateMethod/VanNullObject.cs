using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class VanNullObject : VanTemplate
    {
        public override bool connection()
        {
            MainWindow._instance.WriteTextbox("VAN 선택이 되지 않았습니다.");
            return false;
        }

        protected override Response approval(DTOPayment dto)
        {
            Response res = new Response();
            res.RESULT = false;
            res.ERRCODE = "VAN NULL";
            return res;
        }

        protected override Response cancelApproval(DTOPayment dto)
        {
            Response res = new Response();
            res.RESULT = false;
            res.ERRCODE = "VAN NULL";
            return res;
        }

        protected override bool Isconnect()
        {
            return false;
        }

        protected override void openCash()
        {
            MainWindow._instance.WriteTextbox("VAN NULL");
        }
    }
}
