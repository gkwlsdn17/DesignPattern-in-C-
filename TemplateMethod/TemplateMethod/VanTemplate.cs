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
        protected abstract bool connection();
        protected abstract Response approval();
        protected abstract Response cancelApproval();
        protected abstract Response cashApproval();
        protected abstract void openCash();

        public void Payment(DTOPayment dto)
        {
            bool conn = connection();
            if (!conn)
            {
                MainWindow._instance.WriteTextbox("연결실패");
                return;
            }
            Response res = approval();
            if (!res.RESULT)
            {
                MainWindow._instance.WriteTextbox("결제오류:"+res.ERRCODE);
                return;
            }

            SaveDB(dto);
            openCash();
            MainWindow._instance.WriteTextbox("------------------------");

        }

        public void CancelPayment(DTOPayment dto)
        {
            bool conn = connection();
            if (!conn)
            {
                MainWindow._instance.WriteTextbox("연결실패");
                return;
            }
            Response res = cancelApproval();
            if (!res.RESULT)
            {
                MainWindow._instance.WriteTextbox("결제취소오류:" + res.ERRCODE);
                return;
            }

            SaveDB(dto);
            openCash();
            MainWindow._instance.WriteTextbox("------------------------");
        }

        public void CashApproval(DTOPayment dto)
        {
            bool conn = connection();
            if (!conn)
            {
                MainWindow._instance.WriteTextbox("연결실패");
                return;
            }
            Response res = cashApproval();
            if (!res.RESULT)
            {
                MainWindow._instance.WriteTextbox("현금영수증 승인 오류:" + res.ERRCODE);
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

    }
}
