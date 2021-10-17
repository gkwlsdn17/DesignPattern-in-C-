using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternEx2
{
    class Adapter : RGBPrinter, Printer
    {
        public Adapter() : base()
        {
        }
        public void Print()
        {
            colorPrint();
        }
        
    }
}
