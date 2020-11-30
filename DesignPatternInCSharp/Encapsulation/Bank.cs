using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternInCSharp.Encapsulation
{
    public class Bank
    {
        //hiding class data by declaring the variable as private
        private double balance;

        //creating public getter that returns balance
        public double getBalance()
        {
            //add validation logic if needed
            return balance;
        }

        public void setBalance(double balance)
        {
            //add validation to check wheter data is correct or not
            this.balance = balance;  
        }

        //Encapsulation with properties 

        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value > 0) Console.WriteLine("value cannot be negative");
                balance = value;
            }
        }

    }
}
