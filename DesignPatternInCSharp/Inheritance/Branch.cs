using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternInCSharp.Inheritance
{
    /// <summary>
    /// Inheritance is the principle that helps to achieve resuability and changeability of our code.
    /// It helps to use the exisiting features of an object as well as override the existing functions also.
    /// It is basically transfering properties and behaviours of an existing class
    /// </summary>
    class Branch
    {
         int branchCode;
         string branchName, branchAddress;

        protected void GetBranchData()
        {
            Console.WriteLine("Enter branch details:");
            Console.WriteLine("Enter branch code");
            branchCode = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter branch name");
            branchName = Console.ReadLine();
            Console.WriteLine("Enter branch address");
            branchAddress = Console.ReadLine();
        }

        protected void DisplayBranchData()
        {
            Console.WriteLine("Branch code is:" + branchCode);
            Console.WriteLine("Branch name is:" +  branchName);
            Console.WriteLine("Branch address is:" + branchAddress);
        }
    }

    class Employee : Branch
    {
         int employeeId, employeeAge;
         string employeeName, employeeAddress;

        public void GetEmployeeData()
        {
            Console.WriteLine("Enter employeee details:");
            Console.WriteLine("Enter employee ID");
            employeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee Age");
            employeeAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee Name");
            employeeName = Console.ReadLine();
            Console.WriteLine("Enter employee address");
            employeeAddress = Console.ReadLine();
        }

        public void DisplayEmployeeData()
        {
            Console.WriteLine("Employee ID is :" + employeeId);
            Console.WriteLine("Employee name is :" + employeeName);
            Console.WriteLine("Employee Address is : " + employeeAddress);
            Console.WriteLine("Employee age is :" + employeeAge);

        }

    }
}
