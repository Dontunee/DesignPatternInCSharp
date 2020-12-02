using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternInCSharp.AbstractClassAndMethod
{
   public  abstract class ClassEmployee
    {
        protected int employeeId, eemployeeAge;
        protected string employeeName, employeeAddress;

        public abstract void GetEmployeeData();
        public virtual void DisplayEmployeeData()
        {
            Console.WriteLine("Employee Id is :" + this.employeeId);
            Console.WriteLine("Employee Name is :" + this.employeeName);
            Console.WriteLine("Employee Address is" + employeeAddress);
            Console.WriteLine("Employee Age is : " + this.eemployeeAge);

        }

        public ClassEmployee()
        {
            Console.WriteLine("Abstract class constructor");
        }
    }

    public class ClassManager : ClassEmployee
    {
        double bonus;
        public override void GetEmployeeData()
        {
            Console.WriteLine("Enter manager details");
            Console.WriteLine("Enter the manager Id:");
            employeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the manager name");
            employeeName = Console.ReadLine();
            Console.WriteLine("Enter the manager bonus");
            bonus = double.Parse(Console.ReadLine());

        }

        public override void DisplayEmployeeData()
        {
            Console.WriteLine("manager id is: " + employeeId);
            Console.WriteLine("manager name is: " + employeeName);
            Console.WriteLine("manager bonus is: " + bonus);
        }
    }
}
