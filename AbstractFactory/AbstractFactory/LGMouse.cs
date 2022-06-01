using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class LGMouse : Mouse
    {
        public override string name { get; set; }
        public override string serial { get; set; }

        public LGMouse()
        {
            name = "LGMouse";
            Random r = new Random();
            serial = r.Next().ToString();
        }
    }
}
