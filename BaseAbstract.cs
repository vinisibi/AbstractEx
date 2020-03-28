using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVApp
{
    public abstract class BaseAbstract
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string ApptNo{get;set;}

        public string StreetName{get;set;}

        public string City{get; set;}

        public string Zip{get; set;}
        
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public string GetAddress()
        {
            return ApptNo+" "+StreetName+","+" "+City+"-"+Zip;
        }

        public abstract decimal GetMonthlySalary();
       

    }
}
