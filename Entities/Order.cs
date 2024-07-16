using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entities
//Deutsch and Hirsch
// This class defines the object of type order
{
   public class Order
   {
      public int ProductNumber { get; set; }
      public int CustomerID { get; set; }
      public int OrderQuantity { get; set; }
      public int OrderNumber { get; set; }
      public static int OrderCount=1000;
     


        public Order(int pnumber, int cid, int orderQ) //ctor of an order
      {
         ProductNumber = pnumber;
         CustomerID = cid;
         OrderQuantity = orderQ;
         OrderNumber=SetOrderNumber();
         
      }
      public Order(Order o) // copy ctor
      {
         ProductNumber=o.ProductNumber;
         CustomerID = o.CustomerID;
         OrderQuantity = o.OrderQuantity;
         OrderNumber = o.OrderNumber;
      }
      
      private static int SetOrderNumber() // method that automatically starts the Order number at 1000 and increments it by 1
      {
         OrderCount++;
         return OrderCount;
      }
      public override string ToString() // to string for order
      {
         return "\n Order Number: " + OrderNumber+"\n Product Number: "+ ProductNumber+"\n Customer ID: "+CustomerID+"\n Quanitity: "+OrderQuantity;
      }

   }
}
 