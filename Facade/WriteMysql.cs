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
        public WriteMysql(string dbName)
        {
            Console.WriteLine(string.Format("{0} db Connection", dbName));
        }

        public void WriteCustomer(List<TPatientPersonal> list)
        {
            Console.WriteLine("고객저장");
        }

        public void WriteSchedule(List<TPatientSchedule> list)
        {
            Console.WriteLine("스케줄저장");
        }

        public void UpdatePatientID(List<TPatientPersonal> list)
        {
            Console.WriteLine("PatientID 업데이트");
        }
    }
}