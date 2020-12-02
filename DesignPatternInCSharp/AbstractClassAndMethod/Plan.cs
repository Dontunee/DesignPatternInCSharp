using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternInCSharp.AbstractClassAndMethod
{
    public abstract class Plan
    {
        protected double rate;
        public abstract void getRate();

        public void Calculation(int units)
        {
            Console.Write("Bill amount for " + units + "units is: Rs.");
            Console.WriteLine(rate * units);
        }

        public class CommercialPlan : Plan
        {
            public override void getRate()
            {
                rate = 5;
            }


        }

        public class DomesticPlan : Plan
        {
            public override void getRate()
            {
                rate = 2.5;
            }
        }

    }
}
