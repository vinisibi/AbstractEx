using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVApp
{
    class Derived2:BaseAbstract
    {
        public decimal AnnualSalary { get; set; }

        
        public override decimal GetMonthlySalary()
        {
            return AnnualSalary / 12;
        }

    }
}
