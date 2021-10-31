using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject_1
{
    public abstract class Customer
    {
        protected string name;
        public abstract bool isNull();
        public abstract string getName();
    }

    public class RealCustomer : Customer
    {
        public RealCustomer(string name)
        {
            this.name = name;
        }

        public override string getName()
        {
            return this.name;
        }

        public override bool isNull()
        {
            return false;
        }
    }

    public class NullCustomer : Customer
    {
        private static NullCustomer instance;
      
        public static NullCustomer getInstance()
        {
            if (instance == null)
                instance = new NullCustomer();
            return instance;
        }

        public override string getName()
        {
            return "";
        }

        public override bool isNull()
        {
            return true;
        }
    }
}
