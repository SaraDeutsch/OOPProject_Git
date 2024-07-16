using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
//Deutsch and Hirsch
//keeps track of sales reps and
//gives their commission rate
{
   internal class SalesRep:Employee 
   {
        public decimal CommissionRate { get; set; }
        public SalesRep(string name, int id, decimal salary, decimal commissionRate):base(name, id, salary) // ctor
        {
            CommissionRate= commissionRate;
        }
    }
}
