using DesignPatternInCSharp.Abstraction;
using DesignPatternInCSharp.Encapsulation;
using System;

namespace DesignPatternInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test To show encapsulation
            Bank access = new Bank();
            access.setBalance(500);
            Console.WriteLine(access.getBalance());

            //Encapsulation using properties in c#
            access.Balance = -100;
            Console.WriteLine(access.Balance);
            access.Balance = 50;
            Console.WriteLine(access.Balance);


            //Test to show Abstraction
            Car carObject = new Car();
            carObject.CarName = "toyota";
            carObject.CarColour = "icewine";

            carObject.Brakes();
            carObject.Gear();
            carObject.Steering();


        }
    }
}
