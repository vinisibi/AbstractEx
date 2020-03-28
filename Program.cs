using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Derived1 d1 = new Derived1();
            d1.ID = 100;
            d1.FirstName = "Sibi";
            d1.LastName = "V";
            d1.HourlySalary = 90;
            d1.NoOfHours = 110;
            d1.ApptNo="1001";
            d1.StreetName="West Street";
            d1.City="Cary";
            d1.Zip="27519";
            

            Console.WriteLine("Name of the Employee:" + d1.GetFullName());
            Console.WriteLine("Salary of the Employee:" + d1.GetMonthlySalary());
            Console.WriteLine("Address :"+" " + d1.GetAddress());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("--------------------------------------");

            Derived2 d2 = new Derived2();
            d2.ID = 100;
            d2.FirstName = "John";
            d2.LastName = "V";
            d2.AnnualSalary = 120000;
            d2.ApptNo="141";
            d2.StreetName="Airport Blvd.";
            d2.City="Morrisville";
            d2.Zip="27560";

            Console.WriteLine("Name of the Employee:" + d2.GetFullName());
            Console.WriteLine("Salary of the Employee:" + d2.GetMonthlySalary());
            Console.WriteLine("Address :"+" "+d2.GetAddress());
            Console.ReadLine();
        }
    }
}
