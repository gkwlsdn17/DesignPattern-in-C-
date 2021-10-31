using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class DTOPayment
    {
        public string ID { get; set; }
        public string CUSTNAME { get; set; }
        public int AMOUNT { get; set; }
        public int TYPE { get; set; }
        public string AUTHNUM { get; set; }
        public string OLDAUTHNUM { get; set; }
    }
}
