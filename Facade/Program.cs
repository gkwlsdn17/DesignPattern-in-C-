using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HanchartDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            string readerType;
            if (args.Length > 0)
                readerType = args[0];
            else return;
            Converting facade = new Converting();
            facade.DBConverting(readerType);
        }
    }
}
