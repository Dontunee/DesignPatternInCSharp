using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternInCSharp.FactoryDesignPattern
{
    public static class CreditCardFactory
    {
        public static CreditCard GetCreditCard(string cardName)
        {
            if (cardName == "Basic")
            {
                return new Basic();
            }
            else if (cardName == "Platinum")
            {
                return new Platinum();
            }
            else if (cardName == "Gold")
            {
                return new Gold();
            }
            return null;
        }
    }
}
