using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class PC2 : Computer
    {
        public override string TYPE { get { return "PC2"; } }
        public override string RAM { get; set; }
        public override string HDD { get; set; }
        public override string CPU { get; set; }

        public PC2(string RAM, string HDD, string CPU)
        {
            this.RAM = RAM;
            this.HDD = HDD;
            this.CPU = CPU;
        }
    }
}
