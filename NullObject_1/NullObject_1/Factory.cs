using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject_1
{
    class Factory
    {
        public string[] names = { "Rob", "Olivia", "Julie" };
        public Customer getCustomer(string name)
        {
            foreach (var n in names)
            {
                if (n == name)
                    return new RealCustomer(name);
            }

            return NullCustomer.getInstance();
        }
    }
}
