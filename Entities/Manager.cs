using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
//Deutsch and Hirsch
//Manager is a type of employee. Is he a senior manager?
{
   internal class Manager:Employee
   {
        public bool Vetek { get; set; }//Is this employee a senior manager
        public Manager(string name, int id, decimal salary, bool vetek): base(name, id, salary)
        {
         Vetek = vetek;
        }
    }
}
