using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SamsungMouse : Mouse
    {
        public override string name { get; set; }
        public override string serial { get; set; }

        public SamsungMouse()
        {
            name = "SamsungMouse";
            Random r = new Random();
            serial = r.Next().ToString();
        }
    }
}
