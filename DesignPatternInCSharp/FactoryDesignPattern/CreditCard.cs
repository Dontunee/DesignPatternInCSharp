using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternInCSharp.FactoryDesignPattern
{
    public interface CreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();

    }

    public class Basic : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 100;
        }

        public string GetCardType()
        {
            return "Basic";
        }

        public int GetCreditLimit()
        {
            return 290000;
        }
    }

    public class Platinum : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 200;
        }

        public string GetCardType()
        {
            return "Platinum";
        }

        public int GetCreditLimit()
        {
            return 3000000;
        }
    }

    public class Gold : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 290;
        }

        public string GetCardType()
        {
            return "Gold";
        }

        public int GetCreditLimit()
        {
            return 4000000;
        }
    }


}
