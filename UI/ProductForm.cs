using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
   //Deutsch and Hirsch
{
   public partial class ProductForm : BaseForm
   {
      MainForm mainForm;
      #region ctors 
        // ctor
      public ProductForm()
      {
         InitializeComponent();
      }
      public ProductForm(MainForm mf) // copy ctor generalizing main form
      {
         InitializeComponent();
         mainForm = mf;
      }
      #endregion
      private ProductBLL pbll = new ProductBLL();
      #region Form Load
        // sets up graphics upon loading the form
        private void ProductForm_Load(object sender, EventArgs e)
      {
         groupBoxCRUD.Visible = true;
         HideEnterButtons();
         groupBoxProductC.Visible = false;
         buttonReturn.Visible = false;
         textBoxShowProduct.Visible = false;
      }
      #endregion
      #region Create
      protected override void NewMethod()
      {
            // method that sets up the graphic format for when "create is clicked"
         groupBoxProductC.Visible = true;
         groupBoxCRUD.Visible = false;
         textBoxShowProduct.Visible = false;
         HideEnterButtons();
         buttonCEnter.Visible = true;
         buttonReturn.Visible = true;
         ClearTextBoxes();
      }
      protected override void CEnterMethod()
      { // when enter is clikced
         
         try
         {
                Product p = new Product(int.Parse(textBoxPNumber.Text), textBoxPName.Text, decimal.Parse(textBoxCPU.Text), int.Parse(textBoxamt.Text));
                pbll.CreateProduct(p);
            MessageBox.Show("Congratulations! You have successfully added a new product. " + p);
         }
         catch (Exception e)
         {
            MessageBox.Show(e.Message);
         }

      }
        #endregion
      #region ReadAll
        // graphic set up for when read all is clicked
        protected override void ShowAllMethod()
      {
         groupBoxCRUD.Visible = false;
         groupBoxProductC.Visible=false;
         buttonReturn.Visible = true;
         ClearTextBoxes();
         textBoxShowProduct.Visible = true;
         HideEnterButtons();

         List<Product> lp = pbll.ReadProducts();
         foreach (Product p in lp)
         {
            textBoxShowProduct.AppendText(p + "\r\n");
         }
      }
        #endregion
      #region Read
        // graphic set up for when read is clicked
        protected override void ShowMethod()
      {
         groupBoxProductC.Visible = true;
         labelPName.Visible = false;
         textBoxPName.Visible = false;
         labelCPU.Visible = false;
         textBoxCPU.Visible = false;
         labelamt.Visible = false;
         textBoxamt.Visible = false;
         groupBoxCRUD.Visible = false;
         HideEnterButtons();
         buttonREnter.Visible = true;
         buttonReturn.Visible = true;
         ClearTextBoxes() ;
      }
      protected override void REnterMethod()
      { // when enter is clicked calls crud method READ
         try
         {
            textBoxShowProduct.Visible = true;
            textBoxShowProduct.Text = pbll.Read(int.Parse(textBoxPNumber.Text)).ToString();
         }
         catch (Exception e)
         {
            MessageBox.Show(e.Message);
         }

      }
        #endregion
      #region Update
        // graphic set up for when update is clicked
        protected override void UpdateMethod()
      {
         groupBoxProductC.Visible = true;
         HideEnterButtons();
         buttonUEnter.Visible = true;
         groupBoxCRUD.Visible = false;
         buttonReturn.Visible = true;
         textBoxShowProduct.Visible = false;
         ClearTextBoxes();
      }
      protected override void UEnterMethod()// when enter is clicked calls CRUD method UPDATE
      {
         
         try
         {
                Product p = new Product(int.Parse(textBoxPNumber.Text), textBoxPName.Text, decimal.Parse(textBoxCPU.Text), int.Parse(textBoxamt.Text));
                pbll.Update(p);
            MessageBox.Show("Congratulations! You have successfully updated this product.");
         }
         catch (Exception e)
         {
            MessageBox.Show(e.Message);
         }
      }
      #endregion
      #region Delete
      protected override void DeleteMethod()// graphic set up for when delete is clicked
        {
         groupBoxCRUD.Visible = false;
         groupBoxProductC.Visible = true;
         labelPName.Visible = false;
         textBoxPName.Visible = false;
         labelCPU.Visible = false;
         textBoxCPU.Visible = false;
         labelamt.Visible = false;
         textBoxamt.Visible = false;
         HideEnterButtons();
         buttonDEnter.Visible = true;
         textBoxShowProduct.Visible = false;
         buttonReturn.Visible = true;
         ClearTextBoxes() ;

      }
      protected override void DEnterMethod()// when enter is pressed, calls CRUD method DELETE
      {
         try
         {
            pbll.Remove(int.Parse(textBoxPNumber.Text));
            MessageBox.Show("Congratulations! You have successfully removed this product from the database");
         }
         catch (Exception e)
         {
            MessageBox.Show(e.Message);
         }

      }
      #endregion
      #region return button
      protected override void ReturnMethod()  // when click return it brings the user back to the same format as form load
        {
         groupBoxCRUD.Visible = true;
         labelPName.Visible = true;
         textBoxPName.Visible = true;
         labelCPU.Visible = true;
         textBoxCPU.Visible = true;
         labelamt.Visible = true;
         textBoxamt.Visible = true;  //allows et in gb to be visible when the gb is visible
         groupBoxProductC.Visible = false;
         HideEnterButtons();
         buttonReturn.Visible = false;
         textBoxShowProduct.Visible = false;
         ClearTextBoxes();
      }
      #endregion
      #region Cleartext
      private void ClearTextBoxes()   // method that clears all textboxes in the form
        {
         textBoxPNumber.Clear();
         textBoxPName.Clear();
         textBoxCPU.Clear();
         textBoxamt.Clear();
         textBoxShowProduct.Clear();
      }
      #endregion
      #region TSwitches
      private void textBoxPNumber_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            textBoxPName.Focus();
         }
      }

      private void textBoxPName_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            textBoxCPU.Focus();
         }
      }

      private void textBoxCPU_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            textBoxamt.Focus();
         }
      }
        #endregion
      #region BackToMain
        protected override void BackToMain() // when user clicks button, brings user to main form
      {
         this.Hide();
         mainForm.Show();
      }
        #endregion


        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e) // closes the form
      {
         Application.Exit();
      }
   }
   #region Previous Code
   /*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BLL;

namespace UI
   //Deutsch and Hirsch
   //UI layer 
{
   public partial class PForm : Form
   {
      #region ctor
      public PForm()
      {
         InitializeComponent();
      }
      #endregion
      #region FormLoad
      private void Form1_Load(object sender, EventArgs e)
      {
         HideInput();
      }
      #endregion
      ProductBLL pbll = new ProductBLL();
      #region Create
      private void buttonCreate_Click(object sender, EventArgs e)
      {
         HideControls();
         DisplayInput();
         buttonCEnter.Show();
      }
      private void buttonCEnter_Click(object sender, EventArgs e)
      {
         int pnum = 0;
         pnum=int.Parse(textBoxPnumber.Text);
         string pname = "";
         pname=textBoxPname.Text;
         decimal cpu = 0.0m;
         cpu=decimal.Parse(textBoxCPU.Text);
         int amtInStock = 0;
         amtInStock= int.Parse(textBoxAmtInStock.Text);
         Product prod=new Product(pnum,pname,cpu,amtInStock);//creates a new object of type product based on user input

         try
         {
            pbll.CreateProduct(prod);//adds product to the product list
            MessageBox.Show("Congratulations! You successfully added a new product: " + prod);
         }

         catch (ProductAlreadyExistsException paee)
         {
            MessageBox.Show(paee.Message);
         }

      }
      #endregion
      #region ReadAll
      private void buttonReadAll_Click(object sender, EventArgs e)
      {
         textBoxShowProduct.Show();
         buttonReturn.Show();
         List<Product> pList = new List<Product>();
         pList= pbll.ReadProducts();
         foreach (Product p in pList)
         {
            textBoxShowProduct.AppendText(p + "\r\n");
         }
      }
      #endregion
      #region ReadOne
      private void buttonRead_Click(object sender, EventArgs e)
      {
         labelPNumber.Show();
         textBoxPnumber.Show();
         buttonREnter.Show();
         buttonReturn.Show();
      }
      private void buttonREnter_Click(object sender, EventArgs e)
      {
         try
         {
            int pnumber = 0;
            pnumber = int.Parse(textBoxPnumber.Text);
            Product p = pbll.Read(pnumber);
            textBoxShowProduct.Text = p.ToString();
            textBoxShowProduct.Show();
         }
         catch (ProductDoesNotExistException dnee)
         {
            MessageBox.Show(dnee.Message);
         }
      }
      #endregion//gets a pnumber and sends writes out the product info of that number
      #region Update
      private void buttonUpdate_Click(object sender, EventArgs e)
      {
         HideControls();
         HideInput();
         DisplayInput();
         buttonUEnter.Show();
      }
      private void buttonUEnter_Click(object sender, EventArgs e)
      {
         int pnumber = 0;
         pnumber=int.Parse(textBoxPnumber.Text);
         string pname = "";
         pname=textBoxPname.Text;
         decimal cpu = 0.0m;
         cpu=decimal.Parse(textBoxCPU.Text);
         int amt = 0;
         amt=int.Parse(textBoxAmtInStock.Text);
         Product n = new Product(pnumber, pname, cpu, amt);
         try
         {
            pbll.Update(n);
            MessageBox.Show("Congratulations! You have successfully changed a product: " + n);
         }
         catch(ProductDoesNotExistException dnee)
         {
            MessageBox.Show(dnee.Message);
         }
         
      }

      #endregion//gets new info and updates a product
      #region Delete
      private void buttonDelete_Click(object sender, EventArgs e)
      {
         HideInput();
         labelPNumber.Show();
         textBoxPnumber.Show();
         buttonDEnter.Show();
         buttonReturn.Show();
      }
      private void buttonDEnter_Click(object sender, EventArgs e)
      {
         try
         {
            int pnumber = 0;
            pnumber = int.Parse(textBoxPnumber.Text);
            pbll.Remove(pnumber);
            MessageBox.Show("Congratulations! You have successfully deleted this product");
         }
         catch(ProductDoesNotExistException dnee)
         {
            MessageBox.Show(dnee.Message);
         }
      }
      #endregion//gets a product number and deletes that item

      #region Return
      private void buttonReturn_Click(object sender, EventArgs e)
      {
         HideInput();
         DisplayControls();
      }
      #endregion//returns to Main Menu

      #region HideControls
      private void HideControls()//method to hide all the buttons
      {
         buttonCreate.Hide();
         buttonRead.Hide();
         buttonReadAll.Hide();
         buttonUpdate.Hide();
         buttonDelete.Hide();
      }
      #endregion
      #region HideInput
      private void HideInput()//method to hide all the GUIs not part of main menu
      {
         labelAmtInStock.Hide();
         textBoxAmtInStock.Hide();
         textBoxAmtInStock.Clear();
         labelCostPUnit.Hide();
         textBoxCPU.Hide();
         textBoxCPU.Clear();
         labelPName.Hide();
         textBoxPname.Hide();
         textBoxPname.Clear();
         labelPNumber.Hide();
         textBoxPnumber.Hide();
         textBoxPnumber.Clear();
         buttonCEnter.Hide();
         buttonReturn.Hide();
         buttonREnter.Hide();
         buttonUEnter.Hide();
         buttonDEnter.Hide();
         textBoxShowProduct.Hide();
         textBoxShowProduct.Clear();
         buttonReturn.Hide();
        
      }
      #endregion
      #region DisplayInput
      private void DisplayInput()//method to show the textboxes and labels
      {
         labelAmtInStock.Show();
         textBoxAmtInStock.Show();
         labelCostPUnit.Show();
         textBoxCPU.Show();
         labelPName.Show();
         textBoxPname.Show();
         labelPNumber.Show();
         textBoxPnumber.Show();
         buttonReturn.Show();
         
      }

      #endregion
      #region DisplayControls
      private void DisplayControls()
      {
         buttonCreate.Show();
         buttonRead.Show();
         buttonReadAll.Show();
         buttonUpdate.Show();
         buttonDelete.Show();
      }



      #endregion

      #region EnterKeyClicks
      private void textBoxPnumber_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            textBoxPname.Focus();
         }
      }

      private void textBoxPname_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            textBoxCPU.Focus();
         }
      }

      private void textBoxCPU_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            textBoxAmtInStock.Focus();
         }
      }
      #endregion//each time you click enter at it moves the cursor to the next txtbox


   }
}
*/
   #endregion
}
