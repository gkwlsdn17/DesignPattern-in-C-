using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class HealthInsAdapter : INHComm
    {
        IHealthInsurance _healthIns;
        public HealthInsAdapter(IHealthInsurance healthIns)
        {
            _healthIns = healthIns;
        }

        public DTOPatientHealthIns NHICCommRequest(string patientID, string patientJN, string patientName, string inquiryDate)
        {
            return DBSearch(patientID);
        }

        public DTOPatientHealthIns NHICCommHiCardNoRequest(string patientID, string patientName, string birthDay, string hiCardNo, string inquiryDate)
        {
            return DBSearch(patientID);
        }

        private DTOPatientHealthIns DBSearch(string patientID)
        {
            MainWindow.instance.WriteTextbox("공단 오류로 인하여 DB에서 데이터를 조회합니다.");
            return _healthIns.GetPatientLastHealthInsurance(patientID);
        }
    }
}
