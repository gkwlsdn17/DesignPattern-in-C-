using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HanchartDatabase
{
    interface IReader
    {
        List<TPatientPersonal> ReadCustomer();
        List<TPatientSchedule> ReadResvSchedule();
    }
}
