using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class Mouse
    {
        public abstract string name { get; set; }
        public abstract string serial { get; set; }

    }
}
