using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternInCSharp.AbstractClassAndMethod
{
    public abstract class MyClass
    {
        public abstract void Calculate(double x);
    }

    class Sub1 : MyClass
    {
        public override void Calculate(double x)
        {
            Console.WriteLine("Square root is" + Math.Sqrt(x));
        }
    }

    class Sub2 : MyClass
    {
        public override void Calculate(double x)
        {
            Console.WriteLine("Square is :" + (x * x));
        }
    }
}
