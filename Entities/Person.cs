using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
//Deutsch and Hirsch
//defines an object of type person
{
   public class Person //
   {
        public string Name { get; set; }//Person's name
        public int ID { get; set; }//Person's ID
        public Person(string name, int id)//ctor
        {
         Name = name;
         ID = id;
        }
        public Person()//default ctor
        {
         Name = "";
         ID = 0;
        }
        public override string ToString()
      {
         return ID+" "+Name;
      }
    }
}
