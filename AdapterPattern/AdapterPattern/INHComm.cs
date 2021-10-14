using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface INHComm
    {
        DTOPatientHealthIns NHICCommRequest(string patientID, string patientJN, string patientName, string inquiryDate);
        DTOPatientHealthIns NHICCommHiCardNoRequest(string patientID, string patientName, string birthDay, string hiCardNo, string inquiryDate);
    }
}
