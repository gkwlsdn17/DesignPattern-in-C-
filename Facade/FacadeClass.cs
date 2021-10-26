using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HanchartDatabase
{
    public class Converting
    {
        public void DBConverting(string readerType)
        {
            IReader reader;
            
            switch (readerType)
            {
                case "excel":
                    reader = new ExcelReader("엑셀컨버팅.xlsx");
                    break;
                case "mysql":
                    reader = new MySqlReader("connection정보");
                    break;
                default:
                    reader = null;
                    break;
            }
            if (reader != null)
            {
                List<TPatientPersonal> patients = reader.ReadCustomer();
                List<TPatientSchedule> schedules = reader.ReadResvSchedule();
                WriteMysql writeMysql = new WriteMysql("t00002");
                writeMysql.WriteCustomer(patients);
                writeMysql.WriteSchedule(schedules);
                writeMysql.UpdatePatientID(patients,schedules);
            }

            MessageBox.Show("컨버팅이 완료되었습니다.");
        }
    }
}
