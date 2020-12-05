using DesignPatternInCSharp.FactoryDesignPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternInCSharp.FactoryMethodDesignPattern
{
    public class BasicCreditCardFactory : CreditCardFactory2
    {
        protected override CreditCard MakeCredit()
        {
            return new Basic();
        }
    }
}
