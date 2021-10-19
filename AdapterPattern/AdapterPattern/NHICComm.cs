using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class NHICComm : INHComm
    {
        public DTOPatientHealthIns NHICCommRequest(string patientID, string patientJN, string patientName, string inquiryDate)
        {
            DTOPatientHealthIns hicValue;
            MainWindow.instance.WriteTextbox($"{patientName}님의 자격 정보를 공단에서 조회 중입니다.");
            try
            {
                hicValue = HIC.LIST.Find(x => x.PatientName == patientName && x.PatientJN == patientJN.Substring(0,6));
                hicValue.InquiryDate = inquiryDate;
                hicValue.PatientID = patientID;
            }
            catch
            {
                hicValue = null;
            }

            return hicValue;

        }

        public DTOPatientHealthIns NHICCommHiCardNoRequest(string patientID, string patientName, string birthDay, string hiCardNo, string inquiryDate)
        {
            DTOPatientHealthIns hicValue;
            MainWindow.instance.WriteTextbox($"{patientName}님의 자격 정보를 공단에서 조회 중입니다.");
            try
            {
                hicValue = HIC.LIST.Find(x => x.PatientName == patientName && x.PatientJN == birthDay.Substring(0, 6) && x.AsylmSym == hiCardNo);
                hicValue.InquiryDate = inquiryDate;
                hicValue.PatientID = patientID;
            }
            catch
            {
                hicValue = null;
            }

            return hicValue;
            
        }
        
    }
}
