using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class LGComputerFactory : ComputerFactory
    {
        public Keyboard createKeyboard()
        {
            return new LGKeyboard();
        }

        public Mouse createMouse()
        {
            return new LGMouse();
        }
    }
}
