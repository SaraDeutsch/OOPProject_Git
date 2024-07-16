using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
   //Pealman???? and Hirsch
   //DAL layer for orders
{
   public class OrderDAL
   {
      private static bool readAlready = false;
      public static List<Order> orderList = new List<Order>();
      #region ctor
      public OrderDAL() // ctor
      {
        if (readAlready==false)
         InitializeList();
      }
      #endregion
      #region Initialize List
      StreamReader orderListFile = new StreamReader(@"../../../DAL/bin/Debug/OrderList.txt");
      public void InitializeList()//reads in info from a text file to create new orders
      {
         using(orderListFile)
         {
            string pnumber=orderListFile.ReadLine();
            string cid=orderListFile.ReadLine();
            string orderq=orderListFile.ReadLine();
            while (pnumber != null)
            {
               orderList.Add(new Order(int.Parse(pnumber), int.Parse(cid), int.Parse(orderq)));
               pnumber = orderListFile.ReadLine();
               cid = orderListFile.ReadLine();
               orderq = orderListFile.ReadLine();
            }
         }//end reading from text file
         readAlready = true;
      }
      #endregion
      #region Create
        // creates a new order
      public void Create(Order order)
      {
         Order o = new Order(order);
         orderList.Add(o); // adds the order to order list
      }
      #endregion
      #region ReadOne
        
      public Order Read(int on)
      {
         foreach (Order o in orderList)
         {
            if (o.OrderNumber == on)
            {
               Order order = new Order(o);
               return order;
            }
         }
         throw new OrderDoesNotExistException("There is no order with that order number.");
      }
      #endregion//returns the order details for a specific order number
      #region ReadAll
      public List<Order> Read()
      {
         List<Order> newOrderList = orderList.Select(order => new Order(order)).ToList();
         return newOrderList;
      }
        //returns list of orders
      #endregion
      #region ReadByCustomer
   /*   public List<Order> Read(int cid)
      {
         List<Order> newOrderList = orderList.Select(order => new Order(order)).ToList();
         return newOrderList;
      }*/
      #endregion
      #region Update
        // updates order
      public bool Update(Order order)
      {
         Order o = order;
         for (int i = 0; i < orderList.Count; i++)
         {
            if (orderList[i].OrderNumber == o.OrderNumber)
            {
               orderList[i].OrderQuantity = o.OrderQuantity; //customers can only update the order quantity.
               return true;
            }

         }
         throw new OrderDoesNotExistException("There is no order with that order number.");
      }
      #endregion
      #region Delete
        //deletes an order
      public bool Delete(int on)
      {
         for (int i = 0; i < orderList.Count; i++)
         {
            if (orderList[i].OrderNumber == on)
            {
               orderList.Remove(orderList[i]);
               return true;
            }
         }
         throw new OrderDoesNotExistException("There is no order with that order number.");
      }
      #endregion
      #region ToString
      public override string ToString()
      {
         string answer = "";
         foreach (Order o in orderList)
         {
            answer += o+ "\n";
         }
         return answer;
      }
      #endregion
   }
}
