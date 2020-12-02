using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternInCSharp.Interface
{
    //An interface is an unimplemented class. it only allows us define abstract methods
    interface A
    {
        void Method1();
        void Method2();
    }

    interface B : A
    {
        void Method3();
    }

    class MyClass : B
    {
        public void Method1()
        {
            Console.WriteLine("implement Method1");
        }

        public void Method2()
        {
            Console.WriteLine("implement Method2");
        }

        public void Method3()
        {
            Console.WriteLine("implement Method3");
        }
    }
}
