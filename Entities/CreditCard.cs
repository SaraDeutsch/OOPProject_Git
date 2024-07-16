using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
//Deutsch and Hirsch
// organize and files cc info
{
   public class CreditCard
   {
      public string CardNumber { get; set; }
      public string ExpirationDate { get; set; }
      public string Cvv { get; set; }
      public string CardName { get; set; }
      public CreditCard(string cardName, string cardNumber, string expirationDate, string cvv) // ctor
      {
         CardName = cardName;
         CardNumber = cardNumber;
         ExpirationDate = expirationDate;
         Cvv = cvv;
      }
      public override string ToString() // to string prints card number with only last 4 digits revealed
      {
         return "****-****-****-"+CardNumber[12]+CardNumber[13]+CardNumber[14]+CardNumber[15]; 
      }
   }
}
