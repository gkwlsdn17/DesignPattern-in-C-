using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ComputerFactory
    {
        public static Computer getComputer(string type, string ram, string hdd, string cpu)
        {
            switch (type)
            {
                case "PC1":
                    return new PC1(ram, hdd, cpu);
                case "PC2":
                    return new PC2(ram, hdd, cpu);
                case "SERVER":
                    return new PC2(ram, hdd, cpu);
                default:
                    return new PC1(ram, hdd, cpu);
            }
        }
    }
}
