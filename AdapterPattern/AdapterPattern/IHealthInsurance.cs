using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface IHealthInsurance
    {
        DTOPatientHealthIns GetPatientLastHealthInsurance(string patientID);
        DTOPatientHealthIns GetPatientHealthInsurance(string patientId, string date);
    }
}
