using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Spire.Xls;

namespace HanchartDatabase
{
    class ExcelReader: IReader
    {
        
        public ExcelReader(string filename)
        {
            Console.WriteLine(string.Format("{0} Reader", filename));
            
        }

        public List<TPatientPersonal> ReadCustomer()
        {
            Console.WriteLine("ExcelReader ReadCustomer");
            DataTable dt = new Sample().SamplePerson();
            List<TPatientPersonal> list = new List<TPatientPersonal>();
            foreach (DataRow person in dt.Rows)
            {
                TPatientPersonal dto = new TPatientPersonal();
                dto.PatientName = person["이름"].ToString();
                dto.PatientChartNo = person["차트번호"].ToString();
                dto.PatientJN = person["주민번호"].ToString();
                dto.PatientAddr = person["주소"].ToString();
                dto.PatientCellphone = person["핸드폰번호"].ToString();
                dto.PatientSMSFlag = int.Parse(person["문자수신여부"].ToString());
                list.Add(dto);
            }
            
            return list;
        }

        public List<TPatientSchedule> ReadResvSchedule()
        {
            Console.WriteLine("ExcelReader ReadResvSchedule");
            DataTable dt = new Sample().SampleSchedule();
            List<TPatientSchedule> list = new List<TPatientSchedule>();
            foreach (DataRow schedule in dt.Rows)
            {
                TPatientSchedule dto = new TPatientSchedule();
                dto.PatientID = schedule["환자이름"].ToString() + "|" + schedule["차트번호"].ToString();
                dto.ScheduleDate = schedule["스케줄날짜"].ToString();
                dto.ScheduleTime = schedule["스케줄시간"].ToString();
                dto.ResvDate = schedule["예약날짜"].ToString();
                dto.ResvTime = schedule["예약시간"].ToString();
                dto.ScheduleType = schedule["스케줄타입"].ToString();
                dto.InsType = schedule["보험종류"].ToString();
                list.Add(dto);
            }
            
            return list;
        }
    }
}
