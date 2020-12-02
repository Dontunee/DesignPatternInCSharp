using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternInCSharp.Interface
{
    interface Area
    {
        void Area(double a, double b);
    }

    class Rectange : Area
    {
        public void Area(double a, double b)
        {
            double areaRectangle = a * b;
            Console.WriteLine("The area of rectangle is :" + areaRectangle);
        }
    }

    class Circle : Area
    {
        public void Area(double a, double b)
        {
            double pi = 3.142;
            double areaCircle = pi * a * b;
            Console.WriteLine("The area of rectangle is :" + areaCircle);
        }
    }
}
