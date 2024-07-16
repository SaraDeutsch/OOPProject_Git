namespace UI
{
   partial class OrderForm
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
            this.labelON = new System.Windows.Forms.Label();
            this.labelPN = new System.Windows.Forms.Label();
            this.labelCID = new System.Windows.Forms.Label();
            this.labelOQ = new System.Windows.Forms.Label();
            this.groupBoxOrderC = new System.Windows.Forms.GroupBox();
            this.textBoxoq = new System.Windows.Forms.TextBox();
            this.textBoxcid = new System.Windows.Forms.TextBox();
            this.textBoxpn = new System.Windows.Forms.TextBox();
            this.textBoxon = new System.Windows.Forms.TextBox();
            this.labelReadByDirections = new System.Windows.Forms.Label();
            this.groupBoxCRUD.SuspendLayout();
            this.groupBoxOrderC.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxShowProduct
            // 
            this.textBoxShowProduct.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxShowProduct.Size = new System.Drawing.Size(576, 885);
            // 
            // buttonDEnter
            // 
            this.buttonDEnter.Location = new System.Drawing.Point(220, 422);
            // 
            // labelON
            // 
            this.labelON.AutoSize = true;
            this.labelON.Location = new System.Drawing.Point(0, 59);
            this.labelON.Name = "labelON";
            this.labelON.Size = new System.Drawing.Size(109, 20);
            this.labelON.TabIndex = 27;
            this.labelON.Text = "Order Number";
            // 
            // labelPN
            // 
            this.labelPN.AutoSize = true;
            this.labelPN.Location = new System.Drawing.Point(0, 131);
            this.labelPN.Name = "labelPN";
            this.labelPN.Size = new System.Drawing.Size(124, 20);
            this.labelPN.TabIndex = 28;
            this.labelPN.Text = "Product Number";
            // 
            // labelCID
            // 
            this.labelCID.AutoSize = true;
            this.labelCID.Location = new System.Drawing.Point(7, 191);
            this.labelCID.Name = "labelCID";
            this.labelCID.Size = new System.Drawing.Size(99, 20);
            this.labelCID.TabIndex = 29;
            this.labelCID.Text = "Customer ID";
            // 
            // labelOQ
            // 
            this.labelOQ.AutoSize = true;
            this.labelOQ.Location = new System.Drawing.Point(7, 239);
            this.labelOQ.Name = "labelOQ";
            this.labelOQ.Size = new System.Drawing.Size(68, 20);
            this.labelOQ.TabIndex = 30;
            this.labelOQ.Text = "Quantity";
            // 
            // groupBoxOrderC
            // 
            this.groupBoxOrderC.Controls.Add(this.textBoxoq);
            this.groupBoxOrderC.Controls.Add(this.textBoxcid);
            this.groupBoxOrderC.Controls.Add(this.textBoxpn);
            this.groupBoxOrderC.Controls.Add(this.textBoxon);
            this.groupBoxOrderC.Controls.Add(this.labelON);
            this.groupBoxOrderC.Controls.Add(this.labelOQ);
            this.groupBoxOrderC.Controls.Add(this.labelPN);
            this.groupBoxOrderC.Controls.Add(this.labelCID);
            this.groupBoxOrderC.Location = new System.Drawing.Point(14, 42);
            this.groupBoxOrderC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxOrderC.Name = "groupBoxOrderC";
            this.groupBoxOrderC.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxOrderC.Size = new System.Drawing.Size(273, 360);
            this.groupBoxOrderC.TabIndex = 31;
            this.groupBoxOrderC.TabStop = false;
            this.groupBoxOrderC.Text = "Orders";
            // 
            // textBoxoq
            // 
            this.textBoxoq.Location = new System.Drawing.Point(126, 239);
            this.textBoxoq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxoq.Name = "textBoxoq";
            this.textBoxoq.Size = new System.Drawing.Size(112, 26);
            this.textBoxoq.TabIndex = 34;
            // 
            // textBoxcid
            // 
            this.textBoxcid.Location = new System.Drawing.Point(126, 191);
            this.textBoxcid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxcid.Name = "textBoxcid";
            this.textBoxcid.Size = new System.Drawing.Size(112, 26);
            this.textBoxcid.TabIndex = 33;
            this.textBoxcid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxcid_KeyDown_1);
            // 
            // textBoxpn
            // 
            this.textBoxpn.Location = new System.Drawing.Point(126, 124);
            this.textBoxpn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxpn.Name = "textBoxpn";
            this.textBoxpn.Size = new System.Drawing.Size(112, 26);
            this.textBoxpn.TabIndex = 32;
            this.textBoxpn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxpn_KeyDown);
            // 
            // textBoxon
            // 
            this.textBoxon.Location = new System.Drawing.Point(126, 55);
            this.textBoxon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxon.Name = "textBoxon";
            this.textBoxon.Size = new System.Drawing.Size(112, 26);
            this.textBoxon.TabIndex = 31;
            this.textBoxon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxon_KeyDown);
            // 
            // labelReadByDirections
            // 
            this.labelReadByDirections.AutoSize = true;
            this.labelReadByDirections.Location = new System.Drawing.Point(21, 9);
            this.labelReadByDirections.Name = "labelReadByDirections";
            this.labelReadByDirections.Size = new System.Drawing.Size(359, 20);
            this.labelReadByDirections.TabIndex = 32;
            this.labelReadByDirections.Text = "Read by either, order #, Product #, or customerID:";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 866);
            this.Controls.Add(this.labelReadByDirections);
            this.Controls.Add(this.groupBoxOrderC);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.Controls.SetChildIndex(this.textBoxShowProduct, 0);
            this.Controls.SetChildIndex(this.groupBoxCRUD, 0);
            this.Controls.SetChildIndex(this.buttonReturn, 0);
            this.Controls.SetChildIndex(this.buttonCEnter, 0);
            this.Controls.SetChildIndex(this.buttonREnter, 0);
            this.Controls.SetChildIndex(this.buttonUEnter, 0);
            this.Controls.SetChildIndex(this.buttonDEnter, 0);
            this.Controls.SetChildIndex(this.groupBoxOrderC, 0);
            this.Controls.SetChildIndex(this.labelReadByDirections, 0);
            this.groupBoxCRUD.ResumeLayout(false);
            this.groupBoxOrderC.ResumeLayout(false);
            this.groupBoxOrderC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label labelON;
      private System.Windows.Forms.Label labelPN;
      private System.Windows.Forms.Label labelCID;
      private System.Windows.Forms.Label labelOQ;
      private System.Windows.Forms.GroupBox groupBoxOrderC;
      private System.Windows.Forms.TextBox textBoxoq;
      private System.Windows.Forms.TextBox textBoxcid;
      private System.Windows.Forms.TextBox textBoxpn;
      private System.Windows.Forms.TextBox textBoxon;
        private System.Windows.Forms.Label labelReadByDirections;
    }
}