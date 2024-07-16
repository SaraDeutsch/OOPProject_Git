using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
   //Deutsch and Hirsch
   //organizes the info about employees
{
   internal class Employee:Person //a type of person that works for the company
   {
        public decimal Salary { get; set; }//How much the employee is paid
        public Employee(string name, int id, decimal salary):base(name, id)
        {
            Salary= salary;
        }
    }
}
