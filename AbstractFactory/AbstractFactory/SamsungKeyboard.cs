using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SamsungKeyboard : Keyboard
    {
        public override string name { get; set; }
        public override string serial { get; set; }

        public SamsungKeyboard()
        {
            name = "SamsungKeyboard";
            Random r = new Random();
            serial = r.Next().ToString();
        }
    }
}
