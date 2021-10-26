using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HanchartDatabase
{
    public class TPatientPersonal
    {
        public string PatientID { get; set; }
        public string PatientName { get; set; }
        public string PatientChartNo { get; set; }
        public string PatientJN { get; set; }
        public string PatientAddr { get; set; }
        public string PatientCellphone { get; set; }
        public string PatientPhone { get; set; }
        public int PatientSMSFlag { get; set; }
    }

    public class TPatientSchedule
    {
        public string ScheduleID { get; set; }
        public string PatientID { get; set; }
        public string ScheduleDate { get; set; }
        public string ScheduleTime { get; set; }
        public string ResvDate { get; set; }
        public string ResvTime { get; set; }
        public string ScheduleType { get; set; }
        public string InsType { get; set; }
        public string CrTime { get; set; }
    }

    public class Sample
    {
        public DataTable SamplePerson()
        {
            DataTable dt = new DataTable("TPatientPersonal");
            dt.Columns.Add("이름");
            dt.Columns.Add("차트번호");
            dt.Columns.Add("주민번호");
            dt.Columns.Add("주소");
            dt.Columns.Add("핸드폰번호");
            dt.Columns.Add("문자수신여부");

            dt.Rows.Add("황다혜", "101", "9406142", "경기도 성남시 분당구", "01011112222", 1);
            dt.Rows.Add("한상규", "109", "8910111", "서울시 강남구 역삼동", "01021412222", 1);
            

            return dt;
        }

        public DataTable DBSamplePerson()
        {
            DataTable dt = new DataTable("CUST_INFO");
            dt.Columns.Add("NAME");
            dt.Columns.Add("CUSTNO");
            dt.Columns.Add("PATJN");
            dt.Columns.Add("ADDR");
            dt.Columns.Add("PHONE");
            dt.Columns.Add("SMSFLAG");

            dt.Rows.Add("황다혜", "101", "9406142", "경기도 성남시 분당구", "01011112222", 1);
            dt.Rows.Add("한상규", "109", "8910111", "서울시 강남구 역삼동", "01021412222", 1);


            return dt;
        }

        public DataTable SampleSchedule()
        {
            DataTable dt = new DataTable("TPatientSchedule");
            dt.Columns.Add("환자이름");
            dt.Columns.Add("차트번호");
            dt.Columns.Add("스케줄날짜");
            dt.Columns.Add("스케줄시간");
            dt.Columns.Add("예약날짜");
            dt.Columns.Add("예약시간");
            dt.Columns.Add("스케줄타입");
            dt.Columns.Add("보험종류");

            dt.Rows.Add("황다혜","101","20190820", "114032", "", "", "재진", "건보");
            dt.Rows.Add("한상규","109","20201102", "161205", "", "", "초진", "건보");
            dt.Rows.Add("황다혜","101","20200113", "103031", "", "", "재진", "건보");
            dt.Rows.Add("한상규","109","20210503", "122539", "", "", "재진", "건보");

            return dt;
        }

        public DataTable DBSampleSchedule()
        {
            DataTable dt = new DataTable("MDCL_INFO");
            dt.Columns.Add("NAME");
            dt.Columns.Add("CUSTNO");
            dt.Columns.Add("MDCLDATE");
            dt.Columns.Add("MDCLTIME");
            dt.Columns.Add("RESVDATE");
            dt.Columns.Add("RESVTIME");
            dt.Columns.Add("TYPE");
            dt.Columns.Add("INSTYPE");

            dt.Rows.Add("황다혜", "101", "20190820", "114032", "", "", "재진", "건보");
            dt.Rows.Add("한상규", "109", "20201102", "161205", "", "", "초진", "건보");
            dt.Rows.Add("황다혜", "101", "20200113", "103031", "", "", "재진", "건보");
            dt.Rows.Add("한상규", "109", "20210503", "122539", "", "", "재진", "건보");

            return dt;
        }
    }
    
}
