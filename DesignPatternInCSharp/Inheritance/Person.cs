using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternInCSharp.Inheritance
{
    class Person
    {
        int id;
        string name;
        string address;
        string phone;
    }

    class Student : Person
    {
        string studentClass;
        string fees;
        string marks;
        string grade;
    }

    class Staff : Person
    {
        string designation;
        double salary;
    }

    class Technical : Staff
    {
        string qualification;
        string subject;
    }

    class NonTechincal : Staff
    {
        string dName;
        string superior;
    }
}
