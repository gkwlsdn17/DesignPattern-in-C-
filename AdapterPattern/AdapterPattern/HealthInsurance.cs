using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class HealthInsurance : IHealthInsurance
    {

        DTOPatientHealthIns IHealthInsurance.GetPatientHealthInsurance(string patientID, string date)
        {
            DTOPatientHealthIns dbValue;
            try
            {
                dbValue = DB.LIST.Find(x => x.PatientID == patientID && x.InquiryDate == date);
            }
            catch
            {
                dbValue = null;
            }

            return dbValue;
            
        }

        DTOPatientHealthIns IHealthInsurance.GetPatientLastHealthInsurance(string patientID)
        {
            DTOPatientHealthIns dbValue;
            try
            {
                dbValue = (from x in DB.LIST
                           where x.PatientID == patientID
                           orderby x.InquiryDate descending
                           select x).FirstOrDefault();
            }
            catch
            {
                dbValue = null;
            }

            return dbValue;
        }
    }
}
