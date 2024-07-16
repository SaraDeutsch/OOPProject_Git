using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BLL
//Deutsch and Hirsch
//Class for product Business layer
{
   public class ProductBLL
   {
      ProductDAL pobj = new ProductDAL();
      #region ctor 
      public ProductBLL() // parameterless ctor
      {
         
      }
      #endregion
      #region Read All Products in Database
      public List<Product> ReadProducts()
      {
         return pobj.Read();
      }
      #endregion//reads all products from database
      #region Read one product from Database
        //reads one product
      public Product Read(int prodnumber)
      {
         try
         {
            return pobj.Read(prodnumber);
         }
         catch (ProductDoesNotExistException dnee)
         {
            throw dnee;
         }
       
      }
      #endregion////calls crud method read to read one product from database
      #region Create a new Product to Database
      public void CreateProduct(Product pro)
      {
         try
         {
            pobj.Create(pro);
         }
         catch(ProductAlreadyExistsException paee)
         {
            throw paee;
         }
      }
      #endregion//calls crud method create to add a new object to the product list
      #region Remove
      public void Remove(int prodnumber)
      {
         try
         {
            pobj.Delete(prodnumber);
         }
         catch(ProductDoesNotExistException dnee)
         {
            throw dnee;
         }
      }
      #endregion//calls crud method delete to remove an object from the product list
      #region Update
      public bool Update(Product p)
      {
         try
         {
            pobj.Update(p);
            return true;
         }
         catch(ProductDoesNotExistException dnee)
         {
            throw dnee;
         }

      }
        #endregion//calls the update method of dal to update a product
      
    }
}
