using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    //Deutsch and Hirsch
    public partial class OrderForm : BaseForm
    // UI layer for Order, inheriting from base form
    {
        MainForm mainForm;
        #region ctors
        //ctor
        public OrderForm()
        {
            InitializeComponent();
        }
        public OrderForm(MainForm mf)
        {
            InitializeComponent();
            mainForm = mf;
        }
        #endregion
        #region form Load

        private void OrderForm_Load(object sender, EventArgs e)
        {// graphic format for the Form Load
            groupBoxCRUD.Visible = true;
            groupBoxOrderC.Visible = false;
            HideEnterButtons();
            buttonReturn.Visible = false;
            textBoxShowProduct.Visible = false;
            labelReadByDirections.Visible = false;
        }
        #endregion
        private OrderBLL obll = new OrderBLL();
        #region Create


        protected override void NewMethod()
        { // graphic format for "create" a method
            groupBoxOrderC.Visible = true;
            labelON.Visible = false;
            textBoxon.Visible = false;
            groupBoxCRUD.Visible = false;
            textBoxShowProduct.Visible = false;
            ClearTextBoxes();
            HideEnterButtons();
            buttonCEnter.Visible = true;
            buttonReturn.Visible = true;
        }
        protected override void CEnterMethod()
        // upon clicking the enter button for create
        {

            try
            {
                Order o = new Order(int.Parse(textBoxpn.Text), int.Parse(textBoxcid.Text), int.Parse(textBoxoq.Text));
                obll.CreateOrder(o);
                MessageBox.Show("Congratulations! You have successfully placed an order. " + o);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        #endregion
        #region ReadBy
        // graphic format for reading a method and calls the read method
        protected override void ShowMethod()
        {
            groupBoxOrderC.Visible = true;
            /* labelPN.Visible = false;
             textBoxpn.Visible = false;
             labelCID.Visible = false;
             textBoxcid.Visible = false;*/
            labelReadByDirections.Visible = true;
            labelOQ.Visible = false;
            textBoxoq.Visible = false;
            groupBoxCRUD.Visible = false;
            HideEnterButtons();
            buttonREnter.Visible = true;
            ClearTextBoxes();
            buttonReturn.Visible = true;

        }
        protected override void REnterMethod()
        { // upon clicking endter
            try
            {
                
                textBoxShowProduct.Visible = true;
                if (textBoxcid.Text != "")
                {
                   
                    foreach (Order o in (obll.ReadByCustomer(int.Parse(textBoxcid.Text))))
                    {
                        textBoxShowProduct.AppendText(o + "\r\n");
                    }

                }//if the user entered a cid then read all the orders for that customer
                else if (textBoxon.Text != "")
                {
                    textBoxShowProduct.Text = obll.Read(int.Parse(textBoxon.Text)).ToString();
                }//if the user entered an order number then just read that order
                else if (textBoxpn.Text != "")
                {
                    foreach (Order o in (obll.ReadByProduct(int.Parse(textBoxpn.Text))))
                    {
                        textBoxShowProduct.AppendText(o + "\r\n");
                    }
                    
                }//if the user entered a product number then read all the orders that contain that product

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        #endregion
        #region ReadALL
        // displays list upon clicking readall
        protected override void ShowAllMethod()
        {
            ClearTextBoxes();
            textBoxShowProduct.Visible = true;
            HideEnterButtons();
            groupBoxCRUD.Visible = false;
            buttonReturn.Visible = true;
            List<Order> lo = obll.ReadAllOrders();
            foreach (Order o in lo)
            {
                textBoxShowProduct.AppendText(o + "\r\n");
            }
        }
        #endregion
        #region Update
        // graphic format for update and calls the appropriate methods
        protected override void UpdateMethod()
        {// format upon clicking update
            ClearTextBoxes();
            groupBoxOrderC.Visible = true;
            labelPN.Visible = false;
            textBoxpn.Visible = false;
            labelCID.Visible = false;
            textBoxcid.Visible = false;
            HideEnterButtons();
            buttonUEnter.Visible = true;
        }
        protected override void UEnterMethod()
        { // upon clicking enter
            List<Order> olist = obll.ReadAllOrders();
            Order o = null;

            try
            {
                foreach (Order ord in olist)
                {
                    if (int.Parse(textBoxon.Text) == ord.OrderNumber)
                    {
                        o = ord;
                    }
                }//find the orginal order
                o.OrderQuantity = int.Parse(textBoxoq.Text);//change the quantity

                obll.Update(o);//update in the database
                MessageBox.Show("Congratulations! You have successfully updated the quantity of your order to " + textBoxoq.Text + " .");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion
        #region Delete
        // graphic format for delete and appropriate methods
        protected override void DeleteMethod()
        { // format upon clicing delete
            ClearTextBoxes();
            groupBoxCRUD.Visible = false;
            groupBoxOrderC.Visible = true;
            labelPN.Visible = false;
            textBoxpn.Visible = false;
            labelCID.Visible = false;
            textBoxcid.Visible = false;
            labelOQ.Visible = false;
            textBoxoq.Visible = false;
            HideEnterButtons();
            buttonDEnter.Visible = true;
            buttonReturn.Visible = true;
        }
        protected override void DEnterMethod()
        { // upon clicking enter calls the CRUD remove
            try
            {
                obll.Remove(int.Parse(textBoxon.Text));
                MessageBox.Show("Congratulations! You have successfully deleted the order.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        #endregion
        #region return button
        // method to bring user to the formload format
        protected override void ReturnMethod()
        {
            groupBoxCRUD.Visible = true;
            groupBoxOrderC.Visible = false;
            HideEnterButtons();
            buttonReturn.Visible = false;
            textBoxShowProduct.Visible = false;
            ClearTextBoxes();
            labelReadByDirections.Visible = false;
        }
        #endregion
        #region Clear text boxes
        private void ClearTextBoxes() // method to clear textboxes
        {
            textBoxShowProduct.Clear();
            textBoxon.Clear();
            textBoxcid.Clear();
            textBoxpn.Clear();
            textBoxoq.Clear();
            labelCID.Visible = true;
            textBoxcid.Visible = true;
            labelPN.Visible = true;
            textBoxpn.Visible = true;
            labelOQ.Visible = true;
            textBoxoq.Visible = true;
            labelON.Visible = true;
            textBoxon.Visible = true; //allows any hiding of specific labels or tb to be shown again

        }
        #endregion
        #region BackToMain
        // brings user back to main form
        protected override void BackToMain()
        {
            this.Hide();
            mainForm.Show();
        }
        #endregion
        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        } // closes form

        #region TSwitches
        // focuses the textboxes upon clicking the enter key
        private void textBoxon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxpn.Focus();
            }
        }

        private void textBoxpn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxcid.Focus();
            }
        }
        /* private void textBoxcid_KeyDown(object sender, KeyEventArgs e)
         {
            if (e.KeyCode == Keys.Enter)
            {
               textBoxoq.Focus();
            }
         }*/


        private void textBoxcid_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxoq.Focus();
            }
        }
        #endregion
    }
}
