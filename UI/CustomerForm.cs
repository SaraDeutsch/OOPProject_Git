using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
namespace UI
   //Deutsch and Hirsch
   //UI for customers
{
   public partial class CustomerForm : BaseForm // ui customer which inherits from base form
   {
      MainForm mainForm;
      #region ctors
      public CustomerForm()
      {
         InitializeComponent();
      }
      public CustomerForm(MainForm mf) // copy ctor with main form
      {
         InitializeComponent();
         mainForm = mf;
      }
      #endregion
      #region FormLoad 
        // sets up graphics upon loading the form
      private void CustomerForm_Load(object sender, EventArgs e)
      {
         groupBoxCRUD.Visible = true;
         groupBoxCustomerC.Visible = false;
         HideEnterButtons();
         buttonReturn.Visible = false;
         textBoxShowProduct.Visible = false;
         groupBoxCCInput.Visible = false;
      }
      #endregion
      private CustomerBLL cbll = new CustomerBLL();
      #region Create
      protected override void NewMethod() // method that sets up the graphic format for when "create is clicked"
      {
         groupBoxCustomerC.Visible= true;
         groupBoxCRUD.Visible=false;
         textBoxShowProduct.Visible = false;
         ClearTextBoxes();
         HideEnterButtons();
         buttonCEnter.Visible = true;
         buttonReturn.Visible = true;
         groupBoxCCInput.Visible = true;
      }
      protected override void CEnterMethod() // when enter is clicked
      {
        
         try
         {
                Customer c = new Customer(textBoxCName.Text, int.Parse(textBoxID.Text), textBoxCaName.Text, textBoxCNumber.Text, comboBoxMonth.Text + "/" + comboBoxYear.Text, textBoxCvv.Text);
                cbll.CreateCustomer(c);
            MessageBox.Show("Congratulations! You have successfully added a new customer. "+c);
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
         ClearTextBoxes();
         textBoxShowProduct.Visible = true;
         HideEnterButtons();
         groupBoxCRUD.Visible = false;
         buttonReturn.Visible = true;
         List<Customer> lc =cbll.ReadCustomers();
         foreach (Customer c in lc)
         {
            textBoxShowProduct.AppendText(c + "\r\n");
         }
      }
      #endregion
      #region Read
        // graphic set up for when read is clicked
      protected override void ShowMethod()
      {
         groupBoxCustomerC.Visible = true;
         labelName.Visible = false;
         textBoxCName.Visible = false;
         groupBoxCRUD.Visible = false;
         HideEnterButtons();
         buttonREnter.Visible = true;
         ClearTextBoxes();
         buttonReturn.Visible = true;
         groupBoxCCInput.Visible = false;
      }
      protected override void REnterMethod()
      { // when enter is clicked calls CRUD method READ
         try
         {
            textBoxShowProduct.Visible = true;
            textBoxShowProduct.Text = cbll.Read(int.Parse(textBoxID.Text)).ToString();
         }
         catch(Exception e)
         {
            MessageBox.Show(e.Message);
         }
         
      }
      #endregion
      #region Update
        // graphic set up for when update is clicked
      protected override void UpdateMethod()
      {
         ClearTextBoxes() ;   
         groupBoxCustomerC.Visible = true;
         HideEnterButtons();
         buttonUEnter.Visible = true;
         groupBoxCCInput.Visible = true;
      }
      protected override void UEnterMethod()// when enter is clicked calls CRUD method UPDATE
        {
        
         try
         {
            
            Customer c = new Customer(textBoxCName.Text, int.Parse(textBoxID.Text), textBoxCaName.Text, textBoxCNumber.Text, comboBoxMonth.Text + "/" + comboBoxYear.Text, textBoxCvv.Text);

            cbll.Update(c);
            MessageBox.Show("Congratulations! You have successfully updated this customer.");
         }
         catch(Exception e)
         {
            MessageBox.Show(e.Message);
         }
      }
      #endregion
      #region Delete
        // graphic set up for when delete is clicked
      protected override void DeleteMethod()
      {
         ClearTextBoxes();
         groupBoxCRUD.Visible = false;
         groupBoxCustomerC.Visible = true;
         labelName.Visible = false;
         textBoxCName.Visible = false;
         HideEnterButtons();
         buttonDEnter.Visible = true;
         buttonReturn.Visible = true;
         groupBoxCCInput.Visible = false;

      }
      protected override void DEnterMethod() // when enter is pressed, calls CRUD method DELETE
        {
         try
         {
            cbll.Remove(int.Parse(textBoxID.Text));
            MessageBox.Show("Congratulations! You have successfully removed this customer from the database.");
         }
         catch(Exception e)
         {
            MessageBox.Show(e.Message);
         }
        
      }
      #endregion
      #region return button
        // when click return it brings the user back to the same format as form load
      protected override void ReturnMethod()
      {
         groupBoxCRUD.Visible = true;
         groupBoxCustomerC.Visible = false;
         HideEnterButtons();
         buttonReturn.Visible = false;
         textBoxShowProduct.Visible = false;
         ClearTextBoxes();
         groupBoxCCInput.Visible = false;
      }
      #endregion
      #region Clear textboxes
        // method that clears textboxes
      private void ClearTextBoxes()
      {
         textBoxShowProduct.Clear();
         textBoxCName.Clear();
         textBoxID.Clear();
         textBoxCaName.Clear();
         textBoxCNumber.Clear();
         textBoxCvv.Clear();
      }

      #endregion//Method to clear all the text boxes in the form

      #region TSwitches 
        // methods that change the focus upon clicking the "enter" key
      private void textBoxID_KeyDown(object sender, KeyEventArgs e)
      {
         if(e.KeyCode == Keys.Enter)
         {
            textBoxCName.Focus();
         }
      }

      private void textBoxCName_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            textBoxCaName.Focus();
         }
      }

      private void textBoxCaName_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            textBoxCNumber.Focus();
         }
      }

      private void textBoxCNumber_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            comboBoxMonth.Focus();
         }
      }

      private void comboBoxMonth_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            comboBoxYear.Focus();
         }
      }

      private void comboBoxYear_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            textBoxCvv.Focus();
         }
      }
        #endregion //focuses on next textbox when enter key is pressed
        #region Back to Main
        // brings the user to the Main Form
        protected override void BackToMain()
      {
         this.Hide();
         mainForm.Show();
      }
        #endregion

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e) // closes the form
      {
         Application.Exit();
      }

      private void textBoxCNumber_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (!char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
         {
            e.Handled = true;
            
         }
      }
      private void textBoxCvv_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (!char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
         {
            e.Handled = true;
         }
      }
   }
}
