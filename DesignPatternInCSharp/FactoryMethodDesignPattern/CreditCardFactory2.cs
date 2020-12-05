using DesignPatternInCSharp.FactoryDesignPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternInCSharp.FactoryMethodDesignPattern
{
    public abstract class CreditCardFactory2
    {
        protected abstract CreditCard MakeCredit();

        public  CreditCard MakeProduct()
        {
            return this.MakeCredit();
        }
    }
}
