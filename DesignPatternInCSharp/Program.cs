using DesignPatternInCSharp.Abstraction;
using DesignPatternInCSharp.Encapsulation;
using DesignPatternInCSharp.Inheritance;
using DesignPatternInCSharp.Interface;
using System;

namespace DesignPatternInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test To show encapsulation
            //Bank access = new Bank();
            //access.setBalance(500);
            //Console.WriteLine(access.getBalance());

            //Encapsulation using properties in c#
            //access.Balance = -100;
            //Console.WriteLine(access.Balance);
            //access.Balance = 50;
            //Console.WriteLine(access.Balance);


            //Test to show Abstraction
            //Car carObject = new Car();
            //carObject.CarName = "toyota";
            //carObject.CarColour = "icewine";

            //carObject.Brakes();
            //carObject.Gear();
            //carObject.Steering();


            //Test to show Inheritance 
            //Employee employee = new Employee();
            //employee.GetBranchData();
            //employee.GetEmployeeData();
            //employee.DisplayBranchData();
            //employee.DisplayEmployeeData();
            //Console.WriteLine("Press any key to exit");
            //Console.ReadKey();

            //Test to show interface implementation
            var circle = new Circle();
            circle.Area(3, 5);




        }
    }
}
