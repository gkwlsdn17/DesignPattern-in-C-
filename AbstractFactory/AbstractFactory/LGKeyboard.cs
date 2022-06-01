using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class LGKeyboard : Keyboard
    {
        public override string name { get; set; }
        public override string serial { get; set; }

        public LGKeyboard()
        {
            name = "LGKeyboard";
            Random r = new Random();
            serial = r.Next().ToString();
        }
    }
}
