using System;

namespace AdapterPatternEx1
{
    class Program
    {
        /// <summary>
        /// 인스턴스를 이용해 사용하는 어댑터
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Printer[] printers = { new BasicPrinter(), new Adapter(new RGBPrinter()) };
            foreach (var printer in printers)
            {
                printer.Print();
            }
        }

    }
}
