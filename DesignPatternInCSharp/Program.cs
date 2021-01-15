using DesignPatternInCSharp.AbstractClassAndMethod;
using DesignPatternInCSharp.Abstraction;
using DesignPatternInCSharp.Encapsulation;
using DesignPatternInCSharp.FactoryDesignPattern;
using DesignPatternInCSharp.FactoryMethodDesignPattern;
using DesignPatternInCSharp.Inheritance;
using DesignPatternInCSharp.Interface;
using System;
using System.Collections.Generic;
using static DesignPatternInCSharp.AbstractClassAndMethod.Plan;

namespace DesignPatternInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfEntries = Console.ReadLine();
            var namePhoneNumberDictionary = new Dictionary<string, string>();
            for (int i = 1; i <= int.Parse(numberOfEntries); i++)
            {
                var input = Console.ReadLine();
                var inputSplit = input.Split(' ');
                namePhoneNumberDictionary.Add(inputSplit[0], inputSplit[1]);
            }

            string getInput = null;

            bool flag = false;
            do
            {
                getInput = Console.ReadLine();
                if (getInput != null)
                {
                    namePhoneNumberDictionary.TryGetValue(getInput, out string phoneNumber);
                    if (phoneNumber != null)
                    {
                        var output = getInput + "=" + phoneNumber;
                        Console.WriteLine(output);
                    }
                    else
                    {
                        Console.WriteLine("Not found");
                    }
                }
                else
                {
                    flag = true;
                }
            }
            while (!flag);

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

            ////Test to show interface implementation
            //var circle = new Circle();
            //circle.Area(3, 5);

            //Test to show abstract class 
            //Sub1 object1 = new Sub1();
            //object1.Calculate(25);
            //Plan p;
            //Console.WriteLine("Commercial connection");
            //p = new CommercialPlan();
            //p.getRate();
            //p.Calculation(250);
            //Console.WriteLine("Domestic connection");
            //p = new DomesticPlan();
            //p.getRate();
            //p.Calculation(150);
            //Console.ReadKey();
            //ClassManager manager = new ClassManager();
            //manager.GetEmployeeData();
            //manager.DisplayEmployeeData();
            //Console.ReadKey();

            //Test For Factory design pattern 
            //var creditDetails = CreditCardFactory.GetCreditCard("Basic");
            //if (creditDetails != null)
            //{
            //    Console.WriteLine("CardType :" + creditDetails.GetCardType());
            //    Console.WriteLine("CreditLimit :" + creditDetails.GetCreditLimit());
            //    Console.WriteLine("AnnualCharge :" + creditDetails.GetAnnualCharge());
            //}
            //else
            //{
            //    Console.WriteLine("Invalid credit card type");
            //}

            //Console.ReadLine();

            //Test to show Factory Method Design Pattern
            //var card = new BasicCreditCardFactory().MakeProduct();
            //card.GetCardType();
            //card.GetCreditLimit();
            //card.GetAnnualCharge();




        }
    }
}
