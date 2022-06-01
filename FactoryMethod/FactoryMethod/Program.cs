using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Method Pattern");
            Computer pc = ComputerFactory.getComputer("PC1", "8GB", "500GB", "2.4GHz");
            Computer serverPC = ComputerFactory.getComputer("SERVER", "16GB", "1TB", "2.9GHz");
            Console.WriteLine(pc.toString());
            Console.WriteLine(serverPC.toString());
        }
    }
}
