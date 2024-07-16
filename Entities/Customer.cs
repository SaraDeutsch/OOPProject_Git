using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entities
//Deutsch and Hirsch
//Keeps track of Customers
{
   public class Customer:Person // class customer inherits from Person
      
   {
      private CreditCard cc;
      public Customer(string name, int id,string cardName, string cardNumber, string expirationDate, string cvv):base(name, id) // ctor
      {
         CreditCard creditCard = new CreditCard(cardName, cardNumber, expirationDate, cvv);
         cc=creditCard;
      }
        public Customer(Customer c) : base(c.Name,c.ID) // copy ctor
        {
         cc = c.cc;
        }
        public override string ToString() // to string
      {
         return base.ToString()+" "+cc.ToString();
      }

   }
}
