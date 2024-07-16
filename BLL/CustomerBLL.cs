using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
//Deutsch and Hirsch
//Class for customer Business layer
{
   public class CustomerBLL
   {
      CustomerDAL cobj = new CustomerDAL();
      #region ctor 
      public CustomerBLL() // parameterless ctor
      {

      }
      #endregion
      #region Read All Customers in Database
      public List<Customer> ReadCustomers()
      {
         return cobj.Read();
      }
      #endregion//reads all customers from database
      #region Read one customer from Database
      public Customer Read(int id)
      {
         try
         {
            return cobj.Read(id);
         }
         catch (CustomerDoesNotExistException dnee)
         {
            throw dnee;
         }

      }
      #endregion////reads one customer from database
      #region Create a new Customer to Database
      public void CreateCustomer(Customer cus)
      {
         try
         {
            cobj.Create(cus);
         }
         catch (CustomerAlreadyExistsException caee)
         {
            throw caee;
         }
      }
      #endregion//calls crud method create to add a new object to the customer list
      #region Remove
      public void Remove(int id)
      {
         try
         {
            cobj.Delete(id);
         }
         catch (CustomerDoesNotExistException dnee)
         {
            throw dnee;
         }
      }
      #endregion//calls crud method delete to remove an object from the customer list
      #region Update   
      public bool Update(Customer c)
      {
         try
         {
            cobj.Update(c);
            return true;
         }
         catch (CustomerDoesNotExistException dnee)
         {
            throw dnee;
         }

      }
      #endregion//calls the update method of dal to update a Customer

   }

}

