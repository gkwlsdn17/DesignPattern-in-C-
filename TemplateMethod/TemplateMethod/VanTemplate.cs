using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TemplateMethod
{
    public abstract class VanTemplate
    {
        public abstract bool connection();
        protected abstract bool Isconnect();
        protected abstract Response approval(DTOPayment dto);
        protected abstract Response cancelApproval(DTOPayment dto);
        protected abstract void openCash();

        public void Payment(DTOPayment dto, bool isCancel = false)
        {
            bool conn = Isconnect();
            if (!conn)
            {
                MainWindow._instance.WriteTextbox("연결실패");
                return;
            }
            Response res;
            if (!isCancel)
                res = approval(dto);
            else
                res = cancelApproval(dto);
            if (!res.RESULT)
            {
                MainWindow._instance.WriteTextbox("결제오류:"+res.ERRCODE);
                return;
            }

            SaveDB(dto);
            openCash();
            MainWindow._instance.WriteTextbox("------------------------");

        }

        private void SaveDB(DTOPayment dto)
        {
            MainWindow._instance.WriteTextbox($"이름:{dto.CUSTNAME} 금액:{dto.AMOUNT} 결제타입:{dto.TYPE} 저장 완료");
        }

        protected string CreateAuthnum()
        {
            Random rnd = new Random();
            return rnd.Next(11111111, 99999999).ToString();
        }

    }
}
