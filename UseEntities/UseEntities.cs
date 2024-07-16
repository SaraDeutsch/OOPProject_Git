using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseEntities;
using Entities;
using System.IO;
using DAL;
using BLL;


namespace UseEntities
//Deutsch and Hirsch
//creates and initializes values of objects of all the classes
{
   public class UseEntities
   {
      static void Main(string[] args)
      {
         Person[] people = new Person[3];
         StreamReader personID = new StreamReader("PersonID.txt");
         using (personID)
         {
            int counter = 0;
            string name = personID.ReadLine();
            string id = personID.ReadLine();
            while (name != null)
            {
               people[counter] = new Person(name, int.Parse(id));
               counter++;
               name = personID.ReadLine();
               id = personID.ReadLine();
            }
         }

         for (int i = 0; i < people.Length; i++)
         {
            Console.WriteLine(people[i]);
         }
         //ProductDAL pdal = new ProductDAL();
         //Product prod = new Product(19, "ldjlja", 0.98m,0);
         //Product p = new Product(16, "lioe", 0.87m,30);
         //Console.WriteLine(pdal);//checks tostring
         /*Console.WriteLine(pdal.Read(10));//checks read
         productDAL.Create(prod);//checks create
         Console.WriteLine(pdal);
         productDAL.Delete(19);//checks delete
         Console.WriteLine(pdal);*/
         /*  ProductBLL pbll = new ProductBLL();
           Console.WriteLine(pbll.ReadProducts());
              pbll.CreateProduct(prod);
           pbll.CreateProduct(p);
           pbll.Update(p);
              Console.WriteLine(pbll.Read(12));
              Console.WriteLine(pbll.Read(34));
           Console.WriteLine(pdal);*/
         CustomerBLL cbll = new CustomerBLL();
         Console.WriteLine(cbll.ReadCustomers());
        /* CreditCard cc = new CreditCard("Ariella Hirsch", "0213654987456321", "02/12", "523");
            Console.WriteLine(cc);*/
        }
   }
}
