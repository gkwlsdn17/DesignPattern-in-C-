using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class DTOPatientHealthIns
    {
        public string PatientID { get; set; }
        public string PatientJN { get; set; }
        public string PatientName { get; set; }
        public string InquiryDate { get; set; }
        public string QlfType { get; set; }
        public string QlfChwidukDt { get; set; }
        public string PayRestricDt { get; set; }
        public string GsType { get; set; }
        public string ApprovalNo { get; set; }
        public string AsylmSym { get; set; }

    }

    public class DTOPatientPersonal
    {
        public string PatientID { get; set; }
        public string PatientJN { get; set; }
        public string PatientName { get; set; }
        public string InsNumber { get; set; }
    }

    public static class DB{
        private static List<DTOPatientHealthIns> _healthInsList = new List<DTOPatientHealthIns>();
        private static List<DTOPatientPersonal> _patientList = new List<DTOPatientPersonal>();
        public static void InsSetting()
        {
            DTOPatientHealthIns dto1 = new DTOPatientHealthIns();
            dto1.PatientName = "홍길동";
            dto1.PatientID = "1";
            dto1.PatientJN = "7210111";
            dto1.QlfType = "5";
            dto1.InquiryDate = "20211014";
            dto1.AsylmSym = "80450765114";
            _healthInsList.Add(dto1);

            DTOPatientHealthIns dto2 = new DTOPatientHealthIns();
            dto2.PatientName = "김숙희";
            dto2.PatientID = "2";
            dto2.PatientJN = "5601202";
            dto2.QlfType = "5";
            dto2.InquiryDate = "20210901";
            dto2.AsylmSym = "80368349263";
            _healthInsList.Add(dto2);
        }

        public static void PatSetting()
        {
            DTOPatientPersonal dto1 = new DTOPatientPersonal();
            dto1.PatientName = "홍길동";
            dto1.PatientID = "1";
            dto1.PatientJN = "7210111";
            dto1.InsNumber = "80450765114";
            _patientList.Add(dto1);

            DTOPatientPersonal dto2 = new DTOPatientPersonal();
            dto2.PatientName = "김숙희";
            dto2.PatientID = "2";
            dto2.PatientJN = "5601202";
            dto2.InsNumber = "80368349263";
            _patientList.Add(dto2);

            DTOPatientPersonal dto3 = new DTOPatientPersonal();
            dto3.PatientName = "백승철";
            dto3.PatientID = "3";
            dto3.PatientJN = "7108211";
            dto3.InsNumber = "72218110967";
            _patientList.Add(dto3);
        }

        public static List<DTOPatientHealthIns> LIST { get { return _healthInsList; } set { _healthInsList = value; } }
        public static List<DTOPatientPersonal> PATLIST { get { return _patientList; } }


    }

    public static class HIC
    {
        //공단에서 가지고 있는 정보
        private static List<DTOPatientHealthIns> _dbList = new List<DTOPatientHealthIns>();
        public static void Setting()
        {
            DTOPatientHealthIns dto1 = new DTOPatientHealthIns();
            dto1.PatientName = "홍길동";
            dto1.PatientJN = "721011";
            dto1.QlfType = "5";
            dto1.AsylmSym = "80450765114";
            _dbList.Add(dto1);

            DTOPatientHealthIns dto2 = new DTOPatientHealthIns();
            dto2.PatientName = "김숙희";
            dto2.PatientJN = "560120";
            dto2.QlfType = "5";
            dto2.AsylmSym = "80368349263";
            _dbList.Add(dto2);

            DTOPatientHealthIns dto3 = new DTOPatientHealthIns();
            dto3.PatientName = "백승철";
            dto3.PatientJN = "710821";
            dto3.QlfType = "7";
            dto3.AsylmSym = "72218110967";
            _dbList.Add(dto3);
        }

        public static List<DTOPatientHealthIns> LIST { get { return _dbList; } }


    }
}
