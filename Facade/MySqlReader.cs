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
            List<TPatientPersonal> list = new List<TPatientPersonal>();
            TPatientPersonal dto = new TPatientPersonal();
            list.Add(dto);
            return list;

        }

        public List<TPatientSchedule> ReadResvSchedule()
        {
            Console.WriteLine("Mysql ReadResvSchedule");
            List<TPatientSchedule> list = new List<TPatientSchedule>();
            TPatientSchedule dto = new TPatientSchedule();
            list.Add(dto);
            return list;
        }
       
    }
}
