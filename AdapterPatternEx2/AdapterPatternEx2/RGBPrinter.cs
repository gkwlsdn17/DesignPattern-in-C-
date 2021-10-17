using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternEx2
{
    class RGBPrinter : ColorPrinter
    {
        public void colorPrint()
        {
            Console.WriteLine("색상 프린터가 출력 중 입니다.");
        }
    }

}
