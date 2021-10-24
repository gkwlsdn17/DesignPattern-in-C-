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
        DataSet ds;
        public ExcelReader(string filename)
        {
            Console.WriteLine(string.Format("{0} Reader", filename));
            ds = new DataSet();
        }

        public List<TPatientPersonal> ReadCustomer()
        {
            Console.WriteLine("ExcelReader ReadCustomer");
            List<TPatientPersonal> list = new List<TPatientPersonal>();
            TPatientPersonal dto = new TPatientPersonal();
            list.Add(dto);
            return list;
        }

        public List<TPatientSchedule> ReadResvSchedule()
        {
            Console.WriteLine("ExcelReader ReadResvSchedule");
            List<TPatientSchedule> list = new List<TPatientSchedule>();
            TPatientSchedule dto = new TPatientSchedule();
            list.Add(dto);
            return list;
        }
    }
}
