using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace HanchartDatabase
{
    class WriteMysql
    {
        int _id = 0;
        public WriteMysql(string dbName)
        {
            Console.WriteLine(string.Format("{0} db Connection", dbName));
        }

        public void WriteCustomer(List<TPatientPersonal> list)
        {
            foreach (var p in list)
            {
                p.PatientID = _id.ToString();
                _id++;
                Console.WriteLine($"고객저장: (이름:{p.PatientName}, 차트번호:{p.PatientChartNo})");
            }
        }

        public void WriteSchedule(List<TPatientSchedule> list)
        {
            foreach (var p in list)
            {
                Console.WriteLine($"스케줄저장: PID:{p.PatientID}, 스케줄날짜:{p.ScheduleDate+p.ScheduleTime}, 예약날짜:{p.ResvDate+p.ResvTime}");
            }
        }

        public void UpdatePatientID(List<TPatientPersonal> plist, List<TPatientSchedule> sList)
        {
            foreach (var schedule in sList)
            {
                string[] info = schedule.PatientID.Split('|');
                try
                {
                    var patientID = (from x in plist
                                     where x.PatientName == info[0] && x.PatientChartNo == info[1]
                                     select x.PatientID).FirstOrDefault();
                    schedule.PatientID = patientID;
                }
                catch
                {
                    schedule.PatientID = "";
                }
                Console.WriteLine($"PatientID 업데이트: PID:{schedule.PatientID}, 스케줄날짜:{schedule.ScheduleDate + schedule.ScheduleTime}, 예약날짜:{schedule.ResvDate + schedule.ResvTime}");

            }
            Console.WriteLine("PatientID 업데이트 완료");
        }
    }
}