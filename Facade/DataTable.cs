using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HanchartDatabase
{
    public class TPatientPersonal
    {
        public string PatientID { get; set; }
        public string PatientName { get; set; }
        public string PatientChartNo { get; set; }
        public string PatientJN { get; set; }
        public string PatientAddr { get; set; }
        public string PatientCellphone { get; set; }
        public string PatientPhone { get; set; }
        public int PatientSMSFlag { get; set; }
    }

    public class TPatientSchedule
    {
        public string ScheduleID { get; set; }
        public string PatientID { get; set; }
        public string ScheduleDate { get; set; }
        public string ScheduleTime { get; set; }
        public string ResvDate { get; set; }
        public string ResvTime { get; set; }
        public string ScheduleType { get; set; }
        public string InsType { get; set; }
        public string CrTime { get; set; }
    }
}
