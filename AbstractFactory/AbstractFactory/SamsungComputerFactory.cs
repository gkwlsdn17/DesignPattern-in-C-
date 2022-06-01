using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SamsungComputerFactory : ComputerFactory
    {
        public Keyboard createKeyboard()
        {
            return new SamsungKeyboard();
        }

        public Mouse createMouse()
        {
            return new SamsungMouse();
        }
    }
}
