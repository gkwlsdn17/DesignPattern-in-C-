using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternEx2
{
    class BasicPrinter : Printer
    {
        public void Print()
        {
            Console.WriteLine("기본 프린터가 출력 중 입니다.");
        }
    }
}
