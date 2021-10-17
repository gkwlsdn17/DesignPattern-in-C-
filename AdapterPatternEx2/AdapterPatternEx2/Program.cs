using System;

namespace AdapterPatternEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer[] printers = { new BasicPrinter(), new Adapter() };
            foreach (var printer in printers)
            {
                printer.Print();
            }
        }
    }
}
