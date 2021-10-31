using System;

namespace NullObject_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory customerFactory = new Factory();
            Customer dto1 = customerFactory.getCustomer("Rob");
            Customer dto2 = customerFactory.getCustomer("Emma");
            Console.WriteLine(dto1.getName());
            Console.WriteLine(dto2.getName());
        }
    }
}
