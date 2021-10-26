using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HanchartDatabase
{
    public class MySqlReader: IReader
    {

        public MySqlReader(string connStr)
        {
            string connectingString = connStr;    
            Console.WriteLine("Mysql Connection");
        }

        public List<TPatientPersonal> ReadCustomer()
        {
            Console.WriteLine("Mysql ReadCustomer");
            DataTable dt = new Sample().SamplePerson();
            List<TPatientPersonal> list = new List<TPatientPersonal>();
            foreach (DataRow person in dt.Rows)
            {
                TPatientPersonal dto = new TPatientPersonal();
                dto.PatientName = person["NAME"].ToString();
                dto.PatientChartNo = person["CUSTNO"].ToString();
                dto.PatientJN = person["PATJN"].ToString();
                dto.PatientAddr = person["ADDR"].ToString();
                dto.PatientCellphone = person["PHONE"].ToString();
                dto.PatientSMSFlag = int.Parse(person["SMSFLAG"].ToString());
                list.Add(dto);
            }

            return list;
            
        }

        public List<TPatientSchedule> ReadResvSchedule()
        {
            Console.WriteLine("Mysql ReadResvSchedule");
            DataTable dt = new Sample().SampleSchedule();
            List<TPatientSchedule> list = new List<TPatientSchedule>();
            foreach (DataRow schedule in dt.Rows)
            {
                TPatientSchedule dto = new TPatientSchedule();
                dto.PatientID = schedule["NAME"].ToString() + "|" + schedule["CUSTNO"].ToString();
                dto.ScheduleDate = schedule["MDCLDATE"].ToString();
                dto.ScheduleTime = schedule["MDCLTIME"].ToString();
                dto.ResvDate = schedule["RESVDATE"].ToString();
                dto.ResvTime = schedule["RESVTIME"].ToString();
                dto.ScheduleType = schedule["TYPE"].ToString();
                dto.InsType = schedule["INSTYPE"].ToString();
                list.Add(dto);
            }

            return list;
        }
       
    }
}
