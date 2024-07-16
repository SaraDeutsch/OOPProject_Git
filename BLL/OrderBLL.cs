using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class OrderBLL
   {
      OrderDAL oobj = new OrderDAL();
      ProductDAL pobj=new ProductDAL();
      CustomerDAL cobj= new CustomerDAL();
      #region ctor  
      public OrderBLL()
      {

      }//ctor
      #endregion
      #region Create
      public void CreateOrder(Order o)
      {
         bool checkProduct = false;
         bool checkCustomer = false;
         List<Product> plist = pobj.Read();
         foreach(Product p in plist)
         {
            if (p.ProductNumber == o.ProductNumber)
            {
               checkProduct = true;
            }
         }//checks to see if the customer is ordering a product that doesn't exist
         List<Customer> clist = cobj.Read();
         foreach(Customer c in clist)
         {
            if (c.ID == o.CustomerID)
            {
               checkCustomer = true;
            }
         }//checks to see if the ordering customer is in the database already
         if (checkProduct==true && checkCustomer == true)
         {
            try
            {
              
               foreach (Product p in plist)
               { 
                  if (p.ProductNumber == o.ProductNumber)
                  {
                     if (o.OrderQuantity <= p.AmountInStock)
                     {
                        //Product prod = new Product(p.ProductNumber, p.ProductName, p.CostPerUnit, p.AmountInStock - o.OrderQuantity);
                        p.AmountInStock = p.AmountInStock - o.OrderQuantity;
                        //update product in dal on the original list
                        pobj.Update(p);
                        oobj.Create(o);

                     }
                     else
                     {
                        throw new NotEnoughProductException("There is not enough left in stock to place an order of this quantity.");
                     }
                    
                     return;
                  }
               }//if the order was placed remove the quantity of the order from the product stock or throw exception
               throw new ProductDoesNotExistException();
            }
            catch(Exception e)
            {
               throw e;
            }//catches any exception there might be
         }
         else
         {
            throw new CustomerDoesNotExistException();
         }
        
      }
        
      #endregion
      #region ReadOne
      public Order Read(int on)
      {
         try
         {
            return oobj.Read(on);
         }
         catch (OrderDoesNotExistException onee) // exception if user inpputs an order number that does not exsist

         {
            throw onee;
         }

      }
      #endregion
      #region ReadALL
      public List<Order> ReadAllOrders()
      {
         return oobj.Read();
      } // prints the list of orders
      #endregion
      #region ReadByCustomer
      public List<Order> ReadByCustomer(int cid) // prints list of orders of a certain customer
      {
         List<Order> nol = oobj.Read();//list of all orders
         List<Order> col = new List<Order>();//new list with only orders of that customer
         foreach (Order o in nol)
         {
            if (o.CustomerID == cid)
            {
               col.Add(o);
            }
         }
            return col;
           
        }
      #endregion
      #region ReadByProduct 
        // lists all orders that contain a certain product
      public List<Order> ReadByProduct(int pnumber) 
      {
         List<Order> nol = oobj.Read(); // reads list of all orders
         List<Order> pol = new List<Order>(); // creates new empty list to place the products
         foreach (Order o in nol)
         {
            if (o.ProductNumber == pnumber) // if find that prod number in an order
            {
               pol.Add(o); // add it to the list
            }
         }
            return pol;
      }

      #endregion
      #region Update
        // updates an order
      public bool Update(Order o)
      {
         List <Product> plist= pobj.Read(); // reads product list
         List<Order> olist = oobj.Read(); // reads order list
         Order order=null; // creates object of type order
         foreach (Order ord in olist) // find order
         {
            if (ord.OrderNumber == o.OrderNumber) // check to find same order number
            {
               order = ord;
            }
         }//get an original copy of the order
         try
         {
            
            foreach (Product p in plist)
            {
               if (p.ProductNumber == o.ProductNumber)
               {
                  if ((p.AmountInStock+order.OrderQuantity) >= o.OrderQuantity)
                  {
                    // updates order quantity
                     p.AmountInStock += order.OrderQuantity;
                     p.AmountInStock -= o.OrderQuantity;
                     pobj.Update(p);
                     oobj.Update(o);
                     return true;
                  }
                  else
                  {
                     throw new NotEnoughProductException("There is not enough in stock to order that quantity");
                  }
               }
            }//ended loop didn't find product 
            throw new ProductDoesNotExistException();
            throw new OrderDoesNotExistException();
         }
         catch (Exception e)
         {
            throw e;
         }
         

      }
      #endregion
      #region Delete
        //deletes and exsisting order
      public void Remove(int on)
      {
         List<Product> plist = pobj.Read();
         List<Order> olist = oobj.Read();
         Order ord=null;
         
         try
         {
            foreach(Order o in olist)
            {
               if (o.OrderNumber == on)
               {
                  ord = o; 
                  break;
               }
            }//finds the order with the order number
            foreach(Product p in plist)
            {
               if (ord.ProductNumber == p.ProductNumber)
               {
                  p.AmountInStock += ord.OrderQuantity; // updates the order quantity
                  pobj.Update(p);
               }
            }
            oobj.Delete(on);//delete the order
         }
         catch (OrderDoesNotExistException onee)
         {
            throw onee;
         }
      }
      #endregion
   }
}
