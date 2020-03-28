using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVApp
{
    class Derived1:BaseAbstract
    {
        public decimal HourlySalary { get; set; }

        public int NoOfHours { get; set; }


        public override decimal GetMonthlySalary()
        {
            return HourlySalary*NoOfHours;
        }
    }
}
