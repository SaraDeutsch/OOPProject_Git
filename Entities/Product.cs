using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
//Deutsch and Hirsch
//Organizes the details of all the products in the store
{
   public class Product
   {
      public int ProductNumber { get; set; }//the number to identify the product
      public string ProductName { get; set; }//the official name of the product
      public int AmountInStock { get; set; }//The amount that the product has in stock
      public decimal CostPerUnit { get; set; }//how much 1 of this product costs
      /// ctor initializes the values of each aspect of the product
      /// <param name="productNumber"></param>
      /// <param name="productName"></param>
      /// <param name="costPerUnit"></param>
      public Product(int productNumber, string productName, decimal costPerUnit, int amountInStock)
      {
         ProductNumber = productNumber;
         ProductName = productName;
         CostPerUnit = costPerUnit;
         AmountInStock = amountInStock;
      }
        public Product(Product p)
        {
         ProductNumber = p.ProductNumber;
         ProductName = p.ProductName;
         CostPerUnit = p.CostPerUnit;
         AmountInStock = p.AmountInStock;
        }

        /// when printing the object it writes the pnumber the name and cost per unit
        /// <returns></returns>
        public override string ToString()
      {
         return "\n Product Number: " + ProductNumber + "\n Product Name: " + ProductName + "\n Cost per Unit: $" + CostPerUnit + "\n Items in stock: " + AmountInStock;
      }
   }
}
