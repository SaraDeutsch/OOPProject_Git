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
    // UI BaseForm -- graphic setup of the properties that all inheriting forms possess. 
{
   public partial class BaseForm : Form
   {
      public BaseForm()
      {
         InitializeComponent();
      }

      private void buttonCreate_Click(object sender, EventArgs e)
      {
         NewMethod();
      }
      protected virtual void NewMethod() { }


      //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
      private void buttonRead_Click(object sender, EventArgs e)
      {
         ShowMethod();
      }
      protected virtual void ShowMethod() { }
      //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
      private void buttonReadAll_Click(object sender, EventArgs e)
      {
         ShowAllMethod();
      }
      protected virtual void ShowAllMethod() { }


      //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
      private void buttonUpdate_Click(object sender, EventArgs e)
      {
         UpdateMethod();
      }
      protected virtual void UpdateMethod() { }


      //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
      private void buttonDelete_Click(object sender, EventArgs e)
      {
         DeleteMethod();
      }
      protected virtual void DeleteMethod() { }


      //++++++++++++++++++++++++++++++++++++++++++++++++
    
      private void buttonCEnter_Click_1(object sender, EventArgs e)
      {
         CEnterMethod();
      }
      protected virtual void CEnterMethod() { }


      //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++
      private void buttonREnter_Click(object sender, EventArgs e)
      {
         REnterMethod();
      }
      protected virtual void REnterMethod() { }


      //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
      private void buttonUEnter_Click(object sender, EventArgs e)
      {
         UEnterMethod();
      }
      protected virtual void UEnterMethod() { }


      //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
      private void buttonDEnter_Click(object sender, EventArgs e)
      {
         DEnterMethod();
      }
      protected virtual void DEnterMethod() { }
      //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
      private void buttonReturn_Click(object sender, EventArgs e)
      {
         ReturnMethod();
      }
      protected virtual void ReturnMethod() { }
      protected void HideEnterButtons()
      {
         buttonCEnter.Visible = false;
         buttonREnter.Visible = false;
         buttonUEnter.Visible = false;
         buttonDEnter.Visible = false;
      }

      private void buttonMainMenu_Click(object sender, EventArgs e)
      {
         BackToMain();
      }
      protected virtual void BackToMain() { }
   }
}
