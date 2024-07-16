using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
//Deutsch and Hirsch
//DAL layer for customers
{
   public class CustomerDAL
   {

      private bool readAlready = false;
      public static List<Customer> customerList = new List<Customer>();
      public CustomerDAL()
      {
        if (readAlready == false)
         {
            InitializeList();
         }
        
      }

      StreamReader customerListFile = new StreamReader(@"../../../DAL/bin/Debug/CustomerList.txt");
      #region InitializeList
      public void InitializeList()//reads in products from a txt file and uses info to create new product objects
      {
         using (customerListFile)
         {

            string cid = customerListFile.ReadLine();
            string cname = customerListFile.ReadLine();
            string cardName=customerListFile.ReadLine();
            string cardNumber=customerListFile.ReadLine();
            string expirationDate=customerListFile.ReadLine();
            string cvv=customerListFile.ReadLine();

            while (cname != null) // while there is what to read in the list
            {
               customerList.Add(new Customer(cname, int.Parse(cid),cardName,cardNumber,expirationDate,cvv)); // create a new customer
               cid = customerListFile.ReadLine();
               cname = customerListFile.ReadLine();
               cardName = customerListFile.ReadLine();
               cardNumber = customerListFile.ReadLine();
               expirationDate = customerListFile.ReadLine();
               cvv = customerListFile.ReadLine();

            }//end reading in from txt file
         }//end using file
         readAlready = true;
      }//end initialize list
      #endregion
      #region Create
      //method to create a new customer
      public void Create(Customer cust)
      {
         Customer c = new Customer(cust);
         foreach (Customer customer in customerList)
         {
            if (c.ID == customer.ID)
            {
               throw new CustomerAlreadyExistsException("Customer already exists."); // makes sure the customer doesn't already exsist
            }
         }
         customerList.Add(c);

      }
      #endregion
      #region ReadOneCustomer
      //method to return one customer according to id
      public Customer Read(int id)
      {
         foreach (Customer c in customerList)
         {
            if (c.ID == id)
            {
               Customer cust = new Customer(c);
               return cust;
            }
         }

         throw new CustomerDoesNotExistException("There is no customer with that ID.");


      }
      #endregion
      #region ReadAllList
      //returns the list of customers
      public List<Customer> Read()
      {
         List<Customer> newCustomerList = customerList.Select(customer => new Customer(customer)).ToList();
         return newCustomerList;
      }
      #endregion
      #region Update
      //changes values of a customer
      public bool Update(Customer cust)
      {
         Customer c = new Customer(cust);
         for (int i = 0; i < customerList.Count; i++)
         {
            if (customerList[i].ID == c.ID)
            {
               customerList[i] = c;
             
               return true;
            }

         }
         throw new CustomerDoesNotExistException("There is no customer with that ID.");
      }
      #endregion
      #region Delete
      //deletes a customer from the list
      public bool Delete(int id)
      {
         for (int i = 0; i < customerList.Count; i++)
         {
            if (customerList[i].ID == id)
            {
               customerList.Remove(customerList[i]);
               return true;
            }
         }
         throw new CustomerDoesNotExistException("There is no customer with that ID.");
      }
      #endregion
      #region ToString
      public override string ToString()
      {
         string answer = "";
         foreach (Customer c in customerList)
         {
            answer += c + "\n";
         }
         return answer;
      } // to string


      #endregion


   }
}


