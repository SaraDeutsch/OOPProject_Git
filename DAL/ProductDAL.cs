using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.IO;
namespace DAL
//Deutsch and Hirsch
//creating CRUD methods for objects of type product
{
   public class ProductDAL
   {
      static bool readAlready = false;
      public static List<Product> productList = new List<Product>();
        public ProductDAL()
        {
         if (readAlready == false)
         {
            InitializeList();
         }
        }

        StreamReader productListFile = new StreamReader(@"../../../DAL/bin/Debug/ProductList.txt");
      #region InitializeList
      public void InitializeList()//reads in products from a txt file and uses info to create new product objects
      {
         using (productListFile)
         {
            string pnumber = productListFile.ReadLine();
            string pname = productListFile.ReadLine();
            string cpunit = productListFile.ReadLine();
            string amt=productListFile.ReadLine();
            while (pname != null)
            {
               productList.Add(new Product(int.Parse(pnumber), pname, decimal.Parse(cpunit),int.Parse(amt)));
               pnumber = productListFile.ReadLine();
               pname = productListFile.ReadLine();
               cpunit = productListFile.ReadLine();
               amt = productListFile.ReadLine();
            }//end reading in from txt file
         }//end using file
         readAlready = true;
         /* foreach (Product p in productList)
          {
             Console.WriteLine(p);
          }*/
      }//end initialize list
      #endregion
      #region Create
      //method to create a new product 
      public void Create(Product prod)
      {
         Product p = new Product(prod.ProductNumber, prod.ProductName, prod.CostPerUnit, prod.AmountInStock);
         foreach (Product product in productList)
         {
            if (p.ProductNumber == product.ProductNumber)
            {
               throw new ProductAlreadyExistsException("Product already exists.");
            }
         }
         productList.Add(p);

      }
      #endregion
      #region ReadOneProduct
      //method to return one product according to product number
      public Product Read(int pnumber)
      {
         foreach (Product p in productList)
         {
            if (p.ProductNumber == pnumber)
            {
               Product prod = new Product(p.ProductNumber, p.ProductName, p.CostPerUnit, p.AmountInStock);
               return prod;
            }
         }

         throw new ProductDoesNotExistException("There is no product with that product number.");


      }
      #endregion
      #region ReadAllList
      //returns the list of products
      public List<Product> Read()
      {
         List<Product> newProductList = productList.Select(product => new Product(product.ProductNumber,
         product.ProductName, product.CostPerUnit, product.AmountInStock)).ToList();
         return newProductList;
      }
      #endregion
      #region Update
      //changes values of a product
      public bool Update(Product prod)
      {
         for (int i = 0; i < productList.Count; i++)
         {
            if (productList[i].ProductNumber == prod.ProductNumber)
            {
               productList[i].ProductName = prod.ProductName;
               productList[i].CostPerUnit = prod.CostPerUnit;
               productList[i].AmountInStock = prod.AmountInStock;
               return true;
            }

         }
         throw new ProductDoesNotExistException("There is no product with that product number.");
         

      }
      #endregion
      #region Delete
      //deletes a product from the list
      public bool Delete(int pnumber)
      {
         for (int i = 0; i < productList.Count; i++)
         {
            if (productList[i].ProductNumber == pnumber)
            {
               productList.Remove(productList[i]);
               return true;
            }
         }
         throw new ProductDoesNotExistException("There is no product with that product number.");
      }
      #endregion
      #region ToString
      public override string ToString()
      {
         string answer = "";
         foreach (Product p in productList)
         {
            answer += p+"\n";
         }
         return answer;
      }

   
      #endregion


   }//end class ProductDAL
}
