using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
//Deutsch and Hirsch
//List of exceptions in solution
{
   #region Product Already Exists   
   public class ProductAlreadyExistsException : Exception //exception if user tries adding a prodcut that already exsists
   {
      public ProductAlreadyExistsException() : base("This product already exists.")
      {

      }
      public ProductAlreadyExistsException(string messageValue) : base(messageValue)
      {

      }
      public ProductAlreadyExistsException(string messageValue, Exception inner) : base(messageValue, inner)
      {

      }
   }
   #endregion//if user wants to add a product that already exists
   #region Product Does Not Exist
   public class ProductDoesNotExistException : Exception
   {
      public ProductDoesNotExistException() : base("This product does not exist.")
      {

      }
      public ProductDoesNotExistException(string messageValue) : base(messageValue)
      {

      }
      public ProductDoesNotExistException(string messageValue, Exception inner) : base(messageValue, inner)
      {

      }
   }
   #endregion//if user is looking for or wants to delete a product that doesn't exist
   #region Customer Already Exists
   public class CustomerAlreadyExistsException : Exception
   {
      public CustomerAlreadyExistsException() : base("This customer already exists.")
      {

      }
      public CustomerAlreadyExistsException(string messageValue) : base(messageValue)
      {

      }
      public CustomerAlreadyExistsException(string messageValue, Exception inner) : base(messageValue, inner)
      {

      } // exception if customer already exsists
   }
   #endregion
   #region Customer Does Not Exist
   public class CustomerDoesNotExistException : Exception
   {
      public CustomerDoesNotExistException() : base("This customer does not exist.")
      {

      }
      public CustomerDoesNotExistException(string messageValue) : base(messageValue)
      {

      }
      public CustomerDoesNotExistException(string messageValue, Exception inner) : base(messageValue, inner)
      {

      }
   }
   #endregion
   #region Order Does Not Exist
   public class OrderDoesNotExistException : Exception
   {
      public OrderDoesNotExistException() : base("This order does not exist.")
      {

      }
      public OrderDoesNotExistException(string messageValue) : base(messageValue)
      {

      }
      public OrderDoesNotExistException(string messageValue, Exception inner) : base(messageValue, inner)
      {

      } //exception if user inputs a order number that does not exsist
   }
   #endregion
   #region Not Enough Product
   public class NotEnoughProductException : Exception
   {
        public NotEnoughProductException():base("There is not enough product left.")
        {
            
        }
        public NotEnoughProductException(string messageValue):base(messageValue)
        {
            
        }
        public NotEnoughProductException(string messageValue, Exception inner):base(messageValue,inner)
        {
            
        }
        //exception if user order more of a product than in stock
    }
   #endregion

}


