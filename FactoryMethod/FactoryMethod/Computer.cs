using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    abstract class Computer
    {
        public abstract string TYPE { get; }
        public abstract string RAM { get; set; }
        public abstract string HDD { get; set; }
        public abstract string CPU { get; set; }

        public string toString()
        {
            return string.Format("TYPE={0}, RAM={1}, HDD={2}, CPU={3}", TYPE, RAM, HDD, CPU);
        }
    }
}
