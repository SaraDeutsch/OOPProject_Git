namespace UI
{
   partial class CustomerForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.groupBoxCustomerC = new System.Windows.Forms.GroupBox();
            this.textBoxCName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.groupBoxCCInput = new System.Windows.Forms.GroupBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.textBoxCvv = new System.Windows.Forms.TextBox();
            this.textBoxCNumber = new System.Windows.Forms.TextBox();
            this.textBoxCaName = new System.Windows.Forms.TextBox();
            this.labelCvv = new System.Windows.Forms.Label();
            this.labelExpirationDate = new System.Windows.Forms.Label();
            this.labelCNumber = new System.Windows.Forms.Label();
            this.labelCaName = new System.Windows.Forms.Label();
            this.groupBoxCRUD.SuspendLayout();
            this.groupBoxCustomerC.SuspendLayout();
            this.groupBoxCCInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxShowProduct
            // 
            this.textBoxShowProduct.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxShowProduct.Size = new System.Drawing.Size(576, 885);
            // 
            // buttonCEnter
            // 
            this.buttonCEnter.Location = new System.Drawing.Point(220, 422);
            this.buttonCEnter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            // 
            // groupBoxCustomerC
            // 
            this.groupBoxCustomerC.Controls.Add(this.textBoxCName);
            this.groupBoxCustomerC.Controls.Add(this.textBoxID);
            this.groupBoxCustomerC.Controls.Add(this.labelName);
            this.groupBoxCustomerC.Controls.Add(this.labelID);
            this.groupBoxCustomerC.Location = new System.Drawing.Point(14, 15);
            this.groupBoxCustomerC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxCustomerC.Name = "groupBoxCustomerC";
            this.groupBoxCustomerC.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxCustomerC.Size = new System.Drawing.Size(313, 125);
            this.groupBoxCustomerC.TabIndex = 19;
            this.groupBoxCustomerC.TabStop = false;
            // 
            // textBoxCName
            // 
            this.textBoxCName.Location = new System.Drawing.Point(108, 68);
            this.textBoxCName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCName.Name = "textBoxCName";
            this.textBoxCName.Size = new System.Drawing.Size(97, 26);
            this.textBoxCName.TabIndex = 4;
            this.textBoxCName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCName_KeyDown);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(107, 19);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(98, 26);
            this.textBoxID.TabIndex = 3;
            this.textBoxID.UseWaitCursor = true;
            this.textBoxID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxID_KeyDown);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 75);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(21, 26);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 20);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // groupBoxCCInput
            // 
            this.groupBoxCCInput.Controls.Add(this.comboBoxMonth);
            this.groupBoxCCInput.Controls.Add(this.comboBoxYear);
            this.groupBoxCCInput.Controls.Add(this.textBoxCvv);
            this.groupBoxCCInput.Controls.Add(this.textBoxCNumber);
            this.groupBoxCCInput.Controls.Add(this.textBoxCaName);
            this.groupBoxCCInput.Controls.Add(this.labelCvv);
            this.groupBoxCCInput.Controls.Add(this.labelExpirationDate);
            this.groupBoxCCInput.Controls.Add(this.labelCNumber);
            this.groupBoxCCInput.Controls.Add(this.labelCaName);
            this.groupBoxCCInput.Location = new System.Drawing.Point(14, 161);
            this.groupBoxCCInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxCCInput.Name = "groupBoxCCInput";
            this.groupBoxCCInput.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxCCInput.Size = new System.Drawing.Size(206, 366);
            this.groupBoxCCInput.TabIndex = 27;
            this.groupBoxCCInput.TabStop = false;
            this.groupBoxCCInput.Text = "Credit Card";
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBoxMonth.Location = new System.Drawing.Point(10, 218);
            this.comboBoxMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(59, 28);
            this.comboBoxMonth.TabIndex = 9;
            this.comboBoxMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxMonth_KeyDown);
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35"});
            this.comboBoxYear.Location = new System.Drawing.Point(91, 218);
            this.comboBoxYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(85, 28);
            this.comboBoxYear.TabIndex = 8;
            this.comboBoxYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxYear_KeyDown);
            // 
            // textBoxCvv
            // 
            this.textBoxCvv.Location = new System.Drawing.Point(26, 301);
            this.textBoxCvv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCvv.MaxLength = 3;
            this.textBoxCvv.Name = "textBoxCvv";
            this.textBoxCvv.Size = new System.Drawing.Size(112, 26);
            this.textBoxCvv.TabIndex = 6;
            // 
            // textBoxCNumber
            // 
            this.textBoxCNumber.Location = new System.Drawing.Point(10, 142);
            this.textBoxCNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCNumber.MaxLength = 16;
            this.textBoxCNumber.Name = "textBoxCNumber";
            this.textBoxCNumber.Size = new System.Drawing.Size(188, 26);
            this.textBoxCNumber.TabIndex = 5;
            this.textBoxCNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCNumber_KeyDown);
            this.textBoxCNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCNumber_KeyPress);
            // 
            // textBoxCaName
            // 
            this.textBoxCaName.Location = new System.Drawing.Point(36, 65);
            this.textBoxCaName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCaName.Name = "textBoxCaName";
            this.textBoxCaName.Size = new System.Drawing.Size(112, 26);
            this.textBoxCaName.TabIndex = 4;
            this.textBoxCaName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCaName_KeyDown);
            // 
            // labelCvv
            // 
            this.labelCvv.AutoSize = true;
            this.labelCvv.Location = new System.Drawing.Point(28, 262);
            this.labelCvv.Name = "labelCvv";
            this.labelCvv.Size = new System.Drawing.Size(108, 20);
            this.labelCvv.TabIndex = 3;
            this.labelCvv.Text = "Security Code";
            // 
            // labelExpirationDate
            // 
            this.labelExpirationDate.AutoSize = true;
            this.labelExpirationDate.Location = new System.Drawing.Point(28, 194);
            this.labelExpirationDate.Name = "labelExpirationDate";
            this.labelExpirationDate.Size = new System.Drawing.Size(118, 20);
            this.labelExpirationDate.TabIndex = 2;
            this.labelExpirationDate.Text = "Expiration Date";
            // 
            // labelCNumber
            // 
            this.labelCNumber.AutoSize = true;
            this.labelCNumber.Location = new System.Drawing.Point(18, 119);
            this.labelCNumber.Name = "labelCNumber";
            this.labelCNumber.Size = new System.Drawing.Size(190, 20);
            this.labelCNumber.TabIndex = 1;
            this.labelCNumber.Text = "Card Number (no spaces)";
            // 
            // labelCaName
            // 
            this.labelCaName.AutoSize = true;
            this.labelCaName.Location = new System.Drawing.Point(33, 41);
            this.labelCaName.Name = "labelCaName";
            this.labelCaName.Size = new System.Drawing.Size(111, 20);
            this.labelCaName.TabIndex = 0;
            this.labelCaName.Text = "Name on Card";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 921);
            this.Controls.Add(this.groupBoxCCInput);
            this.Controls.Add(this.groupBoxCustomerC);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "CustomerForm";
            this.Text = "Customer Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerForm_FormClosing);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.Controls.SetChildIndex(this.textBoxShowProduct, 0);
            this.Controls.SetChildIndex(this.groupBoxCRUD, 0);
            this.Controls.SetChildIndex(this.buttonReturn, 0);
            this.Controls.SetChildIndex(this.buttonCEnter, 0);
            this.Controls.SetChildIndex(this.buttonREnter, 0);
            this.Controls.SetChildIndex(this.buttonUEnter, 0);
            this.Controls.SetChildIndex(this.buttonDEnter, 0);
            this.Controls.SetChildIndex(this.groupBoxCustomerC, 0);
            this.Controls.SetChildIndex(this.groupBoxCCInput, 0);
            this.groupBoxCRUD.ResumeLayout(false);
            this.groupBoxCustomerC.ResumeLayout(false);
            this.groupBoxCustomerC.PerformLayout();
            this.groupBoxCCInput.ResumeLayout(false);
            this.groupBoxCCInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBoxCustomerC;
      private System.Windows.Forms.Label labelName;
      private System.Windows.Forms.Label labelID;
      private System.Windows.Forms.TextBox textBoxCName;
      private System.Windows.Forms.TextBox textBoxID;
      private System.Windows.Forms.GroupBox groupBoxCCInput;
      private System.Windows.Forms.Label labelCvv;
      private System.Windows.Forms.Label labelExpirationDate;
      private System.Windows.Forms.Label labelCNumber;
      private System.Windows.Forms.Label labelCaName;
      private System.Windows.Forms.TextBox textBoxCvv;
      private System.Windows.Forms.TextBox textBoxCNumber;
      private System.Windows.Forms.TextBox textBoxCaName;
      private System.Windows.Forms.ComboBox comboBoxMonth;
      private System.Windows.Forms.ComboBox comboBoxYear;
   }
}