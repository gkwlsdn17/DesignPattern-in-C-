using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternEx1
{
    class Adapter : Printer
    {
        private ColorPrinter colorPrinter;
        public Adapter(ColorPrinter colorPrinter)
        {
            this.colorPrinter = colorPrinter;
        }
        public void Print()
        {
            colorPrinter.colorPrint();
        }
    }
}
