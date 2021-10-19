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
            return DBSearch(patientID, patientName);
        }

        public DTOPatientHealthIns NHICCommHiCardNoRequest(string patientID, string patientName, string birthDay, string hiCardNo, string inquiryDate)
        {
            return DBSearch(patientID, patientName);
        }

        private DTOPatientHealthIns DBSearch(string patientID, string patientName)
        {
            MainWindow.instance.WriteTextbox($"{patientName}님의 직전 자격 조회 정보를 DB에서 조회 중입니다.");
            return _healthIns.GetPatientLastHealthInsurance(patientID);
        }
    }
}
