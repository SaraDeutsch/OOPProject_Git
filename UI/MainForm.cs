using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
    // Deutsch and Hirsch
    //Main Form UI-- displays three buttons Customers, Orders, and Products
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();
      }


    // if click Customers -- bring to customers form
      private void buttonCustomers_Click(object sender, EventArgs e)
      {
         CustomerForm cf=new CustomerForm(this);
         cf.Show();
         this.Hide();
      }

        // if click products -- bring to products form
      private void buttonProducts_Click(object sender, EventArgs e)
      {
         ProductForm pf=new ProductForm(this);
         pf.Show();
         this.Hide();
      }
        // if click orders -- bring to orders form
      private void buttonOrders_Click(object sender, EventArgs e)
      {
         OrderForm of = new OrderForm(this);
         of.Show();
         this.Hide();
      }
   }
}
